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
    public partial class frmPrincipal : MaterialForm
    {
        public List<UsuarioPermissoes> listp;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCADCategoria frmCAD = new frmCADCategoria();
            frmCAD.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCADProduto frmCAD = new frmCADProduto();
            frmCAD.Show();                          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCADProduto frmCAD = new frmCADProduto();
            frmCAD.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmCADVenda frmCAD = new frmCADVenda();
            frmCAD.Show();
        }

        private void btnConsultaProd_Click(object sender, EventArgs e)
        {
            frmCONProduto frmCON = new frmCONProduto();
            frmCON.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCADPessoa frmCAD = new frmCADPessoa();
            frmCAD.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa frmCAD = new frmCaixa();
            frmCAD.Show();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento frmCAD = new frmPagamento();
            frmCAD.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmCADUsuario frmCAD = new frmCADUsuario();
            frmCAD.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmCONRelatorio frmCAD = new frmCONRelatorio();
            frmCAD.Show();
        }
        private void desativarBotoes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button)
                {
                    ((Button)(ctrl)).Enabled = false;
                }
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            desativarBotoes(this.Controls);
            foreach (UsuarioPermissoes usu in listp)
            {
                if (usu.idPermissao == 1)
                {
                    btnCADProduto.Enabled = true;
                }
                if (usu.idPermissao == 2)
                {
                    btnCADPessoa.Enabled = true;
                }
                if (usu.idPermissao == 3)
                {
                    btnCaixa.Enabled = true;
                }
                if (usu.idPermissao == 4)
                {
                    btnVenda.Enabled = true;
                }
                if (usu.idPermissao == 5)
                {
                    btnCONProduto.Enabled = true;
                }
                if (usu.idPermissao == 6)
                {
                    btnPagamento.Enabled = true;
                }
                if (usu.idPermissao == 7)
                {
                    btnUsuario.Enabled = true;
                }
            }
        }
    }
}
