namespace GUI
{
    partial class frmCADCategoria
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluirModelo = new System.Windows.Forms.Button();
            this.txtNomeModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarModelo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvarMarca = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExcluirTamanho = new System.Windows.Forms.Button();
            this.txtNomeTamanho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvaTamanho = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTamanho = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnExcluirCor = new System.Windows.Forms.Button();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvarCor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(11, 85);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 39);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(11, 49);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 30);
            this.txtDescricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(467, 255);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExcluirCategoria);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbCategoria);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categoria";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Location = new System.Drawing.Point(169, 88);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(94, 36);
            this.btnExcluirCategoria.TabIndex = 3;
            this.btnExcluirCategoria.Text = "Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = true;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cadastrados";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(117, 49);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(146, 33);
            this.cbCategoria.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluirModelo);
            this.tabPage2.Controls.Add(this.txtNomeModelo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnSalvarModelo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbModelo);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluirModelo
            // 
            this.btnExcluirModelo.Location = new System.Drawing.Point(163, 94);
            this.btnExcluirModelo.Name = "btnExcluirModelo";
            this.btnExcluirModelo.Size = new System.Drawing.Size(87, 31);
            this.btnExcluirModelo.TabIndex = 3;
            this.btnExcluirModelo.Text = "Excluir";
            this.btnExcluirModelo.UseVisualStyleBackColor = true;
            this.btnExcluirModelo.Click += new System.EventHandler(this.btnExcluirModelo_Click);
            // 
            // txtNomeModelo
            // 
            this.txtNomeModelo.Location = new System.Drawing.Point(11, 57);
            this.txtNomeModelo.Name = "txtNomeModelo";
            this.txtNomeModelo.Size = new System.Drawing.Size(100, 30);
            this.txtNomeModelo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Cadastrados";
            // 
            // btnSalvarModelo
            // 
            this.btnSalvarModelo.Location = new System.Drawing.Point(11, 93);
            this.btnSalvarModelo.Name = "btnSalvarModelo";
            this.btnSalvarModelo.Size = new System.Drawing.Size(87, 31);
            this.btnSalvarModelo.TabIndex = 2;
            this.btnSalvarModelo.Text = "Salvar";
            this.btnSalvarModelo.UseVisualStyleBackColor = true;
            this.btnSalvarModelo.Click += new System.EventHandler(this.btnSalvarModelo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nome";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(117, 57);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(151, 33);
            this.cbModelo.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnExcluirMarca);
            this.tabPage3.Controls.Add(this.txtNomeMarca);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnSalvarMarca);
            this.tabPage3.Controls.Add(this.cbMarca);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(436, 208);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Marca";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.Location = new System.Drawing.Point(163, 103);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(100, 38);
            this.btnExcluirMarca.TabIndex = 3;
            this.btnExcluirMarca.Text = "Excluir";
            this.btnExcluirMarca.UseVisualStyleBackColor = true;
            this.btnExcluirMarca.Click += new System.EventHandler(this.btnExcluirMarca_Click);
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Location = new System.Drawing.Point(11, 67);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(100, 30);
            this.txtNomeMarca.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 87;
            this.label7.Text = "Cadastrados";
            // 
            // btnSalvarMarca
            // 
            this.btnSalvarMarca.Location = new System.Drawing.Point(11, 103);
            this.btnSalvarMarca.Name = "btnSalvarMarca";
            this.btnSalvarMarca.Size = new System.Drawing.Size(100, 38);
            this.btnSalvarMarca.TabIndex = 2;
            this.btnSalvarMarca.Text = "Salvar";
            this.btnSalvarMarca.UseVisualStyleBackColor = true;
            this.btnSalvarMarca.Click += new System.EventHandler(this.btnSalvarMarca_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(117, 67);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 33);
            this.cbMarca.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 84;
            this.label6.Text = "Nome";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnExcluirTamanho);
            this.tabPage4.Controls.Add(this.txtNomeTamanho);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnSalvaTamanho);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.cbTamanho);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(436, 208);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tamanho";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExcluirTamanho
            // 
            this.btnExcluirTamanho.Location = new System.Drawing.Point(163, 100);
            this.btnExcluirTamanho.Name = "btnExcluirTamanho";
            this.btnExcluirTamanho.Size = new System.Drawing.Size(98, 41);
            this.btnExcluirTamanho.TabIndex = 3;
            this.btnExcluirTamanho.Text = "Excluir";
            this.btnExcluirTamanho.UseVisualStyleBackColor = true;
            this.btnExcluirTamanho.Click += new System.EventHandler(this.btnExcluirTamanho_Click);
            // 
            // txtNomeTamanho
            // 
            this.txtNomeTamanho.Location = new System.Drawing.Point(11, 64);
            this.txtNomeTamanho.Name = "txtNomeTamanho";
            this.txtNomeTamanho.Size = new System.Drawing.Size(100, 30);
            this.txtNomeTamanho.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 88;
            this.label8.Text = "Cadastrados";
            // 
            // btnSalvaTamanho
            // 
            this.btnSalvaTamanho.Location = new System.Drawing.Point(11, 100);
            this.btnSalvaTamanho.Name = "btnSalvaTamanho";
            this.btnSalvaTamanho.Size = new System.Drawing.Size(98, 41);
            this.btnSalvaTamanho.TabIndex = 2;
            this.btnSalvaTamanho.Text = "Salvar";
            this.btnSalvaTamanho.UseVisualStyleBackColor = true;
            this.btnSalvaTamanho.Click += new System.EventHandler(this.btnSalvaTamanho_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 86;
            this.label3.Text = "Nome";
            // 
            // cbTamanho
            // 
            this.cbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamanho.FormattingEnabled = true;
            this.cbTamanho.Location = new System.Drawing.Point(117, 63);
            this.cbTamanho.Name = "cbTamanho";
            this.cbTamanho.Size = new System.Drawing.Size(121, 33);
            this.cbTamanho.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnExcluirCor);
            this.tabPage5.Controls.Add(this.txtCor);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.btnSalvarCor);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.cbCor);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(459, 217);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Cor";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCor
            // 
            this.btnExcluirCor.Location = new System.Drawing.Point(163, 101);
            this.btnExcluirCor.Name = "btnExcluirCor";
            this.btnExcluirCor.Size = new System.Drawing.Size(98, 32);
            this.btnExcluirCor.TabIndex = 3;
            this.btnExcluirCor.Text = "Excluir";
            this.btnExcluirCor.UseVisualStyleBackColor = true;
            this.btnExcluirCor.Click += new System.EventHandler(this.btnExcluirCor_Click);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(11, 65);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 30);
            this.txtCor.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 93;
            this.label9.Text = "Cadastrados";
            // 
            // btnSalvarCor
            // 
            this.btnSalvarCor.Location = new System.Drawing.Point(11, 101);
            this.btnSalvarCor.Name = "btnSalvarCor";
            this.btnSalvarCor.Size = new System.Drawing.Size(98, 32);
            this.btnSalvarCor.TabIndex = 2;
            this.btnSalvarCor.Text = "Salvar";
            this.btnSalvarCor.UseVisualStyleBackColor = true;
            this.btnSalvarCor.Click += new System.EventHandler(this.btnSalvarCor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "Nome";
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(117, 64);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(121, 33);
            this.cbCor.TabIndex = 1;
            // 
            // frmCADCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 281);
            this.Controls.Add(this.tabControl);
            this.Name = "frmCADCategoria";
            this.Text = "Cadastro";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSalvarMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvarModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvaTamanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtNomeModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeTamanho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalvarCor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.Button btnExcluirModelo;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.Button btnExcluirTamanho;
        private System.Windows.Forms.Button btnExcluirCor;
    }
}