using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

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
        public bool RealizarVenda2(Venda item, List<ItensVenda> listaItems, Cliente cli)
        {
            try
            {
                DALProduto dalprod = new DALProduto();

                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    if ((cli.limitecredito - cli.totalComprado) > item.Valor)
                    {
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
                        Decimal? ult = (cli.limitecredito - cli.totalComprado - item.Valor);
                        ult = ult * -1;
                        MessageBox.Show("O limite será ultrapassado em " + ult);
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
                            iv.idCondicional = item.id;//testar isso aqui
                            Produto prod = new Produto();
                            prod = dalprod.SelecionarProdutoID(iv.idProduto.Value);
                            prod.condicional = "Sim";
                            db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                            //dalprod.DiminuirEstoque(prod);
                            db.ItensCondicional.Add(iv);
                            db.SaveChanges();
                        }
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
                return false;
            }

        }

        public void ModificarStatusCondicionalVenda(int id)
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
        public void ModificarStatusCondicional(int id, string status)
        {
            try
            {
                Condicional cond = new Condicional();
                List<ItensCondicional> listaCond = new List<ItensCondicional>();

                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    cond = (from con in db.Condicional where con.id == id select con).FirstOrDefault();
                    cond.status = status;
                    db.Entry(cond).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    listaCond = (from lc in db.ItensCondicional
                        where lc.idCondicional == id
                        select lc).ToList();
                        foreach (ItensCondicional iv in listaCond)
                        {
                            Produto prod = new Produto();
                            prod = new DALProduto().SelecionarProdutoID(iv.idProduto.Value);
                            prod.condicional = "Não";
                            db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                    }

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
        //lista de produtos model
        public List<ProdutoModel> listaProdutosModelsDoCondicional(int idCondicional)
        {
            List<ProdutoModel> lista = new List<ProdutoModel>();
            List<ItensCondicional> listaCond = new List<ItensCondicional>();
            DALProduto objDAL = new DALProduto();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                listaCond = (from lc in db.ItensCondicional
                    where lc.idCondicional == idCondicional
                    select lc).ToList();
                foreach (ItensCondicional ic in listaCond)
                {
                    ProdutoModel prod = new ProdutoModel();
                    prod = DALProduto.SelecionarUmProdutoModel(ic.idProduto);
                    lista.Add(prod);
                    //iv.idVenda = item.id;
                    //Produto prod = new Produto();
                    //prod = dalprod.SelecionarProdutoID(iv.idProduto.Value);
                    //dalprod.DiminuirEstoque(prod);
                    //db.ItensVenda.Add(iv);
                    //db.SaveChanges();
                }
            }

            return lista;
        }
        public List<CondicionalModel> carregarCondicionais()
        {
            List<CondicionalModel> cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                cp = (from c in db.Condicional
                    where c.status == "Pendente"
                    join cli in db.Cliente on c.idCliente equals cli.id
                    join pes in db.Pessoa on cli.idPessoa equals pes.id
                    select new CondicionalModel()
                    {
                        idCondicional = c.id,
                        idCliente = cli.id,
                        NomeCliente = pes.nome,
                        data = c.data,
                        

                          
                    }).ToList();
            }
            return cp;
        }
        public List<CondicionalModel> carregarCondicionaisPorCliente(int id)
        {
            List<CondicionalModel> cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                cp = (from c in db.Condicional
                      join cli in db.Cliente on c.idCliente equals cli.id
                      join pes in db.Pessoa on cli.idPessoa equals pes.id
                      where c.status == "Pendente" && pes.id == id
                    
                    
                    select new CondicionalModel()
                    {
                        idCondicional = c.id,
                        idCliente = cli.id,
                        NomeCliente = pes.nome,
                        data = c.data,



                    }).ToList();
            }
            return cp;
        }
        public static List<CondicionalModel> carregarCondicionaisPorData(DateTime inicio, DateTime fim)
        {
            List<CondicionalModel> cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                cp = (from c in db.Condicional
                    join cli in db.Cliente on c.idCliente equals cli.id
                    join pes in db.Pessoa on cli.idPessoa equals pes.id
                    where c.status == "Pendente" && c.data > inicio && c.data < fim


                    select new CondicionalModel()
                    {
                        idCondicional = c.id,
                        idCliente = cli.id,
                        NomeCliente = pes.nome,
                        data = c.data,



                    }).ToList();
            }
            return cp;
        }
        //public bool validarExisteCondicional(int id)
        //{
        //    List<Condicional> cp;
        //    using (quiteriamodasEntities db = new quiteriamodasEntities())
        //    {
        //        cp = (from c in db.Condicional
        //            where c.status == "Pendente"
        //            join cli in db.Cliente on c.idCliente equals cli.id
        //            join c in db.Condicional on c.id 
        //            join ic in db.ItensCondicional on 
        //            select c).ToList();
        //    }

        //    if (true)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;

        //}
    }
}
