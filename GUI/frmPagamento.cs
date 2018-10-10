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
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtPagamento.Text != "" && txtPagamento.Text != "0") { 
            Cliente cli = new Cliente();
            DALPessoa dalpes = new DALPessoa();
            //cli = (dalpes.retornarCliente((int)cbCliente.SelectedValue));
            
            
            int idVenda = (int)dgvVenda.CurrentRow.Cells[0].Value;
            int idCliente = (int)dgvVenda.CurrentRow.Cells[1].Value;
            decimal valorRestante = (decimal)dgvVenda.CurrentRow.Cells[4].Value;
            decimal valorPago = decimal.Parse(txtPagamento.Text);
                decimal resto = valorRestante - valorPago;
                if (resto < 0)
                    resto = resto * -1;
                DialogResult dialogResult = MessageBox.Show("Quer usar o valor para pagar mais de uma conta ?", "Decisão", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool pagamento1 = (new DALVenda().RealizarPagamento(idVenda, idCliente, valorRestante, valorPago));

                    if (pagamento1)
                    {
                        MessageBox.Show("Pagamento realizado com sucesso !");
                        cbCliente_SelectionChangeCommitted(sender,e);
                    }
                    else
                    {
                        MessageBox.Show("Pagamento não foi realizado !");
                        cbCliente_SelectionChangeCommitted(sender, e);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    bool pagamento = (new DALVenda().RealizarPagamentoComTroco(idVenda, idCliente, valorRestante, valorPago));

                    if (pagamento)
                    {
                        MessageBox.Show("Pagamento realizado com sucesso ! O troco é R$ " + resto);
                        cbCliente_SelectionChangeCommitted(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Pagamento não foi realizado !");
                        cbCliente_SelectionChangeCommitted(sender, e);
                    }
                }
                
            }
        }

        private void cbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            DALPessoa dalpes = new DALPessoa();
            cli = (dalpes.retornarCliente((int)cbCliente.SelectedValue));
            Pessoa pes = new Pessoa();
            pes = (dalpes.retornarPessoa(((int)cbCliente.SelectedValue)));
            txtCPF.Text = pes.CPF;
            dgvVenda.DataSource = (new DALVenda().carregarVendasCliente(cli.id));
            dgvVenda.Columns[0].Visible = false;
            dgvVenda.Columns[1].Visible = false;
            dgvProdutos.DataSource = null;
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = ((new DALPessoa()).ListarClienteComConta());
            cbCliente.ValueMember = "id";
            cbCliente.DisplayMember = "nome";

            Cliente cli = new Cliente();
            DALPessoa dalpes = new DALPessoa();
            Pessoa pes = new Pessoa();
            cli = (dalpes.retornarCliente((int)cbCliente.SelectedValue));
            dgvVenda.DataSource = (new DALVenda().carregarVendasCliente(cli.id));
            pes = (dalpes.retornarPessoa(((int)cbCliente.SelectedValue)));

            txtCPF.Text = pes.CPF;
            
            dgvVenda.Columns[0].Visible = false;
            dgvVenda.Columns[1].Visible = false;
            dgvProdutos.DataSource = null;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (IsCpf(txtCPF.Text) == true)
            {
                BLLPessoa objBLL = new BLLPessoa();
                ClienteModel cli = new ClienteModel();

                cli = objBLL.retornarPessoaCliente(txtCPF.Text);
                if (cli != null)
                {
                    cbCliente.Text = "";//testar se o codigo está mudando com a mudança do selectedtext
                    cbCliente.SelectedText = cli.nome;
                    dgvVenda.DataSource = (new DALVenda().carregarVendasCliente(cli.id));
                    
                    dgvProdutos.DataSource = null;
                    //idPessoaGlobal = cli.id;
                }
                else
                    MessageBox.Show("O CPF não está cadastrado como cliente !");
            }
            else if (IsCpf(txtCPF.Text) == true)
            {
                MessageBox.Show("O CPF não está cadastrado !");
            }
            else
                MessageBox.Show("Informe um CPF valido !");
        }
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPagamento_KeyUp(object sender, KeyEventArgs e)
        {
            
                if (txtPagamento.Text != null)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtPagamento.Text, "[0-9]") || txtPagamento.Text.Contains(",") || txtPagamento.Text.Contains("."))
                    {
                        txtPagamento.Text = "";
                    }
                }
                else
                    txtPagamento.Text = "";
        }
    }
}
