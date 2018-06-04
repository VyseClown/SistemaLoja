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
    public partial class frmCADCategoria : Form
    {
        public frmCADCategoria()
        {
            InitializeComponent();
            //var objCBCategoriaB = new BLLProduto();
            string descricao = "";
            //cbCategoria.DataSource = objCBCategoriaB.selecionarcategoria(descricao);
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



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cat = new Categoria();
            var BLLCat = new BLLCategoria();

            if (txtDescricao.Text != "")
            {
                cat.descricao = txtDescricao.Text;

                BLLCat.Incluir(cat);
                txtDescricao.Text = "";
                cbCategoria.DataSource = BLLProduto.selecionarcategoria("");
                cbCategoria.ValueMember = "id";
                cbCategoria.DisplayMember = "descricao";
                MessageBox.Show("Salvo com sucesso !");
            }
            else
                MessageBox.Show("Informe algum nome !");
        }

        private void btnSalvarModelo_Click(object sender, EventArgs e)
        {
            DAL.Modelo mod = new DAL.Modelo();
            BLLProduto objProduto = new BLLProduto();
            if (txtNomeModelo.Text != "")
            {
                mod.nome = txtNomeModelo.Text;
                objProduto.IncluirModelo(mod);
                txtNomeModelo.Text = "";
                cbModelo.DataSource = BLLProduto.ListarModelo();
                cbModelo.ValueMember = "id";
                cbModelo.DisplayMember = "nome";
                MessageBox.Show("Salvo com sucesso !");
                txtNomeModelo.Focus();
            }
            else
                MessageBox.Show("Informe algum nome !");
                
            
        }

        private void btnSalvarMarca_Click(object sender, EventArgs e)
        {
            Marcas m = new Marcas();
            BLLProduto objProduto = new BLLProduto();
            if (txtNomeMarca.Text != "")
            {
                m.nome = txtNomeMarca.Text;
                objProduto.IncluirMarca(m);
                txtNomeMarca.Text = "";
                cbMarca.DataSource = BLLProduto.ListarMarca();
                cbMarca.ValueMember = "id";
                cbMarca.DisplayMember = "nome";
                MessageBox.Show("Salvo com sucesso !");
                txtNomeMarca.Focus();
            }
            else
                MessageBox.Show("Informe algum nome !");
        }

        private void btnSalvaTamanho_Click(object sender, EventArgs e)
        {
            Tamanhos tam = new Tamanhos();
            BLLProduto objProduto = new BLLProduto();
            if (txtNomeTamanho.Text != "")
            {
                tam.nome = txtNomeTamanho.Text;
                objProduto.IncluirTamanho(tam);
                txtNomeTamanho.Text = "";
                cbTamanho.DataSource = BLLProduto.ListarTamanho();
                cbTamanho.ValueMember = "id";
                cbTamanho.DisplayMember = "nome";
                MessageBox.Show("Salvo com sucesso !");
                txtNomeTamanho.Focus();
            }
            else
                MessageBox.Show("Informe algum nome !");
        }

        private void btnSalvarCor_Click(object sender, EventArgs e)
        {
            Cor m = new Cor();
            BLLProduto objProduto = new BLLProduto();
            if (txtCor.Text != "")
            {
                m.Nome = txtCor.Text;
                objProduto.IncluirCor(m);
                txtCor.Text = "";
                cbCor.DataSource = BLLProduto.ListarCor();
                cbCor.ValueMember = "id";
                cbCor.DisplayMember = "Nome";
                MessageBox.Show("Salvo com sucesso !");
                txtCor.Focus();
            }
            else
                MessageBox.Show("Informe algum nome !");
        }

        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            new BLLProduto().Excluir(new BLLProduto().selecionarCategoriaComID(int.Parse(cbCategoria.SelectedValue.ToString())));
            string descricao = "";
            //cbCategoria.DataSource = objCBCategoriaB.selecionarcategoria(descricao);
            cbCategoria.DataSource = BLLProduto.selecionarcategoria(descricao);
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "descricao";
            MessageBox.Show("Categoria excluida !");
        }

        private void btnExcluirModelo_Click(object sender, EventArgs e)
        {
            new BLLProduto().Excluir(new BLLProduto().selecionarModeloComID(int.Parse(cbModelo.SelectedValue.ToString())));
            cbModelo.DataSource = BLLProduto.ListarModelo();
            cbModelo.ValueMember = "id";
            cbModelo.DisplayMember = "nome";
            MessageBox.Show("Modelo excluida !");
        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {
            new BLLProduto().Excluir(new BLLProduto().selecionarMarcaComID(int.Parse(cbMarca.SelectedValue.ToString())));
            cbMarca.DataSource = BLLProduto.ListarMarca();
            cbMarca.ValueMember = "id";
            cbMarca.DisplayMember = "nome";
            MessageBox.Show("Marca excluida !");
        }

        private void btnExcluirTamanho_Click(object sender, EventArgs e)
        {
            new BLLProduto().Excluir(new BLLProduto().selecionarTamanhoComID(int.Parse(cbTamanho.SelectedValue.ToString())));
            cbTamanho.DataSource = BLLProduto.ListarTamanho();
            cbTamanho.ValueMember = "id";
            cbTamanho.DisplayMember = "nome";
            MessageBox.Show("Tamanho excluida !");
        }

        private void btnExcluirCor_Click(object sender, EventArgs e)
        {
            new BLLProduto().Excluir(new BLLProduto().selecionarCorComID(int.Parse(cbCor.SelectedValue.ToString())));
            cbCor.DataSource = BLLProduto.ListarCor();
            cbCor.ValueMember = "id";
            cbCor.DisplayMember = "Nome";
            MessageBox.Show("Cor excluida !");
        }
    }
}
