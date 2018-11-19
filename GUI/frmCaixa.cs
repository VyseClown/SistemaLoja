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
using MaterialSkin.Controls;

namespace GUI
{
    public partial class frmCaixa : MaterialForm
    {
        public frmCaixa()
        {
            InitializeComponent();
            BLLCaixa OBJBll = new BLLCaixa();
            dgvDividas.DataSource = OBJBll.listarDividas();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtValor.Text != "")
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
            else
                MessageBox.Show("Informe um nome e um valor!");

        }
        private bool validarConteudoTextBoxes(Control.ControlCollection controles)
        {
            int cont = 0;
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
                            cont++;
                        }
                    }
                        
                    else
                        if(((MaskedTextBox)(ctrl)).Text.Contains(""))
                        {
                            MessageBox.Show("Preencha todos os campos !");
                        cont++;
                        }
                }
            }
            if (cont == 0)
                return true;
            else
                return false;
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
            if (id != 0 && txtNome.Text != "" && txtValor.Text != "")
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = (int)dgvDividas.CurrentRow.Cells[0].Value;
            if (id != 0 && txtNome.Text != "" && txtValor.Text != "")
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
                BLLObj.Excluir(divida);
                dgvDividas.DataSource = BLLObj.listarDividas();
                limparTextBoxes(this.Controls);
            }
            else
                MessageBox.Show("Selecione uma conta antes !");
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            DALCaixa objDAL = new DALCaixa();
            txtCaixa.Text = (objDAL.somarBalanco(DateTime.Parse(dtpInicio.Text), DateTime.Parse(dtpFim.Text))).ToString();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValorAbertura.Text, "^[0-9]{1,4}([,.][0-9]{1,2})?$"))
            {
                DALCaixa objDAL = new DALCaixa();
                FluxoCaixa caixa = new FluxoCaixa();
                caixa.ValorAbertura = decimal.Parse(txtValorAbertura.Text);
                caixa.DataAbertura = DateTime.Now;
                objDAL.AbrirCaixa(caixa);

                tabControl1.TabPages.Remove(tabPage3);
                if(!tabPage4.IsAccessible)
                    tabControl1.TabPages.Add(tabPage4);
                limparTextBoxes(this.Controls);
            }
            else
                MessageBox.Show("Informe algum valor !");
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            DALCaixa objDAL = new DALCaixa();
            FluxoCaixa caixa = new FluxoCaixa();
            tabControl1.TabPages.Remove(tabPage2);//se tornou inutil, o controle já é feito por contador e repassado mensalmente
            if ((caixa = objDAL.verificarAberturaCaixa()) != null)
            {
                //tabControl1.TabPages.Add(tabPage3);
                tabControl1.TabPages.Remove(tabPage3);
            }else
            {
                tabControl1.TabPages.Remove(tabPage4);
            }
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValorFechamento.Text, "^[0-9]{1,4}([,.][0-9]{1,2})?$"))
            {
                DALCaixa objDAL = new DALCaixa();
                FluxoCaixa caixa = new FluxoCaixa();
                
                caixa.DataFechamento = DateTime.Now;
                if ((caixa = objDAL.verificarFechamento(caixa)) == null)
                {
                    MessageBox.Show("O fechamento não foi feito no dia certo,terá que ser aberto um novo caixa !");
                    //caixa.Fluxo = null;
                    //objDAL.FecharCaixa(caixa);
                }
                else
                {
                    if (caixa.ValorFechamento == null)
                    {
                        caixa.ValorFechamento = decimal.Parse(txtValorFechamento.Text);
                        objDAL.FecharCaixa(caixa);
                    }
                    else
                        MessageBox.Show("Fechamento de caixa do dia já efetuado !");
                }

                tabControl1.TabPages.Remove(tabPage4);
                //tabControl1.TabPages.Add(tabPage3);
                limparTextBoxes(this.Controls);
            }
            else
                MessageBox.Show("Informe algum valor !");
        }

        private void txtValorAbertura_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtValorAbertura.Text != null)
           // {
             //   if (!System.Text.RegularExpressions.Regex.IsMatch(txtValorAbertura.Text, "[0-9]") || txtValorAbertura.Text.Contains(",") || txtValorAbertura.Text.Contains("."))
               // {
                 //   txtValorAbertura.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
       //         }
         //   }
           // else
             //   txtValorAbertura.Text = "";
        }

        private void txtValorFechamento_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtValorFechamento.Text != null)
            //{
              //  if (!System.Text.RegularExpressions.Regex.IsMatch(txtValorFechamento.Text, "[0-9]") || txtValorFechamento.Text.Contains(",") || txtValorFechamento.Text.Contains("."))
                //{
                  //  txtValorFechamento.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
                //}
           // }
            //else
              //  txtValorFechamento.Text = "";
        }

        private void txtValorFechamento_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValorFechamento.Text, "[0-9]"))
            {
               // txtValorFechamento.Text = string.Format("{0:#,###0.00}", double.Parse(txtValorFechamento.Text));
            }
        }

        private void txtValorAbertura_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValorAbertura.Text, "[0-9]"))
            {
              //  txtValorAbertura.Text = string.Format("{0:#,###0.00}", double.Parse(txtValorAbertura.Text));
            }
        }
    }
}
