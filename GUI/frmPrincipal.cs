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

namespace GUI
{
    public partial class frmPrincipal : MaterialForm
    {
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
    }
}
