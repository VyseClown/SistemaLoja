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
    public partial class frmCADProduto : Form
    {
        public frmCADProduto()
        {
            InitializeComponent();
        }

        private void frmCADProduto_Load(object sender, EventArgs e)
        {
            var objCBCategoria = new Categoria();
            //var objCBCategoriaB = new BLLProduto();
            string descricao = "";
            //cbCategoria.DataSource = objCBCategoriaB.selecionarcategoria(descricao);
            cbCategoria.DataSource = BLLProduto.selecionarcategoria(descricao);
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "descricao";
            //---------------------Espaço para mexer no preço
            //txtPreco.Text = "0";
            //txtPreco.Text = Convert.ToDecimal(txtPreco.Text).ToString("c");
            //maskedbox
            //mtxtPreco.Text = "0";
            //mtxtPreco.Text = Convert.ToDecimal(mtxtPreco.Text).ToString("c");
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

            txtPorcentagem.Enabled = false;
        }
        private bool Validar()
        {
            foreach (Control verifica in this.Controls)
            {
                if (verifica.GetType().Equals(typeof(TextBox)))
                {
                    if (verifica.Text == string.Empty)
                    {
                        //MessageBox.Show("Preencha todos os campos !");
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valida = Validar();
                //if (valida)//qualquer coisa, tira esse if que estamos usando para validar
                if (txtPreco.Text != "" && txtQtd.Text != "")
                {
                    //if (BLLProduto.selecionarUm(txtCodigoDeBarras.Text) == null)
                    //{
                    var produto = new Produto();
                    var BLLProduto = new BLLProduto();
                    //var BLLEstoque = new BLLEstoque();

                    produto.codigodebarra = txtCodigoDeBarras.Text.Trim();
                    //produto.nome = txtNome.Text.Trim();
                    produto.modelo = int.Parse(cbModelo.SelectedValue.ToString());//BLLProduto.SelecionarModeloIDComNome(cbModelo.SelectedValue.ToString());//cbModelo.Text.Trim();
                                                                                  //como vou adicionar numeros apenas com virgulas
                                                                                  //produto.preco = Convert.ToDecimal(txtPreco.ToString());
                                                                                  //com txt comum terá que digitar as virgulas
                    produto.preco = Convert.ToDecimal(txtPreco.Text);
                    produto.marca = int.Parse(cbMarca.SelectedValue.ToString());//BLLProduto.SelecionarMarcaIDComNome(cbMarca.SelectedValue.ToString());//txtMarca.Text.Trim();
                                                                                //produto.descricao = txtDescricao.Text.Trim();
                    produto.data = DateTime.Now.Date;
                    produto.cor = int.Parse(cbCor.SelectedValue.ToString());
                    produto.quantidade = int.Parse(txtQtd.Text);
                    if (cbCondicional.Checked == true)
                        produto.condicional = "Sim";
                    else
                        produto.condicional = "Não";
                    if (txtPrecoCompra.Text != "")
                        produto.precoCompra = Convert.ToDecimal(txtPrecoCompra.Text);//fazer isso já que minha mãe não se lembra de quanto custou cada peça

                    produto.categoriaid = int.Parse(cbCategoria.SelectedValue.ToString());//BLLProduto.selecionarcategoriaCodigo(this.cbCategoria.GetItemText(this.cbCategoria.SelectedItem));
                    produto.tamanho = int.Parse(cbTamanho.SelectedValue.ToString());//BLLProduto.SelecionarTamanhoIDComNome(cbTamanho.SelectedIndex.ToString());//txtTamanho.Text.Trim();

                    Produto prod = DALProduto.selecionarProduto(txtCodigoDeBarras.Text);
                    Produto prod2 = new Produto();
                    //Produto p2 = DALProduto.selecionarProdutoMMTC2(produto.marca, produto.modelo.Value, produto.tamanho.Value, produto.categoriaid.Value, produto.preco, produto.cor.Value);
                    // DE if (BLLProduto.selecionarUm(txtCodigoDeBarras.Text) != null)
                    //PARA

                    if (txtCodigoDeBarras.Text == "")
                    {
                        if ((prod2 = DALProduto.selecionarProdutoMMTC2(produto.marca.Value, produto.modelo.Value, produto.tamanho.Value, produto.categoriaid.Value, produto.preco.Value, produto.cor.Value)) != null)
                        {//começar a procurar pela quantidade acima de zero para quando eu criar a venda !
                            BLLProduto.AumentarEstoque(prod2, int.Parse(txtQtd.Text));
                            avisos.Visible = true;
                            avisos.Text = "Estoque sem codigo de barras atualizado com sucesso !";
                            //txtPorcentagem.ReadOnly = true;
                            dgvProdutos.DataSource = DALProduto.SelecionarLista(prod2.codigodebarra);
                            limparTextBoxes(this.Controls);
                            txtCodigoDeBarras.Focus();
                        }
                        else
                        {
                            BLLProduto.Salvar(produto);
                            avisos.Visible = true;
                            avisos.Text = "Salvo com sucesso sem codigo de barras !";
                            dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);
                            limparTextBoxes(this.Controls);
                            txtCodigoDeBarras.Focus();
                        }

                    }

                    else if (prod != null)
                    {//tenho que focar em comparar todas as caracteristicas, incluindo o preço caso o codigo de barra já existir, se for o mesmo
                        //preço, podemos continuar e adicionar no estoque, se não, criar outro produto e tentar controlar isso de ter o codigo de barras igual, talvez
                        //em uma lista, e então sim adicionar ao estoque
                        Produto p = DALProduto.selecionarProdutoMMTC(produto.marca.Value, produto.modelo.Value, produto.tamanho.Value, produto.categoriaid.Value, produto.preco.Value, produto.cor.Value, produto.codigodebarra);
                        if (p != null)
                        {
                            BLLProduto.AumentarEstoque(p,int.Parse(txtQtd.Text));
                            //BLLProduto.Salvar(produto);
                            avisos.Visible = true;
                            //avisos.Text = "Estoque atualizado com sucesso !";
                            avisos.Text = "Estoque atualizado com sucesso !";
                            //txtPorcentagem.ReadOnly = true;
                            dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);
                            limparTextBoxes(this.Controls);
                            txtCodigoDeBarras.Focus();
                        }
                        
                        else// if (BLLProduto.Salvar(produto) == true)//não é tudo igual, mas ainda precisamos garantir que deu certo para mexer no estoque
                        {
                            BLLProduto.Salvar(produto);
                            avisos.Visible = true;

                            avisos.Text = "Salvo com sucesso !";
                            produto = null;
                            dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);
                            limparTextBoxes(this.Controls);
                            txtPreco.Text = "";
                            txtCodigoDeBarras.Focus();
                        }

                    }
                    
                    else
                    {
                        BLLProduto.Salvar(produto);
                        avisos.Visible = true;
                        avisos.Text = "Salvo com sucesso !";
                        dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);
                        limparTextBoxes(this.Controls);
                        txtCodigoDeBarras.Focus();
                    }
                }
                else
                    MessageBox.Show("Preencha os campos obrigatórios !");
                
            }
            catch (Exception)
            {

                MessageBox.Show("Escreva o tipo de dado certo ! Numero onde deve ter numero e letra onde deve ter letra");
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

        private void button1_Click(object sender, EventArgs e)//nova categoria
        {
            frmCADCategoria frmCAD = new frmCADCategoria();
            frmCAD.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)//atualizar
        {
            var objCBCategoria = new Categoria();
            string descricao = "";
            cbCategoria.DataSource = BLLProduto.selecionarcategoria(descricao);
            cbCategoria.ValueMember = "id";
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
        }
        
        private void lbItens_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Ainda não esta implementado !");
        }
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
            txtCodigoDeBarras.Focus();
        }

        private void button2_Click(object sender, EventArgs e)//pesquisar o codigo de barras
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
                txtPrecoCompra.Text = objP.precoCompra.ToString();
                //txtQtd.Text = objP.quantidade.ToString();
                txtQtd.Text = "1";
                if (objP.condicional == "Sim")
                    cbCondicional.Checked = true;
                else
                    cbCondicional.Checked = false;
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
                txtPrecoCompra.Text = "";
                //txtDescricao.Text = "";
                txtPreco.Text = "";
                txtPorcentagem.Text = "";
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var BLLProduto = new BLLProduto();
                var produto = new Produto();
                
                DALProduto objDAL = new DALProduto();
                int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;
                produto = objDAL.SelecionarProdutoID(id);

                objDAL.DiminuirEstoque(produto);
                //BLLProduto.Excluir(produto);
                //if(DALProduto.SelecionarLista(txtCodigoDeBarras.Text).Count != 0)
                
                dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);
                

                limparTextBoxes(this.Controls);
                txtPreco.Text = "";
                //avisos.Text = ("Excluido com sucesso !");
                avisos.Text = ("Estoque decrementado com sucesso !");
                avisos.Visible = true;
                //dgvProdutos.Refresh();

                txtCodigoDeBarras.Focus();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Preencha todos os campos, se estiver preenchido corretamente, não existe o produto no estoque");
            }
            
        }


        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            
                button2_Click(sender,e);
                avisos.Visible = false;
            }
        }



        private void txtPreco_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPreco.Text != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPreco.Text, "[0-9]") || txtPreco.Text.Contains(",") || txtPreco.Text.Contains("."))
                {
                    txtPreco.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
                }
            }
            else
                txtPreco.Text = "";
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        { 
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPreco.Text, "[0-9]"))
            {
                txtPreco.Text = string.Format("{0:#,###0.90}", double.Parse(txtPreco.Text));
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
            if (txtPrecoCompra.Text != null)
            {
                
                if (System.Text.RegularExpressions.Regex.IsMatch(txtPrecoCompra.Text, "[0-9]"))
                {
                    if (decimal.TryParse(txtPorcentagem.Text, out numero))
                    {
                        numero = (Decimal.Parse(txtPrecoCompra.Text) + (Decimal.Parse((txtPrecoCompra.Text)) * ((Decimal.Parse(txtPorcentagem.Text)) / 100)));
                        txtPreco.Text = Math.Round(numero, 2).ToString();
                    }
                    else
                        txtPreco.Text = "";
                }
                else
                {
                    //MessageBox.Show("Digite apenas numeros !");
                    txtPorcentagem.Text = "";
                }

            }
            else
                txtPreco.Text = "";
        }

        private void txtPrecoCompra_Leave(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrecoCompra.Text, "[0-9]"))
            {
                txtPrecoCompra.Text = string.Format("{0:#,###0.90}", double.Parse(txtPrecoCompra.Text));

                txtPorcentagem.Focus();
            }
            else
            {
                txtPorcentagem.Enabled = false;
                txtPrecoCompra.Text = "";
            }
                
        }

        private void cbCondicional_CheckedChanged(object sender, EventArgs e)
        {
            //if(cbCondicional.Checked = true)
            //    txtPrecoCompra.
        }

        private void txtPrecoCompra_KeyUp(object sender, KeyEventArgs e)
        {
            txtPorcentagem.Enabled = true;
            if (txtPrecoCompra.Text != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrecoCompra.Text, "[0-9]") || txtPrecoCompra.Text.Contains(",") || txtPrecoCompra.Text.Contains("."))
                {
                    txtPrecoCompra.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
                }
            }
            else
                txtPrecoCompra.Text = "";
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;
            DALProduto objDAL = new DALProduto();
            Produto obj = objDAL.SelecionarProdutoID(id);

            txtCodigoDeBarras.Text = obj.codigodebarra;
            cbMarca.SelectedValue = obj.marca;
            cbModelo.SelectedValue = obj.modelo;
            cbCategoria.SelectedValue = obj.categoriaid;
            cbCor.SelectedValue = obj.cor;
            cbTamanho.SelectedValue = obj.tamanho;
            //txtDescricao.Text = obj.descricao;
            txtPrecoCompra.Text = obj.precoCompra.ToString();
            txtPreco.Text = obj.preco.ToString();
            txtQtd.Text = obj.quantidade.ToString();

            btnExcluir.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            DALProduto objDAL = new DALProduto();
            int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;
            produto = objDAL.SelecionarProdutoID(id);
            produto.marca = (int)cbMarca.SelectedValue;
            produto.modelo = (int)cbModelo.SelectedValue;
            produto.categoriaid = (int)cbCategoria.SelectedValue;
            produto.tamanho = (int)cbTamanho.SelectedValue;
            produto.cor = (int)cbCor.SelectedValue;
          //  produto.descricao = txtDescricao.Text;
            produto.quantidade = int.Parse(txtQtd.Text);
            if (txtPrecoCompra.Text != "")
                produto.precoCompra = decimal.Parse(txtPrecoCompra.Text);
            else
                produto.precoCompra = null;
            if (cbCondicional.Checked == true)
                produto.condicional = "Sim";
            else
                produto.condicional = "Não";

            produto.preco = decimal.Parse(txtPreco.Text);
            objDAL.Alterar(produto);
            dgvProdutos.DataSource = DALProduto.SelecionarLista(txtCodigoDeBarras.Text);
            avisos.Text = "Alterado com sucesso !";
            limparTextBoxes(this.Controls);
            txtCodigoDeBarras.Focus();

        }

        private void txtQtd_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQtd.Text != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtQtd.Text, "[0-9]") || txtQtd.Text.Contains(",") || txtQtd.Text.Contains("."))
                {
                    txtQtd.Text = "";
                    //txtLimite.Text = txtLimite.Text.Remove(txtLimite.Text.Length - 1);
                    //txtLimite.Text.Remove(txtLimite.Text.Count - 1)
                }
            }
            else
                txtQtd.Text = "";
        }
    }
}
