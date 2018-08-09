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
        public frmCADVenda()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

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
                //txtPrecoCompra.Text = objP.precoCompra.ToString();
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

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                button2_Click(sender, e);
                avisos.Visible = false;
            }
        }

        private void btnCadTipoPagamento_Click(object sender, EventArgs e)
        {
            frmCADTipoPagamento frmCAD = new frmCADTipoPagamento();
            frmCAD.Show();
        }
    }
}
