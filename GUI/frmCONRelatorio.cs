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
using BLL;

namespace GUI
{
    public partial class frmCONRelatorio : MaterialForm
    {
        string usuario = "sa";
        string senha = "123456";
        public frmCONRelatorio()
        {
            InitializeComponent();
        }

        private void frmCONRelatorio_Load(object sender, EventArgs e)
        {
            string descricao = "";
            //cbCategoria.DataSource = objCBCategoriaB.selecionarcategoria(descricao);
            cbCategoria.DataSource = BLLProduto.selecionarcategoria(descricao);
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "descricao";
        }

        private void btnRelatorioInventario_Click(object sender, EventArgs e)
        {
            DAL.Relatorios.RelatorioInventario rpt = new DAL.Relatorios.RelatorioInventario();
            //rpt.SetDatabaseLogon(usuario, senha);
            rpt.SetParameterValue(0, cbCategoria.SelectedValue);
            frmRelatorio rel = new frmRelatorio();
            rel.crystalReportViewer1.ReportSource = rpt;
            rel.ShowDialog();
            rel = null;
            rpt = null;
        }
    }
}
