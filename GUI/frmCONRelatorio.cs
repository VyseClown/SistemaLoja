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

        private void btnInadimplentes_Click(object sender, EventArgs e)
        {
            DAL.Relatorios.RelatorioInadimplentes rpt = new DAL.Relatorios.RelatorioInadimplentes();
            //rpt.SetDatabaseLogon(usuario, senha);
            rpt.SetParameterValue(0, int.Parse(txtDiasInad.Text));
            frmRelatorio rel = new frmRelatorio();
            rel.crystalReportViewer1.ReportSource = rpt;
            rel.ShowDialog();
            rel = null;
            rpt = null;
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            DAL.Relatorios.RelatorioFinanceiro rpt = new DAL.Relatorios.RelatorioFinanceiro();
            //rpt.SetDatabaseLogon(usuario, senha);
            //rpt.SetParameterValue(0, txtDataInicioFinanceiro.Text);
            //rpt.SetParameterValue(1, txtDataFimFinanceiro.Text);
            rpt.SetParameterValue(0, dtpInicioFinanceiro.Text);
            rpt.SetParameterValue(1, dtpFimFinanceiro.Text);

            frmRelatorio rel = new frmRelatorio();
            rel.crystalReportViewer1.ReportSource = rpt;
            rel.ShowDialog();
            rel = null;
            rpt = null;
        }

        private void btnCondicionais_Click(object sender, EventArgs e)
        {
            DAL.Relatorios.RelatorioClienteCondicional rpt = new DAL.Relatorios.RelatorioClienteCondicional();
            //rpt.SetDatabaseLogon(usuario, senha);
            //rpt.SetParameterValue(0, txtDataInicioFinanceiro.Text);
            //rpt.SetParameterValue(1, txtDataFimFinanceiro.Text);
            rpt.SetParameterValue(0, dtpInicioCondicionais.Text);
            rpt.SetParameterValue(1, dtpFimCondicionais.Text);

            frmRelatorio rel = new frmRelatorio();
            rel.crystalReportViewer1.ReportSource = rpt;
            rel.ShowDialog();
            rel = null;
            rpt = null;
        }

        private void btnVendasMarcas_Click(object sender, EventArgs e)
        {
            DAL.Relatorios.RelatorioVendaMarca rpt = new DAL.Relatorios.RelatorioVendaMarca();
            //rpt.SetDatabaseLogon(usuario, senha);
            //rpt.SetParameterValue(0, txtDataInicioFinanceiro.Text);
            //rpt.SetParameterValue(1, txtDataFimFinanceiro.Text);
            rpt.SetParameterValue(0, dtpInicioVendasMarcas.Text);
            rpt.SetParameterValue(1, dtpFimVendasMarcas.Text);

            frmRelatorio rel = new frmRelatorio();
            rel.crystalReportViewer1.ReportSource = rpt;
            rel.ShowDialog();
            rel = null;
            rpt = null;
        }
    }
}
