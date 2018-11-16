namespace GUI
{
    partial class frmCONRelatorio
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
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnRelatorioInventario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbRecorrente = new System.Windows.Forms.CheckBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInadimplentes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDiasInad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.btnFinanceiro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicioFinanceiro = new System.Windows.Forms.DateTimePicker();
            this.dtpFimFinanceiro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataInicioFinanceiro = new System.Windows.Forms.MaskedTextBox();
            this.txtDataFimFinanceiro = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCondicionais = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpInicioCondicionais = new System.Windows.Forms.DateTimePicker();
            this.dtpFimCondicionais = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVendasMarcas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpInicioVendasMarcas = new System.Windows.Forms.DateTimePicker();
            this.dtpFimVendasMarcas = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(53, 52);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(227, 33);
            this.cbCategoria.TabIndex = 105;
            // 
            // btnRelatorioInventario
            // 
            this.btnRelatorioInventario.Depth = 0;
            this.btnRelatorioInventario.Location = new System.Drawing.Point(53, 114);
            this.btnRelatorioInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelatorioInventario.Name = "btnRelatorioInventario";
            this.btnRelatorioInventario.Primary = true;
            this.btnRelatorioInventario.Size = new System.Drawing.Size(131, 36);
            this.btnRelatorioInventario.TabIndex = 104;
            this.btnRelatorioInventario.Text = "Relatorio";
            this.btnRelatorioInventario.UseVisualStyleBackColor = true;
            this.btnRelatorioInventario.Click += new System.EventHandler(this.btnRelatorioInventario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(328, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(48, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = "Categoria";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Enabled = false;
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(481, 155);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(134, 30);
            this.dtpDataFinal.TabIndex = 101;
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(333, 153);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(131, 30);
            this.dtpData.TabIndex = 100;
            // 
            // cbRecorrente
            // 
            this.cbRecorrente.AutoSize = true;
            this.cbRecorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cbRecorrente.Location = new System.Drawing.Point(333, 93);
            this.cbRecorrente.Name = "cbRecorrente";
            this.cbRecorrente.Size = new System.Drawing.Size(136, 29);
            this.cbRecorrente.TabIndex = 98;
            this.cbRecorrente.Text = "Recorrente";
            this.cbRecorrente.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.txtValor.Location = new System.Drawing.Point(566, 93);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 30);
            this.txtValor.TabIndex = 99;
            // 
            // btnInadimplentes
            // 
            this.btnInadimplentes.Depth = 0;
            this.btnInadimplentes.Location = new System.Drawing.Point(58, 103);
            this.btnInadimplentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInadimplentes.Name = "btnInadimplentes";
            this.btnInadimplentes.Primary = true;
            this.btnInadimplentes.Size = new System.Drawing.Size(131, 36);
            this.btnInadimplentes.TabIndex = 106;
            this.btnInadimplentes.Text = "Relatorio";
            this.btnInadimplentes.UseVisualStyleBackColor = true;
            this.btnInadimplentes.Click += new System.EventHandler(this.btnInadimplentes_Click);
            // 
            // txtDiasInad
            // 
            this.txtDiasInad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.txtDiasInad.Location = new System.Drawing.Point(58, 67);
            this.txtDiasInad.MaxLength = 4;
            this.txtDiasInad.Name = "txtDiasInad";
            this.txtDiasInad.Size = new System.Drawing.Size(100, 30);
            this.txtDiasInad.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 107;
            this.label1.Text = "Dias de inadimplência";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Location = new System.Drawing.Point(12, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 229);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.cbCategoria);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.btnRelatorioInventario);
            this.tabPage6.Controls.Add(this.txtValor);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.cbRecorrente);
            this.tabPage6.Controls.Add(this.dtpData);
            this.tabPage6.Controls.Add(this.dtpDataFinal);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(760, 203);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Relatorio de inventário";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.btnInadimplentes);
            this.tabPage7.Controls.Add(this.txtDiasInad);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(760, 203);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Relatorio de Inadimplentes";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.txtDataFimFinanceiro);
            this.tabPage8.Controls.Add(this.txtDataInicioFinanceiro);
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Controls.Add(this.btnFinanceiro);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.dtpInicioFinanceiro);
            this.tabPage8.Controls.Add(this.dtpFimFinanceiro);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(760, 203);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Relatorio Financeiro";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label6);
            this.tabPage9.Controls.Add(this.btnCondicionais);
            this.tabPage9.Controls.Add(this.label7);
            this.tabPage9.Controls.Add(this.dtpInicioCondicionais);
            this.tabPage9.Controls.Add(this.dtpFimCondicionais);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(760, 203);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "Relatório de condicionais";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.label8);
            this.tabPage10.Controls.Add(this.btnVendasMarcas);
            this.tabPage10.Controls.Add(this.label9);
            this.tabPage10.Controls.Add(this.dtpInicioVendasMarcas);
            this.tabPage10.Controls.Add(this.dtpFimVendasMarcas);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(760, 203);
            this.tabPage10.TabIndex = 4;
            this.tabPage10.Text = "Relatório de Vendas por marcas";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Depth = 0;
            this.btnFinanceiro.Location = new System.Drawing.Point(26, 133);
            this.btnFinanceiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Primary = true;
            this.btnFinanceiro.Size = new System.Drawing.Size(131, 36);
            this.btnFinanceiro.TabIndex = 108;
            this.btnFinanceiro.Text = "Relatorio";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 107;
            this.label4.Text = "Data Inicio";
            // 
            // dtpInicioFinanceiro
            // 
            this.dtpInicioFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.dtpInicioFinanceiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioFinanceiro.Location = new System.Drawing.Point(26, 43);
            this.dtpInicioFinanceiro.Name = "dtpInicioFinanceiro";
            this.dtpInicioFinanceiro.Size = new System.Drawing.Size(131, 30);
            this.dtpInicioFinanceiro.TabIndex = 105;
            // 
            // dtpFimFinanceiro
            // 
            this.dtpFimFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.dtpFimFinanceiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFimFinanceiro.Location = new System.Drawing.Point(174, 43);
            this.dtpFimFinanceiro.Name = "dtpFimFinanceiro";
            this.dtpFimFinanceiro.Size = new System.Drawing.Size(134, 30);
            this.dtpFimFinanceiro.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(169, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 109;
            this.label5.Text = "Data Final";
            // 
            // txtDataInicioFinanceiro
            // 
            this.txtDataInicioFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.txtDataInicioFinanceiro.Location = new System.Drawing.Point(26, 79);
            this.txtDataInicioFinanceiro.Mask = "0000-00-00";
            this.txtDataInicioFinanceiro.Name = "txtDataInicioFinanceiro";
            this.txtDataInicioFinanceiro.Size = new System.Drawing.Size(131, 30);
            this.txtDataInicioFinanceiro.TabIndex = 110;
            this.txtDataInicioFinanceiro.Visible = false;
            // 
            // txtDataFimFinanceiro
            // 
            this.txtDataFimFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.txtDataFimFinanceiro.Location = new System.Drawing.Point(174, 79);
            this.txtDataFimFinanceiro.Mask = "0000-00-00";
            this.txtDataFimFinanceiro.Name = "txtDataFimFinanceiro";
            this.txtDataFimFinanceiro.Size = new System.Drawing.Size(131, 30);
            this.txtDataFimFinanceiro.TabIndex = 111;
            this.txtDataFimFinanceiro.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(166, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 114;
            this.label6.Text = "Data Final";
            // 
            // btnCondicionais
            // 
            this.btnCondicionais.Depth = 0;
            this.btnCondicionais.Location = new System.Drawing.Point(23, 134);
            this.btnCondicionais.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCondicionais.Name = "btnCondicionais";
            this.btnCondicionais.Primary = true;
            this.btnCondicionais.Size = new System.Drawing.Size(131, 36);
            this.btnCondicionais.TabIndex = 113;
            this.btnCondicionais.Text = "Relatorio";
            this.btnCondicionais.UseVisualStyleBackColor = true;
            this.btnCondicionais.Click += new System.EventHandler(this.btnCondicionais_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 112;
            this.label7.Text = "Data Inicio";
            // 
            // dtpInicioCondicionais
            // 
            this.dtpInicioCondicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.dtpInicioCondicionais.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioCondicionais.Location = new System.Drawing.Point(23, 44);
            this.dtpInicioCondicionais.Name = "dtpInicioCondicionais";
            this.dtpInicioCondicionais.Size = new System.Drawing.Size(131, 30);
            this.dtpInicioCondicionais.TabIndex = 110;
            // 
            // dtpFimCondicionais
            // 
            this.dtpFimCondicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.dtpFimCondicionais.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFimCondicionais.Location = new System.Drawing.Point(171, 44);
            this.dtpFimCondicionais.Name = "dtpFimCondicionais";
            this.dtpFimCondicionais.Size = new System.Drawing.Size(134, 30);
            this.dtpFimCondicionais.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(167, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 119;
            this.label8.Text = "Data Final";
            // 
            // btnVendasMarcas
            // 
            this.btnVendasMarcas.Depth = 0;
            this.btnVendasMarcas.Location = new System.Drawing.Point(24, 133);
            this.btnVendasMarcas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVendasMarcas.Name = "btnVendasMarcas";
            this.btnVendasMarcas.Primary = true;
            this.btnVendasMarcas.Size = new System.Drawing.Size(131, 36);
            this.btnVendasMarcas.TabIndex = 118;
            this.btnVendasMarcas.Text = "Relatorio";
            this.btnVendasMarcas.UseVisualStyleBackColor = true;
            this.btnVendasMarcas.Click += new System.EventHandler(this.btnVendasMarcas_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 117;
            this.label9.Text = "Data Inicio";
            // 
            // dtpInicioVendasMarcas
            // 
            this.dtpInicioVendasMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.dtpInicioVendasMarcas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioVendasMarcas.Location = new System.Drawing.Point(24, 43);
            this.dtpInicioVendasMarcas.Name = "dtpInicioVendasMarcas";
            this.dtpInicioVendasMarcas.Size = new System.Drawing.Size(131, 30);
            this.dtpInicioVendasMarcas.TabIndex = 115;
            // 
            // dtpFimVendasMarcas
            // 
            this.dtpFimVendasMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.dtpFimVendasMarcas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFimVendasMarcas.Location = new System.Drawing.Point(172, 43);
            this.dtpFimVendasMarcas.Name = "dtpFimVendasMarcas";
            this.dtpFimVendasMarcas.Size = new System.Drawing.Size(134, 30);
            this.dtpFimVendasMarcas.TabIndex = 116;
            // 
            // frmCONRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCONRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios !";
            this.Load += new System.EventHandler(this.frmCONRelatorio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnRelatorioInventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.CheckBox cbRecorrente;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnInadimplentes;
        private System.Windows.Forms.TextBox txtDiasInad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinanceiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicioFinanceiro;
        private System.Windows.Forms.DateTimePicker dtpFimFinanceiro;
        private System.Windows.Forms.MaskedTextBox txtDataFimFinanceiro;
        private System.Windows.Forms.MaskedTextBox txtDataInicioFinanceiro;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton btnCondicionais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpInicioCondicionais;
        private System.Windows.Forms.DateTimePicker dtpFimCondicionais;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialRaisedButton btnVendasMarcas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpInicioVendasMarcas;
        private System.Windows.Forms.DateTimePicker dtpFimVendasMarcas;
    }
}