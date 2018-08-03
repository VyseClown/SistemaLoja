using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLCategoria
    {
        public void Incluir(Categoria item)
        {
            if (item.descricao.Trim().Length == 0)
            {
                throw new Exception("Precisa do nome da categoria");
            }

            DALCategoria DALobj = new DALCategoria();
            DALobj.Salvar(item);
            DALobj = null;
        }
        public void Alterar(Categoria item)
        {
            if (item.id <= 0)
            {
                throw new Exception("O codigo é obrigatório");
            }
            if (item.descricao.Trim().Length == 0)
            {
                throw new Exception("Precisa do nome da categoria");
            }

            DALCategoria DALobj = new DALCategoria();
            DALobj.Alterar(item);
        }
        public void Excluir(Categoria item)
        {
            DALCategoria DALobj = new DALCategoria();
            DALobj.Excluir(item);
        }
        public int selecionarIDCategoria(string categoria)
        {
            //DALCategoria objDAL = new DALCategoria();
            int codigo = DALCategoria.Selecionarcod(categoria);
            if (codigo != 0)
                return codigo;
            else
                return 0;
        }
        public List<Categoria> listarTodasCat()
        {
            DALCategoria objDAL = new DALCategoria();
            List<Categoria> lista = objDAL.SelecionarTodas();
            return lista;
        }
    }
}
