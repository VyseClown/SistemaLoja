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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNomeModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarModelo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvarMarca = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtNomeTamanho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvaTamanho = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTamanho = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvarCor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 63);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(9, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 237);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbCategoria);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categoria";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cadastrados";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(115, 37);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtNomeModelo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnSalvarModelo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbModelo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNomeModelo
            // 
            this.txtNomeModelo.Location = new System.Drawing.Point(9, 39);
            this.txtNomeModelo.Name = "txtNomeModelo";
            this.txtNomeModelo.Size = new System.Drawing.Size(100, 20);
            this.txtNomeModelo.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Cadastrados";
            // 
            // btnSalvarModelo
            // 
            this.btnSalvarModelo.Location = new System.Drawing.Point(9, 65);
            this.btnSalvarModelo.Name = "btnSalvarModelo";
            this.btnSalvarModelo.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarModelo.TabIndex = 88;
            this.btnSalvarModelo.Text = "Salvar";
            this.btnSalvarModelo.UseVisualStyleBackColor = true;
            this.btnSalvarModelo.Click += new System.EventHandler(this.btnSalvarModelo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nome";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(115, 39);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(121, 21);
            this.cbModelo.TabIndex = 22;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtNomeMarca);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnSalvarMarca);
            this.tabPage3.Controls.Add(this.cbMarca);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(252, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Marca";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Location = new System.Drawing.Point(9, 42);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(100, 20);
            this.txtNomeMarca.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Cadastrados";
            // 
            // btnSalvarMarca
            // 
            this.btnSalvarMarca.Location = new System.Drawing.Point(9, 68);
            this.btnSalvarMarca.Name = "btnSalvarMarca";
            this.btnSalvarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMarca.TabIndex = 86;
            this.btnSalvarMarca.Text = "Salvar";
            this.btnSalvarMarca.UseVisualStyleBackColor = true;
            this.btnSalvarMarca.Click += new System.EventHandler(this.btnSalvarMarca_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(115, 42);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Nome";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtNomeTamanho);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnSalvaTamanho);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.cbTamanho);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(252, 211);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tamanho";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtNomeTamanho
            // 
            this.txtNomeTamanho.Location = new System.Drawing.Point(9, 43);
            this.txtNomeTamanho.Name = "txtNomeTamanho";
            this.txtNomeTamanho.Size = new System.Drawing.Size(100, 20);
            this.txtNomeTamanho.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Cadastrados";
            // 
            // btnSalvaTamanho
            // 
            this.btnSalvaTamanho.Location = new System.Drawing.Point(9, 69);
            this.btnSalvaTamanho.Name = "btnSalvaTamanho";
            this.btnSalvaTamanho.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaTamanho.TabIndex = 87;
            this.btnSalvaTamanho.Text = "Salvar";
            this.btnSalvaTamanho.UseVisualStyleBackColor = true;
            this.btnSalvaTamanho.Click += new System.EventHandler(this.btnSalvaTamanho_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Nome";
            // 
            // cbTamanho
            // 
            this.cbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamanho.FormattingEnabled = true;
            this.cbTamanho.Location = new System.Drawing.Point(115, 42);
            this.cbTamanho.Name = "cbTamanho";
            this.cbTamanho.Size = new System.Drawing.Size(121, 21);
            this.cbTamanho.TabIndex = 85;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtCor);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.btnSalvarCor);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.cbCor);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(252, 211);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Cor";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(9, 44);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Cadastrados";
            // 
            // btnSalvarCor
            // 
            this.btnSalvarCor.Location = new System.Drawing.Point(9, 70);
            this.btnSalvarCor.Name = "btnSalvarCor";
            this.btnSalvarCor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCor.TabIndex = 92;
            this.btnSalvarCor.Text = "Salvar";
            this.btnSalvarCor.UseVisualStyleBackColor = true;
            this.btnSalvarCor.Click += new System.EventHandler(this.btnSalvarCor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 91;
            this.label10.Text = "Nome";
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(115, 43);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(121, 21);
            this.cbCor.TabIndex = 90;
            // 
            // frmCADCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCADCategoria";
            this.Text = "Cadastro";
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
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
    }
}