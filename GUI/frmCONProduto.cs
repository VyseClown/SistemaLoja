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
using Modelo;

namespace GUI
{
    public partial class frmCONProduto : Form
    {
        public frmCONProduto()
        {
            InitializeComponent();
        }

        private void frmCONProduto_Load(object sender, EventArgs e)
        {
            //var objCBCategoria = new Categoria();
            //var objCBCategoriaB = new BLLProduto();
            string descricao = "";
            
            var categorias = BLLProduto.selecionarcategoria(descricao);
            categorias.Insert(0, new Categoria { descricao = "" });
            cbCategoria.DataSource = categorias;
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "descricao";

            var marcas = BLLProduto.ListarMarca();
            marcas.Insert(0, new Marcas { nome = "" });
            cbMarca.DataSource = marcas;
            cbMarca.ValueMember = "id";
            cbMarca.DisplayMember = "nome";

            var modelos = BLLProduto.ListarModelo();
            modelos.Insert(0, new DAL.Modelo { nome = "" });
            cbModelo.DataSource = modelos;
            cbModelo.ValueMember = "id";
            cbModelo.DisplayMember = "nome";

            var tamanhos = BLLProduto.ListarTamanho();
            tamanhos.Insert(0, new Tamanhos { nome = "" });
            cbTamanho.DataSource = tamanhos;
            cbTamanho.ValueMember = "id";
            cbTamanho.DisplayMember = "nome";

            var cores = BLLProduto.ListarCor();
            cores.Insert(0, new Cor { Nome = "" });
            cbCor.DataSource = cores;
            cbCor.ValueMember = "id";
            cbCor.DisplayMember = "Nome";
            txtCodigoDeBarras.Focus();
        }

        private void button1_Click(object sender, EventArgs e)//retirar do estoque
        {
            try
            {
                var BLLProduto = new BLLProduto();
                var produto = new Produto();

                DALProduto objDAL = new DALProduto();
                int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;
                produto = objDAL.SelecionarProdutoID(id);

                BLLProduto.DiminuirEstoque(produto);
                //BLLProduto.Excluir(produto);
                //if(DALProduto.SelecionarLista(txtCodigoDeBarras.Text).Count != 0)

                dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);


                limparTextBoxes(this.Controls);
                txtPreco.Text = "";
                //avisos.Text = ("Excluido com sucesso !");
                //avisos.Visible = true;
                //dgvProdutos.Refresh();

                txtCodigoDeBarras.Focus();
                lblAvisos.Text = ("Estoque decrementado com sucesso !");
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Preencha todos os campos, se estiver preenchido corretamente, não existe o produto no estoque");
            }
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

        private void txtcodigodebarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                btnConsulta_Click(sender, e);
               // avisos.Visible = false;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
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
                txtQtd.Text = obj.quantidade.ToString();
                //if (objP.condicional == "Sim")
                //    cbCondicional.Checked = true;
                //else
                //    cbCondicional.Checked = false;
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
                //avisos.Visible = true;
                //avisos.Text = "Codigo de barras já registrado !";
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

        

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMudanca(this.Controls);

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMudanca(this.Controls);
        }

