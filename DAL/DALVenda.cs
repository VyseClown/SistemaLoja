using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool RealizarVenda(Venda item, List<ItensVenda> listaItems, Cliente cli)
        {
            try
            {
                DALProduto dalprod = new DALProduto();
                
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    if((cli.limitecredito - cli.totalComprado) > item.Valor) { 
                    db.Venda.Add(item);
                    db.SaveChanges();
                    cli.totalComprado = cli.totalComprado + item.Valor;
                    db.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    foreach (ItensVenda iv in listaItems)
                    {
                        iv.idVenda = item.id;
                        Produto prod = new Produto();
                        prod = dalprod.SelecionarProdutoID(iv.idProduto.Value);
                        dalprod.DiminuirEstoque(prod);
                        db.ItensVenda.Add(iv);
                        db.SaveChanges();
                    }

                    
                    return true;
                    }
                    else
                    {
                        Decimal ?ult = (cli.limitecredito - cli.totalComprado - item.Valor);
                        ult = ult  * -1;
                        MessageBox.Show("O limite será ultrapassado em "+ult);
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
                return false;
            }

        }
        public bool RealizarCondicional(Condicional item, List<ItensCondicional> listaItems, Cliente cli)
        {
            try
            {
                DALProduto dalprod = new DALProduto();

                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    if (listaItems.Count > 0)
                    {
                        db.Condicional.Add(item);
                        db.SaveChanges();
                        //cli.totalComprado = cli.totalComprado + item.Valor;
                        //db.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                        //db.SaveChanges();
                        foreach (ItensCondicional iv in listaItems)
                        {
                            iv.idCondicional = item.id;
                            Produto prod = new Produto();
                            prod = dalprod.SelecionarProdutoID(iv.idProduto.Value);
                            dalprod.DiminuirEstoque(prod);
                            db.ItensCondicional.Add(iv);
                            db.SaveChanges();
                        }
                        return true;
                    }
                    else
                    {
                        //Decimal? ult = (cli.limitecredito - cli.totalComprado - item.Valor);
                        //ult = ult * -1;
                        //MessageBox.Show("O limite será ultrapassado em " + ult);
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
                return false;
            }

        }

        public void ModificarStatusCondicional(int id)
        {
            try
            {
                Condicional cond = new Condicional();

                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    cond = (from con in db.Condicional where con.id == id select con).FirstOrDefault();
                    cond.status = "Vendido";
                    db.Entry(cond).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                        
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
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
