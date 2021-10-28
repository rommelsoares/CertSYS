
namespace CertSYS
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnCancelarProdutoFornecedor = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblEnderecoFornecedor = new System.Windows.Forms.Label();
            this.lblCNPJFornecedor = new System.Windows.Forms.Label();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.lblPesquisarProduto = new System.Windows.Forms.Label();
            this.tbpConsultaProduto = new System.Windows.Forms.TabPage();
            this.tbpCadastroProduto = new System.Windows.Forms.TabPage();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cbxProdutoFornecedor = new System.Windows.Forms.ComboBox();
            this.tbcProduto = new System.Windows.Forms.TabControl();
            this.idProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.tbpConsultaProduto.SuspendLayout();
            this.tbpCadastroProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.tbcProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(452, 235);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProduto.TabIndex = 8;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnCancelarProdutoFornecedor
            // 
            this.btnCancelarProdutoFornecedor.Location = new System.Drawing.Point(115, 235);
            this.btnCancelarProdutoFornecedor.Name = "btnCancelarProdutoFornecedor";
            this.btnCancelarProdutoFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProdutoFornecedor.TabIndex = 7;
            this.btnCancelarProdutoFornecedor.Text = "Cancelar";
            this.btnCancelarProdutoFornecedor.UseVisualStyleBackColor = true;
            this.btnCancelarProdutoFornecedor.Click += new System.EventHandler(this.btnCancelarProdutoFornecedor_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(180, 69);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(347, 20);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // lblEnderecoFornecedor
            // 
            this.lblEnderecoFornecedor.AutoSize = true;
            this.lblEnderecoFornecedor.Location = new System.Drawing.Point(112, 159);
            this.lblEnderecoFornecedor.Name = "lblEnderecoFornecedor";
            this.lblEnderecoFornecedor.Size = new System.Drawing.Size(62, 13);
            this.lblEnderecoFornecedor.TabIndex = 2;
            this.lblEnderecoFornecedor.Text = "Quantidade";
            // 
            // lblCNPJFornecedor
            // 
            this.lblCNPJFornecedor.AutoSize = true;
            this.lblCNPJFornecedor.Location = new System.Drawing.Point(112, 115);
            this.lblCNPJFornecedor.Name = "lblCNPJFornecedor";
            this.lblCNPJFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblCNPJFornecedor.TabIndex = 1;
            this.lblCNPJFornecedor.Text = "Fornecedor";
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(112, 72);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(35, 13);
            this.lblNomeFornecedor.TabIndex = 0;
            this.lblNomeFornecedor.Text = "Nome";
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Location = new System.Drawing.Point(455, 274);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCadastro.TabIndex = 4;
            this.btnNovoCadastro.Text = "Novo";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.Location = new System.Drawing.Point(107, 275);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCadastro.TabIndex = 3;
            this.btnExcluirCadastro.Text = "Excluir";
            this.btnExcluirCadastro.UseVisualStyleBackColor = true;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProduto.EnableHeadersVisualStyles = false;
            this.dgvProduto.Location = new System.Drawing.Point(107, 88);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.ShowCellErrors = false;
            this.dgvProduto.ShowCellToolTips = false;
            this.dgvProduto.ShowEditingIcon = false;
            this.dgvProduto.ShowRowErrors = false;
            this.dgvProduto.Size = new System.Drawing.Size(424, 170);
            this.dgvProduto.TabIndex = 2;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(193, 50);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(300, 20);
            this.txtPesquisaProduto.TabIndex = 1;
            this.txtPesquisaProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaProduto_KeyDown);
            // 
            // lblPesquisarProduto
            // 
            this.lblPesquisarProduto.AutoSize = true;
            this.lblPesquisarProduto.Location = new System.Drawing.Point(134, 53);
            this.lblPesquisarProduto.Name = "lblPesquisarProduto";
            this.lblPesquisarProduto.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisarProduto.TabIndex = 0;
            this.lblPesquisarProduto.Text = "Pesquisar";
            // 
            // tbpConsultaProduto
            // 
            this.tbpConsultaProduto.Controls.Add(this.idProduto);
            this.tbpConsultaProduto.Controls.Add(this.btnNovoCadastro);
            this.tbpConsultaProduto.Controls.Add(this.btnExcluirCadastro);
            this.tbpConsultaProduto.Controls.Add(this.dgvProduto);
            this.tbpConsultaProduto.Controls.Add(this.txtPesquisaProduto);
            this.tbpConsultaProduto.Controls.Add(this.lblPesquisarProduto);
            this.tbpConsultaProduto.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultaProduto.Name = "tbpConsultaProduto";
            this.tbpConsultaProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultaProduto.Size = new System.Drawing.Size(651, 353);
            this.tbpConsultaProduto.TabIndex = 0;
            this.tbpConsultaProduto.Text = "Consulta";
            this.tbpConsultaProduto.UseVisualStyleBackColor = true;
            // 
            // tbpCadastroProduto
            // 
            this.tbpCadastroProduto.Controls.Add(this.nudQuantidade);
            this.tbpCadastroProduto.Controls.Add(this.cbxProdutoFornecedor);
            this.tbpCadastroProduto.Controls.Add(this.btnSalvarProduto);
            this.tbpCadastroProduto.Controls.Add(this.btnCancelarProdutoFornecedor);
            this.tbpCadastroProduto.Controls.Add(this.txtNomeProduto);
            this.tbpCadastroProduto.Controls.Add(this.lblEnderecoFornecedor);
            this.tbpCadastroProduto.Controls.Add(this.lblCNPJFornecedor);
            this.tbpCadastroProduto.Controls.Add(this.lblNomeFornecedor);
            this.tbpCadastroProduto.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastroProduto.Name = "tbpCadastroProduto";
            this.tbpCadastroProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastroProduto.Size = new System.Drawing.Size(651, 353);
            this.tbpCadastroProduto.TabIndex = 1;
            this.tbpCadastroProduto.Text = "Cadastro";
            this.tbpCadastroProduto.UseVisualStyleBackColor = true;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(180, 157);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(38, 20);
            this.nudQuantidade.TabIndex = 10;
            // 
            // cbxProdutoFornecedor
            // 
            this.cbxProdutoFornecedor.FormattingEnabled = true;
            this.cbxProdutoFornecedor.Location = new System.Drawing.Point(180, 112);
            this.cbxProdutoFornecedor.Name = "cbxProdutoFornecedor";
            this.cbxProdutoFornecedor.Size = new System.Drawing.Size(347, 21);
            this.cbxProdutoFornecedor.TabIndex = 9;
            this.cbxProdutoFornecedor.Click += new System.EventHandler(this.cbxProdutoFornecedor_Click);
            // 
            // tbcProduto
            // 
            this.tbcProduto.Controls.Add(this.tbpConsultaProduto);
            this.tbcProduto.Controls.Add(this.tbpCadastroProduto);
            this.tbcProduto.Location = new System.Drawing.Point(-3, -1);
            this.tbcProduto.Name = "tbcProduto";
            this.tbcProduto.SelectedIndex = 0;
            this.tbcProduto.Size = new System.Drawing.Size(659, 379);
            this.tbcProduto.TabIndex = 1;
            // 
            // idProduto
            // 
            this.idProduto.AutoSize = true;
            this.idProduto.Location = new System.Drawing.Point(4, 4);
            this.idProduto.Name = "idProduto";
            this.idProduto.Size = new System.Drawing.Size(18, 13);
            this.idProduto.TabIndex = 5;
            this.idProduto.Text = "ID";
            this.idProduto.Visible = false;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 376);
            this.Controls.Add(this.tbcProduto);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.tbpConsultaProduto.ResumeLayout(false);
            this.tbpConsultaProduto.PerformLayout();
            this.tbpCadastroProduto.ResumeLayout(false);
            this.tbpCadastroProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.tbcProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Button btnCancelarProdutoFornecedor;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblEnderecoFornecedor;
        private System.Windows.Forms.Label lblCNPJFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.Label lblPesquisarProduto;
        private System.Windows.Forms.TabPage tbpConsultaProduto;
        private System.Windows.Forms.TabPage tbpCadastroProduto;
        private System.Windows.Forms.TabControl tbcProduto;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ComboBox cbxProdutoFornecedor;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label idProduto;
    }
}