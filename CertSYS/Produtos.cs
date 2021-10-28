using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertSYS
{
    public partial class frmProdutos : Form
    {
        bool FecharForm = false;
        private string Conexao = @"Data Source=NB_ROMMEL2021\SQLEXPRESS;Initial Catalog=CertSYS;Integrated Security=True";
        SqlConnection Conect = null;
        SqlCommand Command = null;

        [Obsolete]
        public frmProdutos()
        {
            InitializeComponent();
        }

        public void listaGridProdutos()
        {
            string ConexaoSQL = "Select [pro_cod] as 'ID', p.[pro_nome] as 'Nome', f.[for_nome] as 'Fornecedor', p.[pro_qtde] as 'Quantidade' from [produto] p " +
                            "inner join [fornecedor] f on f.[for_cod] = p.[for_cod]";
            Conect = new SqlConnection(Conexao);
            Command = new SqlCommand(ConexaoSQL, Conect);

            try
            {
                SqlDataAdapter CommandSql = new SqlDataAdapter(Command);
                DataTable dtLista = new DataTable();
                CommandSql.Fill(dtLista);
                dgvProduto.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao consultar!");
            }
        }

        public void listaGridProdutosBusca()
        {
            string buscaoSQL = "Select [pro_cod] as 'ID', p.[pro_nome] as 'Nome', f.[for_nome] as 'Fornecedor', p.[pro_qtde] as 'Quantidade' from [produto] p " +
                "inner join [fornecedor] f on f.[for_cod] = p.[for_cod] WHERE p.[pro_nome] LIKE '" + '%' + txtPesquisaProduto.Text + '%' + "'";
            Conect = new SqlConnection(Conexao);
            Command = new SqlCommand(buscaoSQL, Conect);

            try
            {
                SqlDataAdapter buscaSql = new SqlDataAdapter(Command);
                DataTable dtLista = new DataTable();
                buscaSql.Fill(dtLista);
                dgvProduto.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao consultar!");
            }
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            listaGridProdutos();
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            if (dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString() != "" & dgvProduto[1, dgvProduto.CurrentRow.Index].Value.ToString() != "" & dgvProduto[2, dgvProduto.CurrentRow.Index].Value.ToString() != "")
            {
                Conect.Open();
                Command.CommandText = "DELETE FROM produto WHERE pro_cod = '" + dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString() + "' ";
                Command.ExecuteNonQuery();
                Conect.Close();
                listaGridProdutos();

                txtNomeProduto.Text = "";
                cbxProdutoFornecedor.Text = "";
                nudQuantidade.Text = "";
            }
        }

        [Obsolete]
        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProduto.RowCount < 0 && txtNomeProduto.Text != "" && nudQuantidade.Value.ToString() != "" && cbxProdutoFornecedor.SelectedValue.ToString() != "")
            {
                Conect.Open();
                Command.CommandText = "INSERT INTO produto (pro_nome, pro_qtde, for_cod) values (@pro_nome, @pro_qtde, (select fornecedor.for_cod from fornecedor where fornecedor.for_nome = @for_nome))";
                Command.Connection = Conect;
                Command.Parameters.Add("@pro_nome", txtNomeProduto.Text);
                Command.Parameters.Add("@for_nome", cbxProdutoFornecedor.SelectedValue.ToString());
                Command.Parameters.Add("@pro_qtde", nudQuantidade.Value.ToString());

                Command.ExecuteNonQuery();
                Conect.Close();
                listaGridProdutos();

                tbpConsultaProduto.Show();
                tbpCadastroProduto.Hide();

                txtNomeProduto.Text = "";
                cbxProdutoFornecedor.Text = "";
                nudQuantidade.Text = "";
            }
            else
            {
                Conect.Open();
                Command.CommandText = "UPDATE [produto] set [pro_nome] = @pro_nome, [pro_qtde] = @pro_qtde, produto.[for_cod] = (select fornecedor.for_cod from fornecedor where fornecedor.for_nome = @for_nome) where [pro_cod] = @pro_cod";
                Command.Connection = Conect;
                Command.Parameters.Add("@pro_cod", idProduto.Text);
                Command.Parameters.Add("@pro_nome", txtNomeProduto.Text);
                Command.Parameters.Add("@pro_qtde", nudQuantidade.Value.ToString());
                Command.Parameters.Add("@for_nome", cbxProdutoFornecedor.Text.ToString());

                Command.ExecuteNonQuery();
                Conect.Close();
                listaGridProdutos();

                txtNomeProduto.Text = "";
                cbxProdutoFornecedor.Text = "";
                nudQuantidade.Text = "";

                tbpConsultaProduto.Show();
                tbpCadastroProduto.Hide();
            }
        }

        private void txtPesquisaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                listaGridProdutosBusca();
        }

        [Obsolete]
        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduto.RowCount > 0)
            {
                idProduto.Text = dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString();
                txtNomeProduto.Text = dgvProduto[1, dgvProduto.CurrentRow.Index].Value.ToString();
                cbxProdutoFornecedor.Text = dgvProduto[2, dgvProduto.CurrentRow.Index].Value.ToString();
                nudQuantidade.Text = dgvProduto[3, dgvProduto.CurrentRow.Index].Value.ToString();

                tbpConsultaProduto.Hide();
                tbpCadastroProduto.Show();
            }
        }

        private void cbxProdutoFornecedor_Click(object sender, EventArgs e)
        {
            Conect.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("Select for_nome from [fornecedor] where for_status = 1 order by for_nome", Conect);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                DataRow row = table.NewRow();
                row["for_nome"] = "";
                table.Rows.InsertAt(row, 0);

                this.cbxProdutoFornecedor.DataSource = table;
                this.cbxProdutoFornecedor.ValueMember = "for_nome";
                this.cbxProdutoFornecedor.DisplayMember = "for_nome";

                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os dados, Erro:" + ex, "Erro!", MessageBoxButtons.OK);
            }
            finally
            {
                Conect.Close();
            }
        }

        private void btnCancelarProdutoFornecedor_Click(object sender, EventArgs e)
        {
            tbpConsultaProduto.Show();
            tbpCadastroProduto.Hide();

            txtNomeProduto.Text = "";
            cbxProdutoFornecedor.Text = "";
            nudQuantidade.Text = "";
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            tbpConsultaProduto.Hide();
            tbpCadastroProduto.Show();
        }
    }
}
