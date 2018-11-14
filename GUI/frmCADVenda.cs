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
    public partial class frmCADVenda : MaterialForm
    {
        //private int cont = 0;//contador para criar as colunas no primeiro item do datagridview
        private List<ProdutoModel> listaproduto;
        private List<ProdutoModel> listaprodutocondicional;
        private List<ProdutoModel> listaprodutoestoque = null;
        private int idCondicional = 0;
        private DateTime dataInicio;
        private DateTime dataFinal;


        public frmCADVenda()
        {
            InitializeComponent();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;
            
            if (listaproduto != null &&listaproduto.Count > 0)
            {
                DALVenda venda = new DALVenda();
                Venda ven = new Venda();
                Cliente cli = new Cliente();
                List<ItensVenda> listiv = new List<ItensVenda>();
                ItensVenda iv = new ItensVenda();
                DALPessoa dalpes = new DALPessoa();
                cli = (dalpes.retornarCliente((int)cbCliente.SelectedValue));
                ven.idCliente = cli.id;//(int)cbCliente.SelectedValue;
                
                //ven.Valor = decimal.Parse(txtPreco.Text);
                ven.data = DateTime.Now;
                //ven.valorrestante = ven.Valor;
                ven.idCategoriaPagamento = (int)cbTipoPagamento.SelectedValue;
                ven.qtdParcelas = int.Parse(nudParcelamento.Text);
                ven.valorrestante = Convert.ToDecimal(txtPrecoFinal.Text);
                ven.Valor = Convert.ToDecimal(txtPrecoFinal.Text);
                ven.status = "Faturado";
                foreach (ProdutoModel prod in listaproduto)
                {
                    ItensVenda iv2 = new ItensVenda();
                    iv2.idProduto = prod.id;
                   // ven.Valor = ven.Valor + prod.preco;
                    //ven.valorrestante = ven.valorrestante + prod.preco;
                    listiv.Add(iv2);
                }
                //if(nudParcelamento.Value > 0)
                //{
                    //metodo diferente para parcelamentos
                //}
                bool resultado = venda.RealizarVenda(ven, listiv, cli);
                if (idCondicional != 0)
                {
                    //string status = "Vendido";
                    venda.ModificarStatusCondicionalVenda(idCondicional);
                    dgvListaCondicionais.DataSource = (new DALVenda().carregarCondicionais()).ToList();
                    idCondicional = 0;
                }
                
                if (resultado)
                {
                    avisos.Text = "Venda completada !";
                    frmCADVenda_Load(sender,e);
                    limparTextBoxes(this.Controls);
                    listaproduto = null;
                }

                else
                {
                    MessageBox.Show("Venda não completada !");
                }
            }
            else
            {
                avisos.Text = "Selecine algum produto !";
            }
            
        }
        

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                btnConsultar_Click(sender, e);
                avisos.Visible = false;
            }
        }

        private void btnCadTipoPagamento_Click(object sender, EventArgs e)
        {
            frmCADTipoPagamento frmCAD = new frmCADTipoPagamento();
            frmCAD.Show();
        }

        private void frmCADVenda_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = ((new BLLPessoa()).listarClientes());
            cbCliente.ValueMember = "id";
            cbCliente.DisplayMember = "nome";
            cbClienteCond.DataSource = ((new BLLPessoa()).listarClientes());
            cbClienteCond.ValueMember = "id";
            cbClienteCond.DisplayMember = "nome";
            cbClienteLista.DataSource = ((new BLLPessoa()).listarClientes());
            cbClienteLista.ValueMember = "id";
            cbClienteLista.DisplayMember = "nome";
            cbTipoPagamento.DataSource = BLLVenda.listarCategoriaPagamento();
            cbTipoPagamento.ValueMember = "id";
            cbTipoPagamento.DisplayMember = "nome";
            List<String> listaNomesCondicional = new List<string>(new string[]{"Pendente", "Devolvido"});
            cbStatusCondicionalLista.DataSource = listaNomesCondicional;
            dgvListaCondicionais.DataSource = (new DALVenda().carregarCondicionais()).ToList();

            //dgvListaCondicionais.Columns[4].Visible = false;
            
            // cbTipoPagamento.SelectedIndex = 0;
            //cbCliente.Items.AddRange();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string codigodebarras = txtCodigoDeBarras.Text;
            ProdutoModel obj = new ProdutoModel();

            Produto objP = DALProduto.selecionarProduto(codigodebarras);

            obj = BLLProduto.selecionarUm(codigodebarras);
            BLLCategoria BLLCat = new BLLCategoria();
            if (obj != null)
            {
                txtCodigoDeBarras.Text = obj.codigodebarra.Trim();
                txtQtd.Text = "1";
                txtPreco.Text = obj.preco.ToString();
                //avisos.Visible = true;
                avisos.Text = "Codigo de barras já registrado !";
                dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);


               // cbMarca.Focus();
            }
            else
            {
                MessageBox.Show("O produto não esta cadastrado !");
                txtPreco.Text = "";
                //txtPorcentagem.Text = "";
                txtQtd.Text = "1";

                dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);
            }
        }

        private void btnDescer_Click(object sender, EventArgs e)
        {
            int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;
            DALProduto objDAL = new DALProduto();
            ProdutoModel obj = objDAL.SelecionarProdutoModelID(id);
            ProdutoModel obj2 = DALProduto.pesquisarProduto(obj.codigodebarra);

            List<ProdutoModel> listAntiga = DALProduto.SelecionarListaUmItem(obj.id);
            if (dgvVenda.RowCount > 0)
            {
                
                listaproduto.Add(obj);
                
                dgvVenda.DataSource = listaproduto;
                txtCodigoDeBarras.Text = "";
                dgvProdutos.DataSource = null;
            }
            else
            {
                dgvVenda.DataSource = listAntiga;
                listaproduto = listAntiga;
                txtCodigoDeBarras.Text = "";
                dgvProdutos.DataSource = null;
            }
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;
            DALProduto objDAL = new DALProduto();
            ProdutoModel obj = objDAL.SelecionarProdutoModelID(id);
            ProdutoModel obj2 = DALProduto.pesquisarProduto(obj.codigodebarra);
            


            List<ProdutoModel> listAntiga = DALProduto.SelecionarListaUmItem(obj.id);
            if (dgvVenda.RowCount > 0)
            {
                decimal valor = decimal.Parse(txtPreco.Text);
                valor = valor + obj.preco;
                txtPreco.Text = valor.ToString();
                txtQtd.Text = dgvVenda.RowCount.ToString();
                listaproduto.Add(obj);
                //dgvVenda.AutoGenerateColumns = true;
                dgvVenda.DataSource = listaproduto.ToList();
                txtCodigoDeBarras.Text = "";
                dgvProdutos.DataSource = null;

            }
            else
            {
                //dgvVenda.AutoGenerateColumns = true;
                dgvVenda.DataSource = listAntiga.ToList();
                listaproduto = listAntiga;
                txtCodigoDeBarras.Text = "";
                dgvProdutos.DataSource = null;
            }

        }

        private void dgvVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvVenda.CurrentRow.Cells[0].Value;
            DALProduto objDAL = new DALProduto();
            ProdutoModel obj = objDAL.SelecionarProdutoModelID(id);
            ProdutoModel obj2 = DALProduto.pesquisarProduto(obj.codigodebarra);



            List<ProdutoModel> listAntiga = DALProduto.SelecionarListaUmItem(obj.id);
            if (dgvVenda.RowCount > 1)
            {

                //list = DALProduto.SelecionarListaUmItem(obj.id);
                decimal valor = decimal.Parse(txtPreco.Text);
                valor = valor - obj.preco;
                txtPreco.Text = valor.ToString();
                //listaproduto.Remove(obj);
                listaproduto.RemoveAll(l => l.id == id);
                dgvVenda.DataSource = listaproduto.ToList();//null;//list;
                txtCodigoDeBarras.Text = "";
                

            }
            else
            {
                
                //list.Remove(obj);
                dgvVenda.DataSource = null; //list;
                //list = listAntiga;
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int id = (int)dgvVenda.CurrentRow.Cells[0].Value;
            DALProduto objDAL = new DALProduto();
            ProdutoModel obj = objDAL.SelecionarProdutoModelID(id);
            ProdutoModel obj2 = DALProduto.pesquisarProduto(obj.codigodebarra);



            List<ProdutoModel> listAntiga = DALProduto.SelecionarListaUmItem(obj.id);
            if (dgvVenda.RowCount > 0)
            {

                //list = DALProduto.SelecionarListaUmItem(obj.id);
                listaproduto.Remove(obj);
                dgvVenda.DataSource = listaproduto;//list;
                txtCodigoDeBarras.Text = "";
                //dgvVenda.CurrentRow.Dispose();

                //dgvVenda.Update();

            }
            else
            {
                listaproduto.Remove(obj);
                dgvVenda.DataSource = null; //list;
                // dgvVenda.CurrentRow.Dispose();
                //dgvVenda.DataSource = list;
            }
        }

        private void btnConsultarCond_Click(object sender, EventArgs e)
        {
            string codigodebarras = txtCodigoBarrasCond.Text;
            ProdutoModel obj = new ProdutoModel();

            Produto objP = DALProduto.selecionarProduto(codigodebarras);

            obj = BLLProduto.selecionarUm(codigodebarras);
            BLLCategoria BLLCat = new BLLCategoria();
            if (obj != null)
            {
                txtCodigoBarrasCond.Text = obj.codigodebarra.Trim();
                txtQtdCond.Text = "1";
                txtPrecoCond.Text = obj.preco.ToString();
                //avisosCond.Visible = true;
                avisosCond.Text = "Codigo de barras já registrado !";
                dgvCondicional.DataSource = DALProduto.SelecionarListaComQtd(txtCodigoDeBarras.Text);


                //cbMarca.Focus();
            }
            else
            {
                MessageBox.Show("O produto não esta cadastrado !");
                txtPrecoCond.Text = "";
                //txtPorcentagem.Text = "";
                txtQtdCond.Text = "1";

                dgvCondicional.DataSource = DALProduto.SelecionarListaComQtd(txtCodigoDeBarras.Text);
            }
        }

        private void btnRealizarCondicional_Click(object sender, EventArgs e)//modificar para condicional, será que manteremos o produto ou retiraremos já na condicional ?
        {
            if (listaprodutocondicional != null && listaprodutocondicional.Count > 0)
            {
                DALVenda venda = new DALVenda();
                Condicional ven = new Condicional();
                Cliente cli = new Cliente();
                List<ItensCondicional> listiv = new List<ItensCondicional>();
                ItensVenda iv = new ItensVenda();
                DALPessoa dalpes = new DALPessoa();
                cli = (dalpes.retornarCliente((int)cbClienteCond.SelectedValue));
                ven.idCliente = cli.id;//(int)cbCliente.SelectedValue;

                //ven.Valor = decimal.Parse(txtPreco.Text);
                ven.data = DateTime.Now;
                //ven.valorrestante = ven.Valor;
                //ven.idCategoriaPagamento = (int)cbTipoPagamento.SelectedValue;
                //ven.qtdParcelas = int.Parse(nudParcelamento.Text);
                //ven.valorrestante = 0;
                ven.status = "Pendente";//cbStatusCondicionalLista.SelectedValue.ToString();
                foreach (ProdutoModel prod in listaprodutocondicional)
                {
                    ItensCondicional iv2 = new ItensCondicional();
                    iv2.idProduto = prod.id;
                    
                    //ven.Valor = ven.Valor + prod.preco;
                    //ven.valorrestante = ven.valorrestante + prod.preco;
                    listiv.Add(iv2);
                }
                bool resultado = venda.RealizarCondicional(ven, listiv, cli);
                dgvListaCondicionais.DataSource = (new DALVenda().carregarCondicionais()).ToList();
                if (resultado)
                    avisosCond.Text = "Condicional completado !";
                else
                {
                    avisosCond.Text = "Condicional não completado !";
                }
            }
            else
            {
                avisosCond.Text = "Selecine algum produto !";
            }
        }

        private void btnIrVenda_Click(object sender, EventArgs e)
        {
            if (dgvProdutosCondicional.RowCount > 0)
            {
                dgvVenda.DataSource = dgvProdutosCondicional.DataSource;
                foreach (DataGridViewRow r in dgvProdutosCondicional.Rows)
                {
                    ProdutoModel prod = new ProdutoModel();
                    prod = new DALProduto().SelecionarProdutoModelID((int)r.Cells[0].Value);//falta o teste, se funcionar é só colocar na parte da lista de condicionais também
                    listaproduto.Add(prod);
                }
                
                tabControl1.SelectTab(0);
            }
            else
            {
                MessageBox.Show("Não há produtos selecionados !");
            }
            //List<ProdutoModel> listaprodutos = dgvProdutosCondicional.Rows;
        }

        private void dgvCondicional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvCondicional.CurrentRow.Cells[0].Value;
            DALProduto objDAL = new DALProduto();
            ProdutoModel obj = objDAL.SelecionarProdutoModelID(id);
            ProdutoModel obj2 = DALProduto.pesquisarProduto(obj.codigodebarra);



            List<ProdutoModel> listAntiga = DALProduto.SelecionarListaUmItem(obj.id);
            if (dgvProdutosCondicional.RowCount > 0)
            {

                //list = DALProduto.SelecionarListaUmItem(obj.id);
                listaprodutocondicional.Add(obj);
                dgvProdutosCondicional.DataSource = listaprodutocondicional.ToList();
                //dgvProdutosCondicional.Update();
                //dgvProdutosCondicional.Refresh();
                //txtPreco.Text = 
                txtCodigoDeBarras.Text = "";
                dgvCondicional.DataSource = null;

                decimal valor = decimal.Parse(txtPrecoCond.Text);
                valor = valor + obj.preco;
                txtPrecoCond.Text = valor.ToString();
            }
            else
            {
                dgvProdutosCondicional.DataSource = listAntiga.ToList();
                listaprodutocondicional = listAntiga;
                txtCodigoDeBarras.Text = "";
                dgvCondicional.DataSource = null;
            }
        }

        private void dgvProdutosCondicional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvProdutosCondicional.CurrentRow.Cells[0].Value;
            DALProduto objDAL = new DALProduto();
            ProdutoModel obj = objDAL.SelecionarProdutoModelID(id);
            ProdutoModel obj2 = DALProduto.pesquisarProduto(obj.codigodebarra);



            List<ProdutoModel> listAntiga = DALProduto.SelecionarListaUmItem(obj.id);
            if (dgvProdutosCondicional.RowCount > 0)
            {

                //list = DALProduto.SelecionarListaUmItem(obj.id);
                listaprodutocondicional.RemoveAll(l => l.id == id);
                dgvProdutosCondicional.DataSource = listaprodutocondicional.ToList();//null;//list;
                txtCodigoDeBarras.Text = "";


            }
            else
            {

                //list.Remove(obj);
                dgvProdutosCondicional.DataSource = null; //list;
                //list = listAntiga;
            }
        }

        private void btnIrVendaLista_Click(object sender, EventArgs e)
        {
            if (dgvListaCondicionais.RowCount > 0)
            {
                decimal precosomado = 0;
                int id = (int)dgvListaCondicionais.CurrentRow.Cells[3].Value;
                dgvVenda.DataSource = dgvProdutosCondicional.DataSource;
                idCondicional = id;
                dgvVenda.DataSource =(new DALVenda().listaProdutosModelsDoCondicional(idCondicional));
                listaproduto = (new DALVenda().listaProdutosModelsDoCondicional(idCondicional));
                foreach (ProdutoModel produto in listaproduto)
                {
                    precosomado += produto.preco;
                }

                txtPreco.Text = precosomado.ToString();
                cbCliente.SelectedValue = (int)dgvListaCondicionais.CurrentRow.Cells[0].Value;
                //foreach (DataGridViewRow r in dgvVenda.Rows)//na duvida se não der certo, só tirar esse foreach
                //{
                 //   ProdutoModel prod = new ProdutoModel();
                  //  prod = new DALProduto().SelecionarProdutoModelID((int)r.Cells[0].Value);//falta o teste, se funcionar é só colocar na parte da lista de condicionais também
                    //listaproduto.Add(prod);//erro agora, não está mais adicionando na lista
                //}
                tabControl1.SelectTab(0);
            }
            else
            {
                MessageBox.Show("Não há produtos selecionados !");
            }
        }

        private void btnMudarStatus_Click(object sender, EventArgs e)
        {
            if (dgvListaCondicionais.RowCount > 0)
            {
                int id = (int)dgvListaCondicionais.CurrentRow.Cells[3].Value;
                //dgvVenda.DataSource = dgvListaCondicionais.DataSource;
                idCondicional = id;
                string status = cbStatusCondicionalLista.SelectedItem.ToString();
                DALVenda objDAL = new DALVenda();
                objDAL.ModificarStatusCondicional(id, status);
                avisosLista.Text = "Status do condicional modificado !";
                dgvListaCondicionais.DataSource = (new DALVenda().carregarCondicionais()).ToList();
                idCondicional = 0;
                //tabControl1.SelectTab(0);
            }
            else
            {
                MessageBox.Show("Não há condicional selecionado !");
            }
        }

        private void btnLocalizarCond_Click(object sender, EventArgs e)
        {
            if (IsCpf(txtCPFCond.Text) == true)
            {
                BLLPessoa objBLL = new BLLPessoa();
                ClienteModel cli = new ClienteModel();

                cli = objBLL.retornarPessoaCliente(txtCPFCond.Text);
                if (cli != null)
                {
                    cbClienteCond.Text = "";//testar se o codigo está mudando com a mudança do selectedtext
                    cbClienteCond.SelectedText = cli.nome;

                    //idPessoaGlobal = cli.id;
                }
                else
                    MessageBox.Show("O CPF não está cadastrado como cliente !");
            }
            else if (IsCpf(txtCPFCond.Text) == true)
            {
                MessageBox.Show("O CPF não está cadastrado !");
            }
            else
                MessageBox.Show("Informe um CPF valido !");
        }

        private void btnConsultaLista_Click(object sender, EventArgs e)
        {
            if (IsCpf(txtCPFLista.Text) == true)
            {
                BLLPessoa objBLL = new BLLPessoa();
                ClienteModel cli = new ClienteModel();

                cli = objBLL.retornarPessoaCliente(txtCPFLista.Text);
                if (cli != null)
                {
                    cbClienteLista.Text = "";//testar se o codigo está mudando com a mudança do selectedtext
                    cbClienteLista.SelectedText = cli.nome;
                    new DALVenda().carregarCondicionaisPorCliente(cli.id);
                    //idPessoaGlobal = cli.id;
                }
                else
                    MessageBox.Show("O CPF não está cadastrado como cliente !");
            }
            else if (IsCpf(txtCPFLista.Text) == true)
            {
                MessageBox.Show("O CPF não está cadastrado !");
            }
            else
                MessageBox.Show("Informe um CPF valido !");
        }

        private void filtrarData(DateTime inicio, DateTime fim)
        {
            if (inicio < fim)
            {
                dgvListaCondicionais.DataSource = DALVenda.carregarCondicionaisPorData(inicio, fim);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            dataInicio =Convert.ToDateTime(dtpInicio);
            filtrarData(dataInicio, dataFinal);
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            dataFinal = Convert.ToDateTime(dtpFinal);
            filtrarData(dataInicio, dataFinal);
        }

        private void btnNomeCliente_Click(object sender, EventArgs e)
        {
            ClienteModel cli = new ClienteModel();
            if ((cli = new DALPessoa().retornarPessoaCliente((int)cbClienteLista.SelectedValue)) != null)
            {
                BLLPessoa objBLL = new BLLPessoa();

                //cli = objBLL.retornarPessoaCliente(txtCPFLista.Text);
                    cbClienteLista.Text = "";//testar se o codigo está mudando com a mudança do selectedtext
                    cbClienteLista.SelectedText = cli.nome;
                    dgvListaCondicionais.DataSource = new DALVenda().carregarCondicionaisPorCliente(cli.id);
                    //idPessoaGlobal = cli.id;
            }
            else if (IsCpf(txtCPFLista.Text) == true)
            {
                MessageBox.Show("O CPF não está cadastrado !");
            }
        }
        private void txtPorcentagem_KeyUp(object sender, KeyEventArgs e)
        {
            decimal numero;
            if (txtPorcentagem.Text != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPorcentagem.Text, "[0-9]") || txtPorcentagem.Text.Contains(",") || txtPorcentagem.Text.Contains("."))
                {
                    txtPorcentagem.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
                }
            }
            else
                txtPorcentagem.Text = "";
            if (txtPreco.Text != null)
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(txtPreco.Text, "[0-9]"))
                {
                    if (decimal.TryParse(txtPorcentagem.Text, out numero))
                    {
                        numero = (Decimal.Parse(txtPreco.Text) - (Decimal.Parse((txtPreco.Text)) * ((Decimal.Parse(txtPorcentagem.Text)) / 100)));
                        txtPrecoFinal.Text = Math.Round(numero, 2).ToString();
                    }
                    else
                        txtPrecoFinal.Text = "";
                }
                else
                {
                    //MessageBox.Show("Digite apenas numeros !");
                    txtPorcentagem.Text = "";
                }

            }
            else
                txtPrecoFinal.Text = "";
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
            }
        }

        private void cbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DALPessoa dalpes = new DALPessoa();
            Pessoa pes = new Pessoa();
            pes = (dalpes.retornarPessoa(((int)cbCliente.SelectedValue)));
            txtCPF.Text = pes.CPF;
        }

        private void cbClienteLista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DALPessoa dalpes = new DALPessoa();
            Pessoa pes = new Pessoa();
            pes = (dalpes.retornarPessoa(((int)cbClienteLista.SelectedValue)));
            txtCPFLista.Text = pes.CPF;
        }

        private void cbClienteLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbClienteCond_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DALPessoa dalpes = new DALPessoa();
            Pessoa pes = new Pessoa();
            pes = (dalpes.retornarPessoa(((int)cbClienteCond.SelectedValue)));
            txtCPFCond.Text = pes.CPF;
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
        }

        private void txtPrecoFinal_KeyUp(object sender, KeyEventArgs e)
        {
            txtPorcentagem.Enabled = true;
            if (txtPrecoFinal.Text != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrecoFinal.Text, "[0-9]") || txtPrecoFinal.Text.Contains(",") || txtPrecoFinal.Text.Contains("."))
                {
                    txtPrecoFinal.Text = "";
                }
            }
            else
                txtPrecoFinal.Text = "";
        }

        private void btnCarregarClientes_Click(object sender, EventArgs e)
        {
            dgvClientesParaCondicional.DataSource = DALVenda.carregarClientesParaCondicional();
        }

        private void btnIrParaCondicional_Click(object sender, EventArgs e)
        {
            int id = (int)dgvClientesParaCondicional.CurrentRow.Cells[0].Value;
            cbClienteCond.SelectedValue = id;
            tabControl1.SelectTab(1);
        }

        private void cbTipoPagamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cbTipoPagamento.SelectedValue == 2)
            {
                nudParcelamento.Value = 0;
            }
        }
    }
}
