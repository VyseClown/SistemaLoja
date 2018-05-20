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
    public partial class frmCADPessoa : Form
    {
        int idPessoaGlobal = 0;
        public frmCADPessoa()
        {
            InitializeComponent();
            BLLPessoa BLLObj = new BLLPessoa();
            cbEstado.DataSource = BLLObj.listarEstados();
            cbEstado.ValueMember = "Id";
            cbEstado.DisplayMember = "name";

            cbCidade.DataSource = BLLObj.listarCidades(int.Parse(cbEstado.SelectedValue.ToString()));
            cbCidade.ValueMember = "Id";
            cbCidade.DisplayMember = "name";
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


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarConteudoTextBoxes(this.Controls) == true)
            {
                Pessoa pes = new Pessoa();
                BLLPessoa BLLObj = new BLLPessoa();



                pes.nome = txtNome.Text;
                pes.telefone = txtTelefone.Text;
                pes.celular = txtCelular.Text;
                pes.email = txtEmail.Text;
                pes.CPF = txtCPF.Text;
                pes.celular2 = txtCelular2.Text;
                pes.datanascimento = dtpNascimento.Value.Date;
                pes.telefone2 = txtTelefone2.Text;
                pes.RG = txtRG.Text;
                if (IsCpf(txtCPF.Text) == true)
                {
                    if (BLLObj.Salvar(pes) != false)
                    {
                        Cliente cli = new Cliente();
                        Funcionario fun = new Funcionario();
                        bool func = false;


                        if (rbCliente.Checked)
                        {
                            cli.idPessoa = pes.id;
                            cli.limitecredito = Decimal.Parse(txtLimite.Text);
                            func = BLLObj.Salvar(cli);
                        }
                        else
                        {
                            fun.idPessoa = pes.id;
                            fun.Salario = Decimal.Parse(txtSalario.Text);
                            func = BLLObj.Salvar(fun);
                        }

                        if (func != false)
                        {
                            Endereco end = new Endereco();
                            end.bairro = txtBairro.Text;
                            end.rua = txtRua.Text;
                            end.numero = txtNumero.Text;
                            end.CEP = txtCEP.Text;
                            end.idCidade = (int)cbCidade.SelectedValue;
                            if (BLLObj.Salvar(end) != false)
                            {
                                pes.idEndereco = end.id;
                                BLLObj.AlterarPessoa(pes);

                                cbEstado.DataSource = BLLObj.listarEstados();
                                cbEstado.ValueMember = "Id";
                                cbEstado.DisplayMember = "name";

                                cbCidade.DataSource = BLLObj.listarCidades(int.Parse(cbEstado.SelectedValue.ToString()));
                                cbCidade.ValueMember = "Id";
                                cbCidade.DisplayMember = "name";

                                limparTextBoxes(this.Controls);
                                txtLimite.Text = "";
                                txtSalario.Text = "";
                            }
                            else
                            {
                                //apagar ultimo item adicionado
                            }
                        }
                        else
                        {
                            //apagar ultimo item adicionado
                        }

                    }

                }
                else
                {
                    //mensagem de aviso
                    MessageBox.Show("Informe o CPF valido !");
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
                        if (((TextBox)(ctrl)).Text.Contains(""))
                        {
                            MessageBox.Show("Preencha todos os campos !");
                            return false;
                        }
                        else
                            cont++;
                    }

                    else
                        if (((MaskedTextBox)(ctrl)).Text.Contains(""))
                    {
                        MessageBox.Show("Preencha todos os campos !");
                        return false;
                    }
                    else
                        cont++;
                }
            }
            if (cont > 0)
                return true;
            else
                return false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            ClienteModel cliModel = new ClienteModel();
            FuncionarioModel funcModel = new FuncionarioModel();
            BLLPessoa BLLObj = new BLLPessoa();
            if (rbCliente.Checked)
            {
                if (IsCpf(txtCPF.Text) == true)
                {
                    cliModel = BLLObj.retornarPessoaCliente(idPessoaGlobal);
                    if (cliModel != null)
                    {
                        pes = BLLObj.retornarPessoa(cliModel.id);
                        pes.CPF = txtCPF.Text;
                        BLLObj.AlterarPessoa(pes);
                    }
                    else
                    {
                        MessageBox.Show("Não há cadastro da pessoa como cliente !");
                        return;
                    }
                }
            }
            else
            {
                if (IsCpf(txtCPF.Text) == true)
                {
                    funcModel = BLLObj.retornarPessoaFuncionario(idPessoaGlobal);
                    if (funcModel != null)
                    {
                        pes = BLLObj.retornarPessoa(funcModel.id);
                        pes.CPF = txtCPF.Text;
                        BLLObj.AlterarPessoa(pes);
                    }
                    else
                    {
                        MessageBox.Show("Não há cadastro da pessoa como funcionario !");
                        return;
                    }
                }
            }
            pes.celular = txtCelular.Text;
            pes.celular2 = txtCelular2.Text;
            pes.datanascimento = dtpNascimento.Value;
            pes.email = txtEmail.Text;
            pes.nome = txtNome.Text;
            pes.telefone = txtTelefone.Text;
            pes.telefone2 = txtTelefone2.Text;
            pes.RG = txtRG.Text;



            if (IsCpf(txtCPF.Text) == true)
            {
                if (BLLObj.AlterarPessoa(pes) != false)
                {
                    Cliente cli = new Cliente();
                    Funcionario fun = new Funcionario();
                    bool func = false;


                    if (rbCliente.Checked)
                    {
                        //cli.idPessoa = pes.id;
                        cli = BLLObj.retornarCliente(idPessoaGlobal);
                        cli.limitecredito = Decimal.Parse(txtLimite.Text);
                        func = BLLObj.AlterarCliente(cli);
                    }
                    else
                    {
                        //fun.idPessoa = pes.id;
                        fun = BLLObj.retornarFuncionario(idPessoaGlobal);
                        fun.Salario = Decimal.Parse(txtSalario.Text);
                        func = BLLObj.AlterarFuncionario(fun);
                    }

                    if (func != false)
                    {
                        Endereco end = new Endereco();
                        end = BLLObj.retornarEndereco(idPessoaGlobal);
                        end.bairro = txtBairro.Text;
                        end.rua = txtRua.Text;
                        end.numero = txtNumero.Text;
                        end.idCidade = (int)cbCidade.SelectedValue;
                        end.CEP = txtCEP.Text;
                        if (BLLObj.AlterarEndereco(end) != false)
                        {

                            cbEstado.DataSource = BLLObj.listarEstados();
                            cbEstado.ValueMember = "Id";
                            cbEstado.DisplayMember = "name";

                            cbCidade.DataSource = BLLObj.listarCidades(int.Parse(cbEstado.SelectedValue.ToString()));
                            cbCidade.ValueMember = "Id";
                            cbCidade.DisplayMember = "name";

                            limparTextBoxes(this.Controls);
                        }
                        else
                        {
                            //apagar ultimo item adicionado
                            limparTextBoxes(this.Controls);
                        }
                    }
                    else
                    {
                        //apagar ultimo item adicionado
                        limparTextBoxes(this.Controls);
                    }

                }

            }
            else
            {
                //mensagem de aviso
                MessageBox.Show("Informe o CPF correto");
            }
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BLLPessoa endbus = new BLLPessoa();

            cbCidade.DataSource = endbus.listarCidades(int.Parse(cbEstado.SelectedValue.ToString()));
            cbCidade.ValueMember = "Id";
            cbCidade.DisplayMember = "name";
        }

        private void txtLimite_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLimite.Text, "[0-9]"))
            {
                txtLimite.Text = string.Format("{0:#,###0.00}", double.Parse(txtLimite.Text));
            }
        }

        private void txtLimite_KeyUp(object sender, KeyEventArgs e)
        {
            //decimal numero;
            if (txtLimite.Text != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtLimite.Text, "[0-9]") || txtLimite.Text.Contains(",") || txtLimite.Text.Contains("."))
                {
                    txtLimite.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
                }
            }
            else
                txtLimite.Text = "";
        }


        private void rbFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            txtSalario.ReadOnly = false;
            txtLimite.Text = "";
            txtLimite.ReadOnly = true;
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtSalario.ReadOnly = true;
            txtLimite.ReadOnly = false;
            txtSalario.Text = "";

        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSalario.Text, "[0-9]"))
            {
                txtSalario.Text = string.Format("{0:#,###0.00}", double.Parse(txtSalario.Text));
            }
        }

        private void txtSalario_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSalario.Text != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSalario.Text, "[0-9]") || txtSalario.Text.Contains(",") || txtSalario.Text.Contains("."))
                {
                    txtSalario.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
                }
            }
            else
                txtSalario.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (rbCliente.Checked && IsCpf(txtCPF.Text) == true)
            {
                BLLPessoa objBLL = new BLLPessoa();
                ClienteModel cli = new ClienteModel();

                cli = objBLL.retornarPessoaCliente(txtCPF.Text);
                if (cli != null)
                {
                    txtNome.Text = cli.nome;
                    txtBairro.Text = cli.bairro;
                    txtCelular.Text = cli.celular;
                    txtCelular2.Text = cli.celular2;
                    txtEmail.Text = cli.email;
                    txtLimite.Text = cli.limitecredito.ToString();
                    txtNumero.Text = cli.numero;
                    txtRG.Text = cli.RG;
                    txtRua.Text = cli.rua;
                    txtTelefone.Text = cli.telefone;
                    txtTelefone2.Text = cli.telefone2;
                    txtCEP.Text = cli.CEP;

                    dtpNascimento.Text = cli.dataNascimento.ToShortDateString();

                    cbEstado.SelectedValue = cli.idEstado;

                    cbCidade.DataSource = objBLL.listarCidades(int.Parse(cbEstado.SelectedValue.ToString()));
                    cbCidade.ValueMember = "Id";
                    cbCidade.DisplayMember = "name";
                    cbCidade.SelectedValue = cli.idCidade;

                    idPessoaGlobal = cli.id;
                }
                else
                    MessageBox.Show("O CPF não está cadastrado como cliente !");
            }
            else if (rbFuncionario.Checked && txtCPF.Text != "")
            {
                BLLPessoa objBLL = new BLLPessoa();
                FuncionarioModel cli = new FuncionarioModel();
                cli = objBLL.retornarPessoaFuncionario(txtCPF.Text);
                if (cli != null)
                {
                    txtNome.Text = cli.nome;
                    txtBairro.Text = cli.bairro;
                    txtCelular.Text = cli.celular;
                    txtCelular2.Text = cli.celular2;
                    txtEmail.Text = cli.email;
                    txtSalario.Text = cli.salario.ToString();
                    txtNumero.Text = cli.numero;
                    txtRG.Text = cli.RG;
                    txtRua.Text = cli.rua;
                    txtTelefone.Text = cli.telefone;
                    txtTelefone2.Text = cli.telefone2;
                    txtCEP.Text = cli.CEP;

                    cbEstado.SelectedValue = cli.idEstado;

                    cbCidade.DataSource = objBLL.listarCidades(int.Parse(cbEstado.SelectedValue.ToString()));
                    cbCidade.ValueMember = "Id";
                    cbCidade.DisplayMember = "name";
                    cbCidade.SelectedValue = cli.idCidade;

                    idPessoaGlobal = cli.id;
                }
                else
                    MessageBox.Show("O CPF não está cadastrado como funcionário !");
            }
        }
    }
}
