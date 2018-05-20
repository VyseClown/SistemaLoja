using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BLL
{
    public class BLLProduto
    {
        public bool Salvar(Produto item)
        {
            try
            {
                DALProduto DALobj = new DALProduto();
                if (DALobj.Salvar(item) == true)
                {
                    DALobj = null;
                    return true;
                }
                else
                { 
                    DALobj = null;
                    return false;
                }


            }
            catch (Exception)
            {

                return false;
            }
            //if (item.nome.Trim().Length == 0 || item.categoriaid == null || item.codigodebarra == null || item.modelo == null || Convert.ToString(item.preco) == null || item.tamanho == null)
            //{
            //    throw new Exception("Precisa do nome do produto");
            //}
            //else
            //{
            //}
            
            
        }
        public string SelecionarModeloComCodigo(int id)
        {
            DALProduto objDAL = new DALProduto();
            string nome;
            nome = objDAL.SelecionarModeloComCodigo(id);
            if (nome != "")
                return nome;
            else
                return null;
        }
        public string SelecionarMarcaComCodigo(int id)
        {
            DALProduto objDAL = new DALProduto();
            string nome;
            nome = objDAL.SelecionarMarcaComCodigo(id);
            if (nome != "")
                return nome;
            else
                return null;
        }
        public string SelecionarTamanhoComCodigo(int id)
        {
            DALProduto objDAL = new DALProduto();
            string nome;
            nome = objDAL.SelecionarTamanhoComCodigo(id);
            if (nome != "")
                return nome;
            else
                return null;
        }
        public int SelecionarModeloIDComNome(string nome)
        {
            DALProduto objDAL = new DALProduto();
            int codigo;
            codigo = objDAL.SelecionarModeloIDComNome(nome);
            if (codigo != 0)
                return codigo;
            else
                return 0;
        }
        public int SelecionarMarcaIDComNome(string nome)
        {
            DALProduto objDAL = new DALProduto();
            int codigo;
            codigo = objDAL.SelecionarMarcaIDComNome(nome);
            if (codigo != 0)
                return codigo;
            else
                return 0;
        }
        public int SelecionarTamanhoIDComNome(string nome)
        {
            DALProduto objDAL = new DALProduto();
            int codigo;
            codigo = objDAL.SelecionarTamanhoIDComNome(nome);
            if (codigo != 0)
                return codigo;
            else
                return 0;
        }

        public bool Excluir(Produto item)
        {
            //escreve a função de excluir, krl
            var objDAL = new DALProduto();
            if (objDAL != null)
            {
                objDAL.Excluir(item);
                return true;
            }
            else
                return false;

        }
        public static List<Categoria> selecionarcategoria(string descricao)
        {
            //List<categoria> lista =new List<categoria>();
            List<Categoria> lista = new List<Categoria>();
            var objDAL = new DALCategoria();
            lista = objDAL.Selecionar(descricao);
            objDAL = null;
            return lista;
        }
        public int selecionarcategoriaCodigo(string descricao)
        {
            //List<categoria> lista =new List<categoria>();
            int categoriaid;
            //var objDAL = new DALCategoria();
            categoriaid = DALCategoria.Selecionarcod(descricao);
            //objDAL = null;
            return categoriaid;
        }
        public static string selecionarcategoriaCodigoInt(int codigo)
        {
            //List<categoria> lista =new List<categoria>();
            string categoriastring;
            //var objDAL = new DALCategoria();
            categoriastring = DALCategoria.SelecionarcodInt(codigo);
            //objDAL = null;
            return categoriastring;
        }
        public static ProdutoModel selecionarUm(string codigodebarras)
        {
            //List<categoria> lista =new List<categoria>();
            //int codigodebarra;
            //var objDAL = new DALCategoria();
            var obj = new ProdutoModel();
            obj = DALProduto.SelecionarUm(codigodebarras);
            if (obj != null)
            {
                return obj;
            }
            else
                return null;
            //objDAL = null;
            
        }
        public static List<Marcas> ListarMarca()
        {
            DALProduto objDAL = new DALProduto();
            return objDAL.SelecionarMarcaLista();
        }
        public static List<DAL.Modelo> ListarModelo()
        {
            DALProduto objDAL = new DALProduto();
            return objDAL.SelecionarModeloLista();
        }
        public static List<Tamanhos> ListarTamanho()
        {
            DALProduto objDAL = new DALProduto();
            return objDAL.SelecionarTamanhoLista();
        }
        public static List<Cor> ListarCor()
        {
            DALProduto objDAL = new DALProduto();
            return objDAL.SelecionarCorLista();
        }
        public void IncluirMarca(Marcas item)
        {
            if (item.nome.Trim().Length == 0)
            {
                throw new Exception("Precisa do nome da categoria");
            }

            DALProduto DALobj = new DALProduto();
            DALobj.Salvar(item);
            DALobj = null;
        }
        public void IncluirCor(Cor item)
        {
            if (item.Nome.Trim().Length == 0)
            {
                throw new Exception("Precisa do nome da cor");
            }

            DALProduto DALobj = new DALProduto();
            DALobj.Salvar(item);
            DALobj = null;
        }
        public void IncluirModelo(DAL.Modelo item)
        {
            if (item.nome.Trim().Length == 0)
            {
                throw new Exception("Precisa do nome da categoria");
            }

            DALProduto DALobj = new DALProduto();
            DALobj.Salvar(item);
            DALobj = null;
        }
        public void IncluirTamanho(Tamanhos item)
        {
            if (item.nome.Trim().Length == 0)
            {
                throw new Exception("Precisa do nome da categoria");
            }

            DALProduto DALobj = new DALProduto();
            DALobj.Salvar(item);
            DALobj = null;
        }
        public void DiminuirEstoque(Produto produto)
        {
            var objProduto = new Produto();
            var objDALProduto = new DALProduto();
            
            if (produto != null)
            {
                int qtd = produto.quantidade.Value;
                if (produto.quantidade >= 1)
                {
                    produto.quantidade--;
                    objDALProduto.Alterar(produto);
                }
                else
                {
                    //objDAL.Excluir(objEstoque);
                    //objDALProduto.Excluir(produto);
                }

            }

        }
        public void AumentarEstoque(Produto produto, int qtde)
        {
            DALProduto objDALProduto = new DALProduto();
            if(qtde == 0)
            {
                produto.quantidade = 0;
                objDALProduto.Alterar(produto);
            }
            else
            {
                DALProduto objDAL = new DALProduto();
                produto.quantidade += qtde;
                objDALProduto.Alterar(produto);
            }
        }
        public List<Produto> RetornarListaFiltro(string cmd)
        {
            List<Produto> lista = new List<Produto>();

            DALProduto objDAL = new DALProduto();
            return objDAL.retornaListaFiltroProduto(cmd); 
        }
    }
}
