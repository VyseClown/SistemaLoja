namespace GUI
{
    partial class frmCADUsuario
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCADUsuario));
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbPessoa = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.cbProduto = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbCaixa = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbVenda = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbConsultaProd = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbPagamentos = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbUsuario = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbDesativado = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Depth = 0;
            this.txtLogin.Hint = "";
            this.txtLogin.Location = new System.Drawing.Point(74, 139);
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(157, 23);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(70, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(74, 239);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(157, 23);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(70, 201);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.Location = new System.Drawing.Point(74, 308);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Primary = true;
            this.btnCadastrar.Size = new System.Drawing.Size(110, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Location = new System.Drawing.Point(202, 308);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = true;
            this.btnAlterar.Size = new System.Drawing.Size(110, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.AutoSize = true;
            this.cbPessoa.Depth = 0;
            this.cbPessoa.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbPessoa.Location = new System.Drawing.Point(373, 139);
            this.cbPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.cbPessoa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPessoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Ripple = true;
            this.cbPessoa.Size = new System.Drawing.Size(153, 30);
            this.cbPessoa.TabIndex = 8;
            this.cbPessoa.Text = "Cadastro de Pessoa";
            this.cbPessoa.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(250, 135);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(39, 30);
            this.btnLocalizar.TabIndex = 84;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // cbProduto
            // 
            this.cbProduto.AutoSize = true;
            this.cbProduto.Depth = 0;
            this.cbProduto.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbProduto.Location = new System.Drawing.Point(373, 201);
            this.cbProduto.Margin = new System.Windows.Forms.Padding(0);
            this.cbProduto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Ripple = true;
            this.cbProduto.Size = new System.Drawing.Size(157, 30);
            this.cbProduto.TabIndex = 85;
            this.cbProduto.Text = "Cadastro de Produto";
            this.cbProduto.UseVisualStyleBackColor = true;
            // 
            // cbCaixa
            // 
            this.cbCaixa.AutoSize = true;
            this.cbCaixa.Depth = 0;
            this.cbCaixa.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbCaixa.Location = new System.Drawing.Point(373, 262);
            this.cbCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.cbCaixa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbCaixa.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbCaixa.Name = "cbCaixa";
            this.cbCaixa.Ripple = true;
            this.cbCaixa.Size = new System.Drawing.Size(64, 30);
            this.cbCaixa.TabIndex = 86;
            this.cbCaixa.Text = "Caixa";
            this.cbCaixa.UseVisualStyleBackColor = true;
            // 
            // cbVenda
            // 
            this.cbVenda.AutoSize = true;
            this.cbVenda.Depth = 0;
            this.cbVenda.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbVenda.Location = new System.Drawing.Point(373, 324);
            this.cbVenda.Margin = new System.Windows.Forms.Padding(0);
            this.cbVenda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbVenda.Name = "cbVenda";
            this.cbVenda.Ripple = true;
            this.cbVenda.Size = new System.Drawing.Size(69, 30);
            this.cbVenda.TabIndex = 87;
            this.cbVenda.Text = "Venda";
            this.cbVenda.UseVisualStyleBackColor = true;
            // 
            // cbConsultaProd
            // 
            this.cbConsultaProd.AutoSize = true;
            this.cbConsultaProd.Depth = 0;
            this.cbConsultaProd.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbConsultaProd.Location = new System.Drawing.Point(570, 135);
            this.cbConsultaProd.Margin = new System.Windows.Forms.Padding(0);
            this.cbConsultaProd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbConsultaProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbConsultaProd.Name = "cbConsultaProd";
            this.cbConsultaProd.Ripple = true;
            this.cbConsultaProd.Size = new System.Drawing.Size(156, 30);
            this.cbConsultaProd.TabIndex = 88;
            this.cbConsultaProd.Text = "Consulta de Produto";
            this.cbConsultaProd.UseVisualStyleBackColor = true;
            // 
            // cbPagamentos
            // 
            this.cbPagamentos.AutoSize = true;
            this.cbPagamentos.Depth = 0;
            this.cbPagamentos.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbPagamentos.Location = new System.Drawing.Point(570, 197);
            this.cbPagamentos.Margin = new System.Windows.Forms.Padding(0);
            this.cbPagamentos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPagamentos.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPagamentos.Name = "cbPagamentos";
            this.cbPagamentos.Ripple = true;
            this.cbPagamentos.Size = new System.Drawing.Size(108, 30);
            this.cbPagamentos.TabIndex = 89;
            this.cbPagamentos.Text = "Pagamentos";
            this.cbPagamentos.UseVisualStyleBackColor = true;
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoSize = true;
            this.cbUsuario.Depth = 0;
            this.cbUsuario.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbUsuario.Location = new System.Drawing.Point(570, 262);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.cbUsuario.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Ripple = true;
            this.cbUsuario.Size = new System.Drawing.Size(141, 30);
            this.cbUsuario.TabIndex = 90;
            this.cbUsuario.Text = "Cadastrar Usuario";
            this.cbUsuario.UseVisualStyleBackColor = true;
            // 
            // cbDesativado
            // 
            this.cbDesativado.AutoSize = true;
            this.cbDesativado.Depth = 0;
            this.cbDesativado.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbDesativado.Location = new System.Drawing.Point(570, 324);
            this.cbDesativado.Margin = new System.Windows.Forms.Padding(0);
            this.cbDesativado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbDesativado.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbDesativado.Name = "cbDesativado";
            this.cbDesativado.Ripple = true;
            this.cbDesativado.Size = new System.Drawing.Size(99, 30);
            this.cbDesativado.TabIndex = 91;
            this.cbDesativado.Text = "Desativado";
            this.cbDesativado.UseVisualStyleBackColor = true;
            // 
            // frmCADUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbDesativado);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.cbPagamentos);
            this.Controls.Add(this.cbConsultaProd);
            this.Controls.Add(this.cbVenda);
            this.Controls.Add(this.cbCaixa);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.cbPessoa);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmCADUsuario";
            this.Text = "Cadastrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        private MaterialSkin.Controls.MaterialCheckBox cbPessoa;
        private System.Windows.Forms.Button btnLocalizar;
        private MaterialSkin.Controls.MaterialCheckBox cbProduto;
        private MaterialSkin.Controls.MaterialCheckBox cbCaixa;
        private MaterialSkin.Controls.MaterialCheckBox cbVenda;
        private MaterialSkin.Controls.MaterialCheckBox cbConsultaProd;
        private MaterialSkin.Controls.MaterialCheckBox cbPagamentos;
        private MaterialSkin.Controls.MaterialCheckBox cbUsuario;
        private MaterialSkin.Controls.MaterialCheckBox cbDesativado;
    }
}