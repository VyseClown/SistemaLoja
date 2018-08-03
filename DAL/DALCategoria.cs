using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core;
using System.Windows;
using System.Windows.Forms;

namespace DAL
{
    public class DALCategoria
    {
        public void Salvar(Categoria item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {

                    //db.categoria.Attach(item);
                    db.Categoria.Add(item);
                    //db.Entry(item).State = System.Data.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
            
        }
        public void Excluir(Categoria item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void Alterar(Categoria item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<Categoria> Selecionar(string descricao)
        {
            List<Categoria> Lista = new List<Categoria>();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                Lista = (from c in db.Categoria
                         where c.descricao.Contains(descricao)
                         orderby c.descricao
                         select c).ToList();
            }
            return Lista;
        }
        public List<Categoria> SelecionarTodas()
        {
            List<Categoria> Lista = new List<Categoria>();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                Lista = (from c in db.Categoria
                         orderby c.descricao
                         select c).ToList();
            }
            return Lista;
        }
        public static int Selecionarcod(string descricao)
        {
            //var obj = new categoria();
            Categoria obj;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from c in db.Categoria
                       where c.descricao.Contains(descricao)
                         orderby c.descricao
                         select c).FirstOrDefault();
            }

            return obj?.id ?? 0;
        }

        public static string SelecionarcodInt(int codigo)
        {
            //var obj = new Categoria();
            string obj;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from c in db.Categoria
                       where c.id.Equals(codigo)
                       orderby c.id
                       select c.descricao).FirstOrDefault();
            }
            return obj;
        }
        public List<Categoria> SelecionarCat(Categoria item)
        {
            List<Categoria> Lista = new List<Categoria>();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                Lista = (from c in db.Categoria
                         where c.descricao.Contains(item.descricao)
                         orderby c.descricao
                         select c).ToList();
            }
            return Lista;
        }

    }
}
