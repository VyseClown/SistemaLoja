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
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DALLogin login = new DALLogin();
            List<UsuarioPermissoes> up = new List<UsuarioPermissoes>();
            bool ativado = false;
            if((up = login.logarNoSistema(txtLogin.Text, txtSenha.Text)) != null && up.Count != 0)
            {
                //UsuarioPermissoes updesativado = new UsuarioPermissoes();
                foreach(UsuarioPermissoes updesativado in up)
                {
                    if (updesativado.idPermissao == 8)
                    {
                        MessageBox.Show("Usuario está desativado !");
                        ativado = false;
                        break;
                    }
                    else
                        ativado = true;
                }
                if (ativado == true) { 
                frmPrincipal frmCAD = new frmPrincipal();
                    frmCAD.listp = up;
                frmCAD.Show();
                this.Hide();
                }
                else
                {
                    //MessageBox.Show("Usuario foi desativado !");
                }
            }
            else
            {
                MessageBox.Show("Se esqueceu da senha ?");
            }
        }
    }
}
