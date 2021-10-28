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
    public partial class frmSistema : Form
    {
        bool FecharForm = false;
        SqlConnection Conexao = new SqlConnection(@"Data Source=NB_ROMMEL2021\SQLEXPRESS;Initial Catalog=CertSYS;Integrated Security=True");

        [Obsolete]
        public frmSistema()
        {
            InitializeComponent();
        }

        private frmFornecedores frmFornecedores = null;
        private frmProdutos frmProdutos = null;

        private void frmSistema_Load(object sender, EventArgs e)
        {
            cadastroToolStripMenuItem.ShowDropDown();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FecharForm = true;
            this.Close();
        }

        [Obsolete]
        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmFornecedores = new frmFornecedores();
            this.frmFornecedores.TopLevel = false;
            this.frmFornecedores.Visible = true;
            this.Controls.Add(this.frmFornecedores);
            this.frmFornecedores.Location = new Point(
                this.ClientSize = new System.Drawing.Size(292, 113));
        }

        [Obsolete]
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmProdutos = new frmProdutos();
            this.frmProdutos.TopLevel = false;
            this.frmProdutos.Visible = true;
            this.Controls.Add(this.frmProdutos);
            this.frmProdutos.Location = new Point(
                this.ClientSize = new System.Drawing.Size(292, 113));
        }
    }
}
