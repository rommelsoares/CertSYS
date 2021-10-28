
namespace CertSYS
{
    partial class frmFornecedores
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
            this.components = new System.ComponentModel.Container();
            this.tbcFornecedor = new System.Windows.Forms.TabControl();
            this.tbpConsultaFornecedor = new System.Windows.Forms.TabPage();
            this.btnNovoFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.txtPesquisaFornecedor = new System.Windows.Forms.TextBox();
            this.lblPesquisarFornecedor = new System.Windows.Forms.Label();
            this.tbpCadastroFornecedor = new System.Windows.Forms.TabPage();
            this.idFornecedor = new System.Windows.Forms.Label();
            this.btnSalvarFornecedor = new System.Windows.Forms.Button();
            this.btnCancelarFornecedor = new System.Windows.Forms.Button();
            this.ckbAtivoFornecedor = new System.Windows.Forms.CheckBox();
            this.txtEnderecoCadastroFornecedor = new System.Windows.Forms.TextBox();
            this.txtCNPJCadastroFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeCadastroFornecedor = new System.Windows.Forms.TextBox();
            this.lblEnderecoFornecedor = new System.Windows.Forms.Label();
            this.lblCNPJFornecedor = new System.Windows.Forms.Label();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certSYSDataSet = new CertSYS.CertSYSDataSet();
            this.tbcFornecedor.SuspendLayout();
            this.tbpConsultaFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.tbpCadastroFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certSYSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcFornecedor
            // 
            this.tbcFornecedor.Controls.Add(this.tbpConsultaFornecedor);
            this.tbcFornecedor.Controls.Add(this.tbpCadastroFornecedor);
            this.tbcFornecedor.Location = new System.Drawing.Point(-4, -2);
            this.tbcFornecedor.Name = "tbcFornecedor";
            this.tbcFornecedor.SelectedIndex = 0;
            this.tbcFornecedor.Size = new System.Drawing.Size(659, 379);
            this.tbcFornecedor.TabIndex = 0;
            // 
            // tbpConsultaFornecedor
            // 
            this.tbpConsultaFornecedor.Controls.Add(this.btnNovoFornecedor);
            this.tbpConsultaFornecedor.Controls.Add(this.btnExcluirFornecedor);
            this.tbpConsultaFornecedor.Controls.Add(this.dgvFornecedor);
            this.tbpConsultaFornecedor.Controls.Add(this.txtPesquisaFornecedor);
            this.tbpConsultaFornecedor.Controls.Add(this.lblPesquisarFornecedor);
            this.tbpConsultaFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultaFornecedor.Name = "tbpConsultaFornecedor";
            this.tbpConsultaFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultaFornecedor.Size = new System.Drawing.Size(651, 353);
            this.tbpConsultaFornecedor.TabIndex = 0;
            this.tbpConsultaFornecedor.Text = "Consulta";
            this.tbpConsultaFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.Location = new System.Drawing.Point(455, 274);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnNovoFornecedor.TabIndex = 4;
            this.btnNovoFornecedor.Text = "Novo";
            this.btnNovoFornecedor.UseVisualStyleBackColor = true;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(107, 275);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFornecedor.TabIndex = 3;
            this.btnExcluirFornecedor.Text = "Excluir";
            this.btnExcluirFornecedor.UseVisualStyleBackColor = true;
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFornecedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFornecedor.EnableHeadersVisualStyles = false;
            this.dgvFornecedor.Location = new System.Drawing.Point(107, 88);
            this.dgvFornecedor.MultiSelect = false;
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersVisible = false;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(424, 170);
            this.dgvFornecedor.TabIndex = 2;
            this.dgvFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellDoubleClick);
            // 
            // txtPesquisaFornecedor
            // 
            this.txtPesquisaFornecedor.Location = new System.Drawing.Point(193, 50);
            this.txtPesquisaFornecedor.Name = "txtPesquisaFornecedor";
            this.txtPesquisaFornecedor.Size = new System.Drawing.Size(300, 20);
            this.txtPesquisaFornecedor.TabIndex = 1;
            this.txtPesquisaFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaFornecedor_KeyDown);
            // 
            // lblPesquisarFornecedor
            // 
            this.lblPesquisarFornecedor.AutoSize = true;
            this.lblPesquisarFornecedor.Location = new System.Drawing.Point(134, 53);
            this.lblPesquisarFornecedor.Name = "lblPesquisarFornecedor";
            this.lblPesquisarFornecedor.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisarFornecedor.TabIndex = 0;
            this.lblPesquisarFornecedor.Text = "Pesquisar";
            // 
            // tbpCadastroFornecedor
            // 
            this.tbpCadastroFornecedor.Controls.Add(this.idFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.btnSalvarFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.btnCancelarFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.ckbAtivoFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.txtEnderecoCadastroFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.txtCNPJCadastroFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.txtNomeCadastroFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.lblEnderecoFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.lblCNPJFornecedor);
            this.tbpCadastroFornecedor.Controls.Add(this.lblNomeFornecedor);
            this.tbpCadastroFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastroFornecedor.Name = "tbpCadastroFornecedor";
            this.tbpCadastroFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastroFornecedor.Size = new System.Drawing.Size(651, 353);
            this.tbpCadastroFornecedor.TabIndex = 1;
            this.tbpCadastroFornecedor.Text = "Cadastro";
            this.tbpCadastroFornecedor.UseVisualStyleBackColor = true;
            // 
            // idFornecedor
            // 
            this.idFornecedor.AutoSize = true;
            this.idFornecedor.Location = new System.Drawing.Point(3, 3);
            this.idFornecedor.Name = "idFornecedor";
            this.idFornecedor.Size = new System.Drawing.Size(18, 13);
            this.idFornecedor.TabIndex = 9;
            this.idFornecedor.Text = "ID";
            this.idFornecedor.Visible = false;
            // 
            // btnSalvarFornecedor
            // 
            this.btnSalvarFornecedor.Location = new System.Drawing.Point(452, 235);
            this.btnSalvarFornecedor.Name = "btnSalvarFornecedor";
            this.btnSalvarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFornecedor.TabIndex = 8;
            this.btnSalvarFornecedor.Text = "Salvar";
            this.btnSalvarFornecedor.UseVisualStyleBackColor = true;
            this.btnSalvarFornecedor.Click += new System.EventHandler(this.btnSalvarFornecedor_Click);
            // 
            // btnCancelarFornecedor
            // 
            this.btnCancelarFornecedor.Location = new System.Drawing.Point(115, 235);
            this.btnCancelarFornecedor.Name = "btnCancelarFornecedor";
            this.btnCancelarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarFornecedor.TabIndex = 7;
            this.btnCancelarFornecedor.Text = "Cancelar";
            this.btnCancelarFornecedor.UseVisualStyleBackColor = true;
            this.btnCancelarFornecedor.Click += new System.EventHandler(this.btnCancelarFornecedor_Click);
            // 
            // ckbAtivoFornecedor
            // 
            this.ckbAtivoFornecedor.AutoSize = true;
            this.ckbAtivoFornecedor.Location = new System.Drawing.Point(168, 194);
            this.ckbAtivoFornecedor.Name = "ckbAtivoFornecedor";
            this.ckbAtivoFornecedor.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivoFornecedor.TabIndex = 6;
            this.ckbAtivoFornecedor.Text = "Ativo";
            this.ckbAtivoFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtEnderecoCadastroFornecedor
            // 
            this.txtEnderecoCadastroFornecedor.Location = new System.Drawing.Point(168, 156);
            this.txtEnderecoCadastroFornecedor.Name = "txtEnderecoCadastroFornecedor";
            this.txtEnderecoCadastroFornecedor.Size = new System.Drawing.Size(359, 20);
            this.txtEnderecoCadastroFornecedor.TabIndex = 5;
            // 
            // txtCNPJCadastroFornecedor
            // 
            this.txtCNPJCadastroFornecedor.Location = new System.Drawing.Point(168, 112);
            this.txtCNPJCadastroFornecedor.MaxLength = 14;
            this.txtCNPJCadastroFornecedor.Name = "txtCNPJCadastroFornecedor";
            this.txtCNPJCadastroFornecedor.Size = new System.Drawing.Size(359, 20);
            this.txtCNPJCadastroFornecedor.TabIndex = 4;
            // 
            // txtNomeCadastroFornecedor
            // 
            this.txtNomeCadastroFornecedor.Location = new System.Drawing.Point(168, 69);
            this.txtNomeCadastroFornecedor.Name = "txtNomeCadastroFornecedor";
            this.txtNomeCadastroFornecedor.Size = new System.Drawing.Size(359, 20);
            this.txtNomeCadastroFornecedor.TabIndex = 3;
            // 
            // lblEnderecoFornecedor
            // 
            this.lblEnderecoFornecedor.AutoSize = true;
            this.lblEnderecoFornecedor.Location = new System.Drawing.Point(112, 159);
            this.lblEnderecoFornecedor.Name = "lblEnderecoFornecedor";
            this.lblEnderecoFornecedor.Size = new System.Drawing.Size(53, 13);
            this.lblEnderecoFornecedor.TabIndex = 2;
            this.lblEnderecoFornecedor.Text = "Endereço";
            // 
            // lblCNPJFornecedor
            // 
            this.lblCNPJFornecedor.AutoSize = true;
            this.lblCNPJFornecedor.Location = new System.Drawing.Point(112, 115);
            this.lblCNPJFornecedor.Name = "lblCNPJFornecedor";
            this.lblCNPJFornecedor.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJFornecedor.TabIndex = 1;
            this.lblCNPJFornecedor.Text = "CNPJ";
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
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            // 
            // certSYSDataSet
            // 
            this.certSYSDataSet.DataSetName = "CertSYSDataSet";
            this.certSYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 376);
            this.Controls.Add(this.tbcFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedores_Load);
            this.tbcFornecedor.ResumeLayout(false);
            this.tbpConsultaFornecedor.ResumeLayout(false);
            this.tbpConsultaFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.tbpCadastroFornecedor.ResumeLayout(false);
            this.tbpCadastroFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certSYSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcFornecedor;
        private System.Windows.Forms.TabPage tbpConsultaFornecedor;
        private System.Windows.Forms.TabPage tbpCadastroFornecedor;
        private System.Windows.Forms.Button btnNovoFornecedor;
        private System.Windows.Forms.Button btnExcluirFornecedor;
        private System.Windows.Forms.TextBox txtPesquisaFornecedor;
        private System.Windows.Forms.Label lblPesquisarFornecedor;
        private System.Windows.Forms.Button btnSalvarFornecedor;
        private System.Windows.Forms.Button btnCancelarFornecedor;
        private System.Windows.Forms.CheckBox ckbAtivoFornecedor;
        private System.Windows.Forms.TextBox txtEnderecoCadastroFornecedor;
        private System.Windows.Forms.TextBox txtCNPJCadastroFornecedor;
        private System.Windows.Forms.TextBox txtNomeCadastroFornecedor;
        private System.Windows.Forms.Label lblEnderecoFornecedor;
        private System.Windows.Forms.Label lblCNPJFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private CertSYSDataSet certSYSDataSet;
        private System.Windows.Forms.Label idFornecedor;
    }
}