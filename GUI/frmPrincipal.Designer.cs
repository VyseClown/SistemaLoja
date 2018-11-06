namespace GUI
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCADProduto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVenda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCONProduto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCADPessoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPagamento = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCaixa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRelatorio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // btnCADProduto
            // 
            this.btnCADProduto.Depth = 0;
            this.btnCADProduto.Location = new System.Drawing.Point(33, 120);
            this.btnCADProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCADProduto.Name = "btnCADProduto";
            this.btnCADProduto.Primary = true;
            this.btnCADProduto.Size = new System.Drawing.Size(157, 67);
            this.btnCADProduto.TabIndex = 0;
            this.btnCADProduto.Text = "Cadastro de Produto";
            this.btnCADProduto.UseVisualStyleBackColor = true;
            this.btnCADProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Depth = 0;
            this.btnVenda.Location = new System.Drawing.Point(199, 120);
            this.btnVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Primary = true;
            this.btnVenda.Size = new System.Drawing.Size(148, 67);
            this.btnVenda.TabIndex = 1;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnCONProduto
            // 
            this.btnCONProduto.Depth = 0;
            this.btnCONProduto.Location = new System.Drawing.Point(199, 204);
            this.btnCONProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCONProduto.Name = "btnCONProduto";
            this.btnCONProduto.Primary = true;
            this.btnCONProduto.Size = new System.Drawing.Size(148, 67);
            this.btnCONProduto.TabIndex = 3;
            this.btnCONProduto.Text = "Consulta de Produto";
            this.btnCONProduto.UseVisualStyleBackColor = true;
            this.btnCONProduto.Click += new System.EventHandler(this.btnConsultaProd_Click);
            // 
            // btnCADPessoa
            // 
            this.btnCADPessoa.Depth = 0;
            this.btnCADPessoa.Location = new System.Drawing.Point(33, 204);
            this.btnCADPessoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCADPessoa.Name = "btnCADPessoa";
            this.btnCADPessoa.Primary = true;
            this.btnCADPessoa.Size = new System.Drawing.Size(157, 67);
            this.btnCADPessoa.TabIndex = 2;
            this.btnCADPessoa.Text = "Cadastro de Pessoa";
            this.btnCADPessoa.UseVisualStyleBackColor = true;
            this.btnCADPessoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Depth = 0;
            this.btnPagamento.Location = new System.Drawing.Point(199, 289);
            this.btnPagamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Primary = true;
            this.btnPagamento.Size = new System.Drawing.Size(148, 67);
            this.btnPagamento.TabIndex = 5;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Depth = 0;
            this.btnCaixa.Location = new System.Drawing.Point(33, 289);
            this.btnCaixa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Primary = true;
            this.btnCaixa.Size = new System.Drawing.Size(157, 67);
            this.btnCaixa.TabIndex = 4;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Depth = 0;
            this.btnUsuario.Location = new System.Drawing.Point(33, 372);
            this.btnUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Primary = true;
            this.btnUsuario.Size = new System.Drawing.Size(157, 67);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "Cadastro de usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Depth = 0;
            this.btnRelatorio.Location = new System.Drawing.Point(199, 372);
            this.btnRelatorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Primary = true;
            this.btnRelatorio.Size = new System.Drawing.Size(148, 67);
            this.btnRelatorio.TabIndex = 7;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 506);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnCONProduto);
            this.Controls.Add(this.btnCADPessoa);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnCADProduto);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton btnCADProduto;
        private MaterialSkin.Controls.MaterialRaisedButton btnVenda;
        private MaterialSkin.Controls.MaterialRaisedButton btnCONProduto;
        private MaterialSkin.Controls.MaterialRaisedButton btnCADPessoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnPagamento;
        private MaterialSkin.Controls.MaterialRaisedButton btnCaixa;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnRelatorio;
    }
}

