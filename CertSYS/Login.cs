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
    public partial class frmLogin : Form
    {
        bool FecharForm = false;
        SqlConnection Conexao = new SqlConnection(@"Data Source=NB_ROMMEL2021\SQLEXPRESS;Initial Catalog=CertSYS;Integrated Security=True");

        [Obsolete]
        public frmLogin()
        {
            InitializeComponent();
        }

        void verificarVazio()
        {
            if(txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Nenhuma informação foi preenchida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Select();
            }
        }

        [Obsolete]
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conexao.Open();
            verificarVazio();
            string query = "Select * from [usuario] where usu_login = '" + txtUsuario.Text + "' and usu_senha = '" + txtSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            try
            {
                if (dt.Rows.Count == 1)
                {
                    frmSistema sistema = new frmSistema();
                    this.Hide();
                    this.FecharForm = true;
                    sistema.Show();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Usuário ou senha inválidos!"+erro);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Select();
            }

            Conexao.Close();
            //this.Hide();
            //Form f = new frmSistema();
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.FecharForm = true;
            this.Close();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
