using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVenda
    {
        public bool Salvar(CategoriaPagamento item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.CategoriaPagamento.Add(item);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
                return false;
            }

        }
        public void Excluir(CategoriaPagamento item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public List<CategoriaPagamento> listarCategoriaPagamento()
        {
            List<CategoriaPagamento> lista = new List<CategoriaPagamento>();
            using(quiteriamodasEntities db = new quiteriamodasEntities())
            {
                lista = (from cp in db.CategoriaPagamento select cp).ToList();
            }
            return lista;
        }
        public CategoriaPagamento SelecionarCategoriaPagamentoComCodigo(int id)
        {
            CategoriaPagamento cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                cp = (from m in db.CategoriaPagamento
                        where m.id == id
                        select m).FirstOrDefault();
            }
            return cp;
        }
    }
}
