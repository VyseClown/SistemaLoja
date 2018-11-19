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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDescricao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNomeModelo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNomeMarca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtNomeTamanho = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTamanho = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtCor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton10 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label9 = new System.Windows.Forms.Label();
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
            this.tabControl.Location = new System.Drawing.Point(38, 116);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(498, 293);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialRaisedButton2);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbCategoria);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categoria";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(159, 101);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Excluir";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(11, 101);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Salvar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Hint = "";
            this.txtDescricao.Location = new System.Drawing.Point(11, 49);
            this.txtDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.Size = new System.Drawing.Size(142, 23);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cadastrados";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(181, 49);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(227, 33);
            this.cbCategoria.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtNomeModelo);
            this.tabPage2.Controls.Add(this.materialRaisedButton3);
            this.tabPage2.Controls.Add(this.materialRaisedButton4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbModelo);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelo";
            // 
            // txtNomeModelo
            // 
            this.txtNomeModelo.Depth = 0;
            this.txtNomeModelo.Hint = "";
            this.txtNomeModelo.Location = new System.Drawing.Point(11, 48);
            this.txtNomeModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeModelo.Name = "txtNomeModelo";
            this.txtNomeModelo.PasswordChar = '\0';
            this.txtNomeModelo.SelectedText = "";
            this.txtNomeModelo.SelectionLength = 0;
            this.txtNomeModelo.SelectionStart = 0;
            this.txtNomeModelo.Size = new System.Drawing.Size(142, 23);
            this.txtNomeModelo.TabIndex = 0;
            this.txtNomeModelo.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(159, 109);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton3.TabIndex = 3;
            this.materialRaisedButton3.Text = "Excluir";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.btnExcluirModelo_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(11, 109);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton4.TabIndex = 2;
            this.materialRaisedButton4.Text = "Salvar";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.btnSalvarModelo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Cadastrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nome";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(159, 48);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(227, 33);
            this.cbModelo.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.txtNomeMarca);
            this.tabPage3.Controls.Add(this.materialRaisedButton5);
            this.tabPage3.Controls.Add(this.materialRaisedButton6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cbMarca);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(490, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Marca";
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Depth = 0;
            this.txtNomeMarca.Hint = "";
            this.txtNomeMarca.Location = new System.Drawing.Point(11, 51);
            this.txtNomeMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.PasswordChar = '\0';
            this.txtNomeMarca.SelectedText = "";
            this.txtNomeMarca.SelectionLength = 0;
            this.txtNomeMarca.SelectionStart = 0;
            this.txtNomeMarca.Size = new System.Drawing.Size(142, 23);
            this.txtNomeMarca.TabIndex = 0;
            this.txtNomeMarca.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(159, 124);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton5.TabIndex = 3;
            this.materialRaisedButton5.Text = "Excluir";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.btnExcluirMarca_Click);
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Location = new System.Drawing.Point(11, 124);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton6.TabIndex = 2;
            this.materialRaisedButton6.Text = "Salvar";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.btnSalvarMarca_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 87;
            this.label7.Text = "Cadastrados";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(159, 51);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(227, 33);
            this.cbMarca.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 84;
            this.label6.Text = "Nome";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.txtNomeTamanho);
            this.tabPage4.Controls.Add(this.materialRaisedButton7);
            this.tabPage4.Controls.Add(this.materialRaisedButton8);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.cbTamanho);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(490, 255);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tamanho";
            // 
            // txtNomeTamanho
            // 
            this.txtNomeTamanho.Depth = 0;
            this.txtNomeTamanho.Hint = "";
            this.txtNomeTamanho.Location = new System.Drawing.Point(11, 52);
            this.txtNomeTamanho.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeTamanho.Name = "txtNomeTamanho";
            this.txtNomeTamanho.PasswordChar = '\0';
            this.txtNomeTamanho.SelectedText = "";
            this.txtNomeTamanho.SelectionLength = 0;
            this.txtNomeTamanho.SelectionStart = 0;
            this.txtNomeTamanho.Size = new System.Drawing.Size(142, 23);
            this.txtNomeTamanho.TabIndex = 0;
            this.txtNomeTamanho.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Location = new System.Drawing.Point(159, 109);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton7.TabIndex = 3;
            this.materialRaisedButton7.Text = "Excluir";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.btnExcluirTamanho_Click);
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Location = new System.Drawing.Point(11, 109);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton8.TabIndex = 2;
            this.materialRaisedButton8.Text = "Salvar";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            this.materialRaisedButton8.Click += new System.EventHandler(this.btnSalvaTamanho_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 88;
            this.label8.Text = "Cadastrados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 86;
            this.label3.Text = "Nome";
            // 
            // cbTamanho
            // 
            this.cbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamanho.FormattingEnabled = true;
            this.cbTamanho.Location = new System.Drawing.Point(159, 52);
            this.cbTamanho.Name = "cbTamanho";
            this.cbTamanho.Size = new System.Drawing.Size(227, 33);
            this.cbTamanho.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.txtCor);
            this.tabPage5.Controls.Add(this.materialRaisedButton9);
            this.tabPage5.Controls.Add(this.materialRaisedButton10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.cbCor);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(490, 255);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Cor";
            // 
            // txtCor
            // 
            this.txtCor.Depth = 0;
            this.txtCor.Hint = "";
            this.txtCor.Location = new System.Drawing.Point(11, 46);
            this.txtCor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCor.Name = "txtCor";
            this.txtCor.PasswordChar = '\0';
            this.txtCor.SelectedText = "";
            this.txtCor.SelectionLength = 0;
            this.txtCor.SelectionStart = 0;
            this.txtCor.Size = new System.Drawing.Size(142, 23);
            this.txtCor.TabIndex = 0;
            this.txtCor.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton9
            // 
            this.materialRaisedButton9.Depth = 0;
            this.materialRaisedButton9.Location = new System.Drawing.Point(159, 97);
            this.materialRaisedButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton9.Name = "materialRaisedButton9";
            this.materialRaisedButton9.Primary = true;
            this.materialRaisedButton9.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton9.TabIndex = 3;
            this.materialRaisedButton9.Text = "Excluir";
            this.materialRaisedButton9.UseVisualStyleBackColor = true;
            this.materialRaisedButton9.Click += new System.EventHandler(this.btnExcluirCor_Click);
            // 
            // materialRaisedButton10
            // 
            this.materialRaisedButton10.Depth = 0;
            this.materialRaisedButton10.Location = new System.Drawing.Point(11, 97);
            this.materialRaisedButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton10.Name = "materialRaisedButton10";
            this.materialRaisedButton10.Primary = true;
            this.materialRaisedButton10.Size = new System.Drawing.Size(142, 37);
            this.materialRaisedButton10.TabIndex = 2;
            this.materialRaisedButton10.Text = "Salvar";
            this.materialRaisedButton10.UseVisualStyleBackColor = true;
            this.materialRaisedButton10.Click += new System.EventHandler(this.btnSalvarCor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 93;
            this.label9.Text = "Cadastrados";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "Nome";
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(159, 46);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(227, 33);
            this.cbCor.TabIndex = 1;
            // 
            // frmCADCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 461);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "frmCADCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCor;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescricao;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton9;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeModelo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeMarca;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeTamanho;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCor;
    }
}