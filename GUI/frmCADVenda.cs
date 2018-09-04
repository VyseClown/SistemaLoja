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
    public partial class frmCADVenda : Form
    {
        //private int cont = 0;//contador para criar as colunas no primeiro item do datagridview
        List<ProdutoModel> listaproduto = null;
        List<ProdutoModel> listaprodutocondicional = null;
        List<ProdutoModel> listaprodutoestoque = null;
        private int idCondicional = 0;

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
                ven.valorrestante = 0;
                ven.Valor = 0;
                foreach (ProdutoModel prod in listaproduto)
                {
                    ItensVenda iv2 = new ItensVenda();
                    iv2.idProduto = prod.id;
                    ven.Valor = ven.Valor + prod.preco;
                    ven.valorrestante = ven.valorrestante + prod.preco;
                    listiv.Add(iv2);
                }
                bool resultado = venda.RealizarVenda(ven, listiv, cli);
                if (idCondicional != 0)
                {
                    //string status = "Vendido";
                    venda.ModificarStatusCondicional(idCondicional);
                    idCondicional = 0;
                }
                listaproduto = null;
                if(resultado == true)
                    avisos.Text = "Venda completada !";
                else
                {
                    
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
            cbTipoPagamento.DataSource = BLLVenda.listarCategoriaPagamento();
            cbTipoPagamento.ValueMember = "id";
            cbTipoPagamento.DisplayMember = "nome";
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
                //txtDescricao.Text = obj.descricao.Trim();
                cbMarca.Text = obj.marca.Trim();
                cbModelo.Text = obj.modelo.Trim();
                cbTamanho.Text = obj.tamanho;
                //txtPrecoCompra.Text = objP.precoCompra.ToString();
                //txtQtd.Text = objP.quantidade.ToString();
                txtQtd.Text = "1";
                //if (objP.condicional == "Sim")
                //  cbCondicional.Checked = true;
                //else
                //  cbCondicional.Checked = false;
                //cbNome.Text = obj.nome.Trim();

                //var objCBCategoria = new Categoria();
                //int categoria = Convert.ToInt16(obj.categoriaid);
                //string categoriaDescricao = "";



                //categoriaDescricao = BLLProduto.selecionarcategoriaCodigoInt(categoria);
                cbCategoria.DataSource = BLLCat.listarTodasCat();//e é assim que selecionamos todos mas deixamos na categoria do próprio
                cbCategoria.ValueMember = "id";//produto !
                cbCategoria.DisplayMember = "descricao";



                cbMarca.DataSource = BLLProduto.ListarMarca();
                cbMarca.ValueMember = "id";
                cbMarca.DisplayMember = "nome";

                cbModelo.DataSource = BLLProduto.ListarModelo();
                cbModelo.ValueMember = "id";
                cbModelo.DisplayMember = "nome";

                cbTamanho.DataSource = BLLProduto.ListarTamanho();
                cbTamanho.ValueMember = "id";
                cbTamanho.DisplayMember = "nome";

                cbCor.DataSource = BLLProduto.ListarCor();
                cbCor.ValueMember = "id";
                cbCor.DisplayMember = "Nome";

                cbCategoria.SelectedValue = objP.categoriaid;
                cbMarca.SelectedValue = objP.marca;
                cbModelo.SelectedValue = objP.modelo;
                cbTamanho.SelectedValue = objP.tamanho;
                cbCor.SelectedValue = objP.cor;
                txtPreco.Text = obj.preco.ToString();
                avisos.Visible = true;
                avisos.Text = "Codigo de barras já registrado !";
                dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);


                cbMarca.Focus();
            }
            else
            {
                MessageBox.Show("O produto não esta cadastrado !");
                cbMarca.Focus();
                //txtPrecoCompra.Text = "";
                //txtDescricao.Text = "";
                txtPreco.Text = "";
                //txtPorcentagem.Text = "";
                txtQtd.Text = "1";
                //txtDescricao.Text = "2017";

                cbMarca.DataSource = BLLProduto.ListarMarca();
                cbMarca.ValueMember = "id";
                cbMarca.DisplayMember = "nome";

                cbModelo.DataSource = BLLProduto.ListarModelo();
                cbModelo.ValueMember = "id";
                cbModelo.DisplayMember = "nome";

                cbTamanho.DataSource = BLLProduto.ListarTamanho();
                cbTamanho.ValueMember = "id";
                cbTamanho.DisplayMember = "nome";

                cbCategoria.DataSource = BLLCat.listarTodasCat();
                cbCategoria.ValueMember = "id";
                cbCategoria.DisplayMember = "descricao";

                cbCor.DataSource = BLLProduto.ListarCor();
                cbCor.ValueMember = "id";
                cbCor.DisplayMember = "Nome";

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

                //list = DALProduto.SelecionarListaUmItem(obj.id);
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
            //List<DataGridViewRow> selRow = dgvProdutos.SelectedRows;
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

                //list = DALProduto.SelecionarListaUmItem(obj.id);
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
            

            
            //int RowIndex = dgvVenda.RowCount - 1;
            //DataGridViewRow row = dgvVenda.Rows[RowIndex];
            //row.Cells["id"].Value = obj.id;
            //row.Cells["tamanho"].Value = obj.tamanho;
            //row.Cells["preco"].Value = obj.preco;
            //row.Cells["marca"].Value = obj.marca;
            //row.Cells["quantidade"].Value = obj.quantidade;
            //row.Cells["cor"].Value = obj.cor;
            //row.Cells["modelo"].Value = obj.modelo;
            //row.Cells["categoria"].Value = obj2.categoria;
            //row.Cells["data"].Value = obj.data;
            //row.Cells["condicional"].Value = obj.condicional;
            //row.Cells["codigodebarra"].Value = obj.codigodebarra;


            //dgvVenda.Rows.Add(row);
            //if (dgvVenda.RowCount > 0)
            //{
            //    dgvVenda.Rows.Add(row);
            //}

            //if (cont == 0)
            //{
            //DALProduto objDAL = new DALProduto();
            //Produto obj = objDAL.SelecionarProdutoID(id);
            //dgvVenda.DataSource = DALProduto.SelecionarLista(obj.codigodebarra);
            //cont++;
            //}
            //else {
            //    DALProduto objDAL = new DALProduto();
            //    Produto obj = objDAL.SelecionarProdutoID(id);
            //dgvVenda.DataSource = DALProduto.SelecionarLista(obj.codigodebarra);
            //DataTable dataTable = (DataTable)dgvVenda.DataSource;
            //    DataRow drToAdd = dataTable.NewRow();
            //    drToAdd["id"] = obj.id;
            //    drToAdd["tamanho"] = obj.tamanho;
            //    drToAdd["preco"] = obj.preco;
            //    drToAdd["marca"] = obj.marca;
            //    drToAdd["quantidade"] = obj.quantidade;
            //    drToAdd["cor"] = obj.cor;
            //    drToAdd["modelo"] = obj.modelo;
            //    drToAdd["categoria"] = obj.Categoria;
            //    drToAdd["data"] = obj.data;
            //    drToAdd["condicional"] = obj.condicional;
            //    drToAdd["codigodebarra"] = obj.codigodebarra;
            //    dataTable.Rows.Add(drToAdd);
            //    dataTable.AcceptChanges();
            //    dgvVenda.DataSource = dataTable;
            //}

        }

        private void dgvVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                dgvVenda.DataSource = listaproduto;//null;//list;
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
                //txtDescricao.Text = obj.descricao.Trim();
                cbMarcaCond.Text = obj.marca.Trim();
                cbModeloCond.Text = obj.modelo.Trim();
                cbTamanhoCond.Text = obj.tamanho;
                txtQtdCond.Text = "1";
                cbCategoriaCond.DataSource = BLLCat.listarTodasCat();//e é assim que selecionamos todos mas deixamos na categoria do próprio
                cbCategoriaCond.ValueMember = "id";//produto !
                cbCategoriaCond.DisplayMember = "descricao";

                cbMarcaCond.DataSource = BLLProduto.ListarMarca();
                cbMarcaCond.ValueMember = "id";
                cbMarcaCond.DisplayMember = "nome";

                cbModeloCond.DataSource = BLLProduto.ListarModelo();
                cbModeloCond.ValueMember = "id";
                cbModeloCond.DisplayMember = "nome";

                cbTamanhoCond.DataSource = BLLProduto.ListarTamanho();
                cbTamanhoCond.ValueMember = "id";
                cbTamanhoCond.DisplayMember = "nome";

                cbCorCond.DataSource = BLLProduto.ListarCor();
                cbCorCond.ValueMember = "id";
                cbCorCond.DisplayMember = "Nome";

                cbCategoriaCond.SelectedValue = objP.categoriaid;
                cbMarcaCond.SelectedValue = objP.marca;
                cbModeloCond.SelectedValue = objP.modelo;
                cbTamanhoCond.SelectedValue = objP.tamanho;
                cbCorCond.SelectedValue = objP.cor;
                txtPrecoCond.Text = obj.preco.ToString();
                avisosCond.Visible = true;
                avisosCond.Text = "Codigo de barras já registrado !";
                dgvCondicional.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);


                cbMarca.Focus();
            }
            else
            {
                MessageBox.Show("O produto não esta cadastrado !");
                //cbMarca.Focus();
                //txtPrecoCompra.Text = "";
                //txtDescricao.Text = "";
                txtPrecoCond.Text = "";
                //txtPorcentagem.Text = "";
                txtQtdCond.Text = "1";
                //txtDescricao.Text = "2017";

                cbMarcaCond.DataSource = BLLProduto.ListarMarca();
                cbMarcaCond.ValueMember = "id";
                cbMarcaCond.DisplayMember = "nome";

                cbModeloCond.DataSource = BLLProduto.ListarModelo();
                cbModeloCond.ValueMember = "id";
                cbModeloCond.DisplayMember = "nome";

                cbTamanhoCond.DataSource = BLLProduto.ListarTamanho();
                cbTamanhoCond.ValueMember = "id";
                cbTamanhoCond.DisplayMember = "nome";

                cbCategoriaCond.DataSource = BLLCat.listarTodasCat();
                cbCategoriaCond.ValueMember = "id";
                cbCategoriaCond.DisplayMember = "descricao";

                cbCorCond.DataSource = BLLProduto.ListarCor();
                cbCorCond.ValueMember = "id";
                cbCorCond.DisplayMember = "Nome";

                dgvCondicional.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);
            }
        }

        private void btnRealizarCondicional_Click(object sender, EventArgs e)
        {
            if (listaproduto != null && listaproduto.Count > 0)
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
                ven.valorrestante = 0;
                ven.Valor = 0;
                foreach (ProdutoModel prod in listaproduto)
                {
                    ItensVenda iv2 = new ItensVenda();
                    iv2.idProduto = prod.id;
                    ven.Valor = ven.Valor + prod.preco;
                    ven.valorrestante = ven.valorrestante + prod.preco;
                    listiv.Add(iv2);
                }
                bool resultado = venda.RealizarVenda(ven, listiv, cli);
                listaproduto = null;
                if (resultado == true)
                    avisos.Text = "Condicional completado !";
                else
                {
                    avisos.Text = "Condicional não completado !";
                }
            }
            else
            {
                avisos.Text = "Selecine algum produto !";
            }
        }

        private void btnIrVenda_Click(object sender, EventArgs e)
        {
            if (dgvProdutosCondicional.RowCount > 0)
            {
                dgvVenda.DataSource = dgvProdutosCondicional.DataSource;
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
            if (dgvVenda.RowCount > 0)
            {

                //list = DALProduto.SelecionarListaUmItem(obj.id);
                listaprodutocondicional.Add(obj);
                dgvProdutosCondicional.DataSource = listaprodutocondicional;
                txtCodigoDeBarras.Text = "";
                dgvCondicional.DataSource = null;

            }
            else
            {
                dgvProdutosCondicional.DataSource = listAntiga;
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
                listaprodutocondicional.Remove(obj);
                dgvProdutosCondicional.DataSource = listaprodutocondicional;//null;//list;
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
            if (dgvProdutosCondicional.RowCount > 0)
            {
                int id = (int)dgvListaCondicionais.CurrentRow.Cells[0].Value;
                dgvVenda.DataSource = dgvProdutosCondicional.DataSource;
                idCondicional = id;
                tabControl1.SelectTab(0);
            }
            else
            {
                MessageBox.Show("Não há produtos selecionados !");
            }
        }
    }
}
