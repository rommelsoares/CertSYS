using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertSYS
{
    public partial class frmFornecedores : Form
    {
        bool FecharForm = false;
        private string Conexao = @"Data Source=NB_ROMMEL2021\SQLEXPRESS;Initial Catalog=CertSYS;Integrated Security=True";
        SqlConnection Conect = null;
        SqlCommand Command = null;

        [Obsolete]
        public frmFornecedores()
        {
            InitializeComponent();
        }

        public void listaGrid()
        {
            string ConexaoSQL = "Select [for_cod] as 'ID', [for_nome] as 'Nome', [for_cnpj] as 'CNPJ', [for_endereco] as 'Endereço', [for_status] as 'Ativo' from [fornecedor] where [for_status] = 1";
            Conect = new SqlConnection(Conexao);
            Command = new SqlCommand(ConexaoSQL, Conect);

            try
            {
                SqlDataAdapter CommandSql = new SqlDataAdapter(Command);
                DataTable dtLista = new DataTable();
                CommandSql.Fill(dtLista);
                dgvFornecedor.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao consultar!");
            }
        }

        public void listaGridBusca()
        {
            string buscaoSQL = "Select [for_cod] as 'ID', [for_nome] as 'Nome', [for_cnpj] as 'CNPJ', [for_endereco] as 'Endereço' from [fornecedor] WHERE for_nome LIKE '" + '%' + txtPesquisaFornecedor.Text + '%' + "' AND [for_status] = 1";
            Conect = new SqlConnection(Conexao);
            Command = new SqlCommand(buscaoSQL, Conect);

            try
            {
                SqlDataAdapter buscaSql = new SqlDataAdapter(Command);
                DataTable dtLista = new DataTable();
                buscaSql.Fill(dtLista);
                dgvFornecedor.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao consultar!");
            }
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor[0, dgvFornecedor.CurrentRow.Index].Value.ToString() != "" & dgvFornecedor[1, dgvFornecedor.CurrentRow.Index].Value.ToString() != "" & dgvFornecedor[2, dgvFornecedor.CurrentRow.Index].Value.ToString() != "" && dgvFornecedor[3, dgvFornecedor.CurrentRow.Index].Value.ToString() != "")
            {
                Conect.Open();
                Command.CommandText = "UPDATE [fornecedor] set [for_status] = 0 where [for_cod] = '" + dgvFornecedor[0, dgvFornecedor.CurrentRow.Index].Value.ToString() + "'";
                Command.ExecuteNonQuery();
                Conect.Close();
                listaGrid();
            }
        }

        [Obsolete]
        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.RowCount < 0  && txtNomeCadastroFornecedor.Text != "" && txtCNPJCadastroFornecedor.Text != "" && txtEnderecoCadastroFornecedor.Text != "")
            {
                Conect.Open();
                Command.CommandText = "INSERT INTO [fornecedor] ([for_nome],[for_cnpj],[for_endereco],[for_status]) values ('" + txtNomeCadastroFornecedor.Text + "', '" + txtCNPJCadastroFornecedor.Text + "', '" + txtEnderecoCadastroFornecedor.Text + "', 1)";
                Command.ExecuteNonQuery();
                Conect.Close();
                listaGrid();

                txtNomeCadastroFornecedor.Text = "";
                txtCNPJCadastroFornecedor.Text = "";
                txtEnderecoCadastroFornecedor.Text = "";

                tbpConsultaFornecedor.Show();
                tbpCadastroFornecedor.Hide();
            }
            else
            {
                Conect.Open();
                Command.CommandText = "UPDATE [fornecedor] set [for_nome] = @for_nome, [for_cnpj] = @for_cnpj, [for_endereco] = @for_endereco, [for_status] = @for_status where for_cod = @for_cod";
                Command.Connection = Conect;
                Command.Parameters.Add("@for_cod", idFornecedor.Text);
                Command.Parameters.Add("@for_nome", txtNomeCadastroFornecedor.Text);
                Command.Parameters.Add("@for_cnpj", txtCNPJCadastroFornecedor.Text);
                Command.Parameters.Add("@for_endereco", txtEnderecoCadastroFornecedor.Text);
                Command.Parameters.Add("@for_status", ckbAtivoFornecedor.Checked);

                Command.ExecuteNonQuery();
                Conect.Close();
                listaGrid();

                txtNomeCadastroFornecedor.Text = "";
                txtCNPJCadastroFornecedor.Text = "";
                txtEnderecoCadastroFornecedor.Text = "";

                tbpConsultaFornecedor.Show();
                tbpCadastroFornecedor.Hide();
            }
        }

        private void txtPesquisaFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                listaGridBusca();
        }

        [Obsolete]
        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFornecedor.RowCount > 0)
            {
                idFornecedor.Text = dgvFornecedor[0, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtNomeCadastroFornecedor.Text = dgvFornecedor[1, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtCNPJCadastroFornecedor.Text = dgvFornecedor[2, dgvFornecedor.CurrentRow.Index].Value.ToString();
                txtEnderecoCadastroFornecedor.Text = dgvFornecedor[3, dgvFornecedor.CurrentRow.Index].Value.ToString();

                tbpConsultaFornecedor.Hide();
                tbpCadastroFornecedor.Show();
            }
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            tbpConsultaFornecedor.Hide();
            tbpCadastroFornecedor.Show();

            txtNomeCadastroFornecedor.Text = "";
            txtCNPJCadastroFornecedor.Text = "";
            txtEnderecoCadastroFornecedor.Text = "";
        }

        private void btnCancelarFornecedor_Click(object sender, EventArgs e)
        {
            tbpConsultaFornecedor.Show();
            tbpCadastroFornecedor.Hide();

            txtNomeCadastroFornecedor.Text = "";
            txtCNPJCadastroFornecedor.Text = "";
            txtEnderecoCadastroFornecedor.Text = "";
        }
    }
}
