using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmCADUsuario : MaterialForm
    {
        int idUsuario = 0;
        public frmCADUsuario()
        {
            InitializeComponent();
        }
        private void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                if(ctrl is CheckBox)
                {
                    ((CheckBox)(ctrl)).Checked = false;
                }
            }
        }
        private List<UsuarioPermissoes> verificarPermissoes(Control.ControlCollection controles)
        {
            List<UsuarioPermissoes> listp = new List<UsuarioPermissoes>();
            UsuarioPermissoes usup = new UsuarioPermissoes();
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is CheckBox)
                {
                    //((TextBox)(ctrl)).Text = String.Empty;
                    if (((CheckBox)(ctrl)).Checked)
                    {
                        if(((CheckBox)(ctrl)).Name == "cbProduto")
                        {
                            usup.idPermissao = 1;
                            listp.Add(usup);
                        }
                        if (((CheckBox)(ctrl)).Name == "cbPessoa")
                        {
                            usup.idPermissao = 2;
                            listp.Add(usup);
                        }
                        if (((CheckBox)(ctrl)).Name == "cbCaixa")
                        {
                            usup.idPermissao = 3;
                            listp.Add(usup);
                        }
                        if (((CheckBox)(ctrl)).Name == "cbVenda")
                        {
                            usup.idPermissao = 4;
                            listp.Add(usup);
                        }
                        if (((CheckBox)(ctrl)).Name == "cbConsultaProd")
                        {
                            usup.idPermissao = 5;
                            listp.Add(usup);
                        }
                        if (((CheckBox)(ctrl)).Name == "cbPagamento")
                        {
                            usup.idPermissao = 6;
                            listp.Add(usup);
                        }
                        if (((CheckBox)(ctrl)).Name == "cbUsuario")
                        {
                            usup.idPermissao = 7;
                            listp.Add(usup);
                        }
                        if (((CheckBox)(ctrl)).Name == "cbDesativado")
                        {
                            usup.idPermissao = 8;
                            listp.Add(usup);
                        }
                        if (((CheckBox)(ctrl)).Name == "cbRelatorio")
                        {
                            usup.idPermissao = 9;
                            listp.Add(usup);
                        }
                    }
                }
            }
            return listp;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != null && txtLogin.Text != "" && txtSenha.Text != null && txtSenha.Text != "")
            {
                List<UsuarioPermissoes> lisu = new List<UsuarioPermissoes>();
                if (DALLogin.verificarExistencia(txtLogin.Text) == false)
                {
                    lisu = verificarPermissoes(this.Controls);
                    Usuario usu = new Usuario();
                    usu.login = txtLogin.Text;
                    usu.senha = txtSenha.Text;
                    DALLogin objDAL = new DALLogin();
                    objDAL.Salvar(usu,lisu);
                    limparTextBoxes(this.Controls);
                }
                else
                    MessageBox.Show("Login e senha já existem !");
            }
            else
                MessageBox.Show("Digite digite todos os campos !");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idUsuario != 0)
            {
                List<UsuarioPermissoes> list = verificarPermissoes(this.Controls);

                //escrever o modificar aqui com as permissões
            }
            else
                MessageBox.Show("Localize um usuario antes !");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALLogin objDAL = new DALLogin();
            Usuario log = objDAL.retornarUsuario(txtLogin.Text);
            if(log != null) { 
                txtSenha.Text = log.senha;
                idUsuario = log.id;
                List<UsuarioPermissoes> per = objDAL.logarNoSistema(log.login, log.senha);
                foreach (UsuarioPermissoes usu in per)
                {
                    if(usu.idPermissao == 1)
                    {
                        cbProduto.Checked = true;
                    }
                    if (usu.idPermissao == 2)
                    {
                        cbPessoa.Checked = true;
                    }
                    if (usu.idPermissao == 3)
                    {
                        cbCaixa.Checked = true;
                    }
                    if (usu.idPermissao == 4)
                    {
                        cbVenda.Checked = true;
                    }
                    if (usu.idPermissao == 5)
                    {
                        cbConsultaProd.Checked = true;
                    }
                    if (usu.idPermissao == 6)
                    {
                        cbPagamentos.Checked = true;
                    }
                    if (usu.idPermissao == 7)
                    {
                        cbUsuario.Checked = true;
                    }
                    if (usu.idPermissao == 8)
                    {
                        cbDesativado.Checked = true;
                    }
                }
                //atribuir as permissões
            }
        }
    }
}
