using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    class DALEfetuarVenda
    {
        public void Salvar(Estoque item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {

                    //db.categoria.Attach(item);
                    db.Estoque.Add(item);
                    //db.Entry(item).State = System.Data.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }
    }
}