        private void cbCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMudanca(this.Controls);
        }


        private void cbMudanca(Control.ControlCollection controles)
        {
            List<Produto> lista = new List<Produto>();
            Produto prod = new Produto();
            BLLProduto objBLL = new BLLProduto();

            //prod.marca = int.Parse(cbMarca.SelectedValue.ToString());
            //prod.modelo = int.Parse(cbModelo.SelectedValue.ToString());
            //prod.tamanho = int.Parse(cbTamanho.SelectedValue.ToString());
            //prod.categoriaid = int.Parse(cbCategoria.SelectedValue.ToString());
            //prod.preco = Convert.ToDecimal(txtPreco.Text);
            //prod.cor = int.Parse(cbCor.SelectedValue.ToString());
            //prod.codigodebarra = txtCodigoDeBarras.Text;

            //if (ctrl is TextBox)
            //{
            //    ((TextBox)(ctrl)).Text = String.Empty;
            //}
            int cont = 0;
            string cmd = "SELECT * FROM Produto WHERE ";//em cada if eu vou concatenar ou não á sigla where
            foreach (Control controle in controles)
            {
                if(controle is ComboBox)
                {
                    if (controle.Name == "cbModelo") //String.Empty)
                    {
                        if (((ComboBox)(controle)).SelectedIndex == -1 || ((ComboBox)(controle)).SelectedIndex == 0)//.Text == "")
                        {//entrando aqui vamos ver que está vazio

                        
                            //MessageBox.Show("Está vazio !");
                        }
                        else
                        {//ver como colocar o AND ou verificar se é o primeiro, enfim, resolva !
                            if(cmd.Length > 30)
                            {
                                string modelo = " AND modelo = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += modelo;
                                cont += 1;
                            }
                            else
                            {
                                string modelo = " modelo = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += modelo;
                                cont += 1;
                            }
                            //vê se isso dá certo
                            //MessageBox.Show("Está preenchido !");
                        }
                    }
                    if(controle.Name == "cbMarca")
                    {
                        if (((ComboBox)(controle)).SelectedIndex == -1 || ((ComboBox)(controle)).SelectedIndex == 0)//.Text == "")
                        {//entrando aqui vamos ver que está vazio


                            //MessageBox.Show("Está vazio !");
                        }
                        else
                        {//ver como colocar o AND ou verificar se é o primeiro, enfim, resolva !
                            if(cmd.Length > 30)
                            {
                                string marca = " AND marca = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += marca;
                                cont++;
                            }
                            else
                            {
                                string marca = " marca = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += marca;

                                cont += 1;
                            }
                            
                        }
                    }
                    if(controle.Name == "cbCor")
                    {
                        if (((ComboBox)(controle)).SelectedIndex == -1 || ((ComboBox)(controle)).SelectedIndex == 0)
                        {
                            
                        }
                        else
                        {
                            if (cmd.Length > 30)
                            {
                                string cor = " AND cor = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += cor;
                                cont++;
                            }
                            else
                            {                                                            
                            string cor = "cor = " + ((ComboBox)(controle)).SelectedValue;
                            cmd += cor;
                            cont += 1;
                            }
                        }
                    }
                    if (controle.Name == "cbTamanho")
                    {
                        if (((ComboBox)(controle)).SelectedIndex == -1 || ((ComboBox)(controle)).SelectedIndex == 0)
                        {

                        }
                        else
                        {
                            if (cmd.Length > 30)
                            {
                                string tamanho = " AND tamanho = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += tamanho;
                                cont++;
                            }
                            else
                            {
                                string tamanho = "tamanho = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += tamanho;
                                cont += 1;
                            }
                        }
                    }
                    if (controle.Name == "cbCategoria")
                    {
                        if (((ComboBox)(controle)).SelectedIndex == -1 || ((ComboBox)(controle)).SelectedIndex == 0)
                        {

                        }
                        else
                        {
                            if (cmd.Length > 30)
                            {
                                string categoriaid = " AND categoriaid = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += categoriaid;
                                cont++;
                            }
                            else
                            {
                                string categoria = "categoriaid = " + ((ComboBox)(controle)).SelectedValue;
                                cmd += categoria;
                                cont += 1;
                            }
                        }
                    }
                    
                }

            }
            //como mandar o comando agora ?
            if (cont == 0)
            {
                cmd = "SELECT * FROM Produto WHERE ";
                if (cbSemEstoque.Checked == false)
                    cmd += " quantidade > 0";
                else
                    cmd = "SELECT * FROM Produto";

                //cmd += " AND quantidade > 0";
            }
            else
            {
                if (cbSemEstoque.Checked == false)
                    cmd += " AND quantidade > 0";
            }

            List<Produto> listaProduto = new List<Produto>();
            listaProduto = objBLL.RetornarListaFiltro(cmd);
            dgvProdutos.DataSource = listaProduto;
            int contador = 0;
            foreach (var item in listaProduto)
            {
                contador += item.quantidade.Value;//(int)dgvProdutos.CurrentRow.Cells[11].Value;
            }
            lblQtd.Text = contador.ToString();

            //int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;

            //dgvProdutos.DataSource = lista;
        }

        private void cbModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //como fazer essa merda ?
            cbMudanca(this.Controls);
        }

        private void cbTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMudanca(this.Controls);
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMudanca(this.Controls);
        }
    }
}
