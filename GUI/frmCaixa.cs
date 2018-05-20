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
using System.Text.RegularExpressions;
using Modelo;
using System.Globalization;

namespace GUI
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
            BLLCaixa OBJBll = new BLLCaixa();
            dgvDividas.DataSource = OBJBll.listarDividas();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            BLLCaixa OBJBll = new BLLCaixa();
            Conta divida = new Conta();
            divida.Data = dtpData.Value;
            divida.Nome = txtNome.Text;
            divida.Valor = Decimal.Parse(txtValor.Text);
            if (cbRecorrente.Checked)
            {            
                divida.DataFinal = dtpDataFinal.Value;
                divida.Recorrente = "S";
            }
            if (OBJBll.Salvar(divida) == true)
            {
                MessageBox.Show("Conta salva com sucesso !");
                limparTextBoxes(this.Controls);
            }
                
            //msg salvo com sucesso
            else
                MessageBox.Show("Conta não foi salva !");
            //msg não foi salvo

            dgvDividas.DataSource = OBJBll.listarDividas();
            limparTextBoxes(this.Controls);

        }
        private void validarConteudoTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox || ctrl is MaskedTextBox)
                {
                    if (ctrl is TextBox)
                    {
                        if(((TextBox)(ctrl)).Text.Contains(""))
                        {
                            MessageBox.Show("Preencha todos os campos !");
                        }
                    }
                        
                    else
                        if(((MaskedTextBox)(ctrl)).Text.Contains(""))
                        {
                            MessageBox.Show("Preencha todos os campos !");
                        }
                }
            }
        }
        private void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox || ctrl is MaskedTextBox)
                {
                    if (ctrl is TextBox)
                        ((TextBox)(ctrl)).Text = String.Empty;
                    else
                        ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValor.Text, "[0-9]"))
            {
                txtValor.Text = string.Format("{0:#,###0.00}", double.Parse(txtValor.Text));
            }
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtValor.Text != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtValor.Text, "[0-9]") || txtValor.Text.Contains(",") || txtValor.Text.Contains("."))
                {
                    txtValor.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
                }
            }
            else
                txtValor.Text = "";
        }

        private void cbRecorrente_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbRecorrente.Checked)
                dtpDataFinal.Enabled = true;
            else
                dtpDataFinal.Enabled = false;
        }

        private void dgvDividas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvDividas.CurrentRow.Cells[0].Value;
            Conta divida = new Conta();
            BLLCaixa BLLObj = new BLLCaixa();
            divida = BLLObj.retornarDivida(id);
            txtNome.Text = divida.Nome;
            txtValor.Text = divida.Valor.ToString();
            dtpData.Text = divida.Data.ToString();
            if(divida.Recorrente == "S")
            {
                cbRecorrente.Checked = true;
                dtpDataFinal.Text = divida.DataFinal.ToString();
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = (int)dgvDividas.CurrentRow.Cells[0].Value;
            if (id != 0)
            {
                Conta divida = new Conta();
                BLLCaixa BLLObj = new BLLCaixa();
                divida = BLLObj.retornarDivida(id);
                divida.Nome = txtNome.Text;
                divida.Valor = decimal.Parse(txtValor.Text);
                divida.Data = dtpData.Value;
                if (cbRecorrente.Checked)
                {
                    divida.DataFinal = dtpDataFinal.Value;
                    divida.Recorrente = "S";
                }
                else
                {
                    divida.Recorrente = "N";
                    divida.DataFinal = null;
                }
                BLLObj.AlterarConta(divida);
                dgvDividas.DataSource = BLLObj.listarDividas();
                limparTextBoxes(this.Controls);
            }
            else
                MessageBox.Show("Selecione uma conta antes !");
        }
    }
}
