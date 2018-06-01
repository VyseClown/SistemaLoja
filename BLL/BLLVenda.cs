using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLVenda
    {
        public bool Salvar(CategoriaPagamento item)
        {
            try
            {
                DALVenda DALobj = new DALVenda();
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
        }
        public static List<CategoriaPagamento> listarCategoriaPagamento()
        {
            DALVenda objDAL = new DALVenda();
            return objDAL.listarCategoriaPagamento();
        }
        public bool Excluir(CategoriaPagamento item)
        {
            //escreve a função de excluir, krl
            var objDAL = new DALVenda();
            if (objDAL != null)
            {
                objDAL.Excluir(item);
                return true;
            }
            else
                return false;

        }
        public CategoriaPagamento selecionarCategoriaPagamentoComID(int id)
        {
            //List<categoria> lista =new List<categoria>();
            DALVenda objDAL = new DALVenda();
            CategoriaPagamento cat;
            //var objDAL = new DALCategoria();
            cat = objDAL.SelecionarCategoriaPagamentoComCodigo(id);
            //objDAL = null;
            return cat;
        }
    }
}
