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
    public partial class frmCADTipoPagamento : Form
    {
        public frmCADTipoPagamento()
        {
            InitializeComponent();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cat = new CategoriaPagamento();
            var BLLCat = new BLLVenda();

            if (txtDescricao.Text != "")
            {
                cat.nome = txtDescricao.Text;

                BLLCat.Salvar(cat);
                txtDescricao.Text = "";
                cbCategoria.DataSource = BLLProduto.selecionarcategoria("");
                cbCategoria.ValueMember = "id";
                cbCategoria.DisplayMember = "descricao";
                MessageBox.Show("Salvo com sucesso !");
            }
            else
                MessageBox.Show("Informe algum nome !");
        }

        private void frmCADTipoPagamento_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = BLLVenda.listarCategoriaPagamento();
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "nome";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            new BLLVenda().Excluir(new BLLVenda().selecionarCategoriaPagamentoComID(int.Parse(cbCategoria.SelectedValue.ToString())));
            MessageBox.Show("Tipo de pagamento apagado com sucesso !");
        }
    }
}
