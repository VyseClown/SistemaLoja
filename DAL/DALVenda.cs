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
                    if(item.idCategoriaPagamento != 2)
                        cli.totalComprado = cli.totalComprado + item.Valor;
                    cli.totalComprado = cli.totalComprado;
                        cli.Pontos = cli.Pontos + 20;
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
        public static int SelecionarCodTipoPagamento(string descricao)
        {
            //var obj = new categoria();
            CategoriaPagamento obj;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from c in db.CategoriaPagamento
                       where c.nome.Contains(descricao)
                       orderby c.nome
                       select c).FirstOrDefault();
            }

            return obj?.id ?? 0;
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
        public List<VendaModel> carregarVendasCliente(int id)
        {
            List<VendaModel> vm;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                vm = (from v in db.Venda
                    join cli in db.Cliente on v.idCliente equals cli.id
                    join pes in db.Pessoa on cli.idPessoa equals pes.id
                    join cp in db.CategoriaPagamento on v.idCategoriaPagamento equals cp.id
                    where pes.id == id && v.valorrestante > 0


                    select new VendaModel()
                    {
                        id = v.id,
                        idCliente = cli.id,
                        Valor = v.Valor,
                        valorrestante = v.valorrestante,
                        data = v.data,
                        qtdParcelas = v.qtdParcelas,
                        categoriapagamento = cp.nome,

                    }).ToList();
            }
            return vm;
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

        public bool RealizarPagamento(int idVenda, int idCliente, decimal valorRestante, decimal valorPagamento)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                Venda v = new Venda();
                Cliente c = new Cliente();
                ClientePagamentos cp = new ClientePagamentos();

                v = (from ven in db.Venda where ven.id == idVenda select ven).FirstOrDefault();
                decimal ?resto = valorRestante - valorPagamento;
                cp.data = DateTime.Now;
                cp.valor = valorPagamento;
                cp.idCliente = idCliente;
                if (resto < 0)
                {
                    Venda vaux = new Venda();
                    
                    v.valorrestante = 0;
                    while (resto < 0)
                    {
                        vaux = (from vend in db.Venda
                            where vend.idCliente == idCliente && vend.valorrestante > 0
                            select vend).FirstOrDefault();
                        vaux.valorrestante = vaux.valorrestante - (resto * -1);
                        resto = vaux.valorrestante;
                        if (resto < 0)
                        {
                            vaux.valorrestante = 0;
                        }
                        db.Entry(vaux).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                                               
                        c = (from cli in db.Cliente where cli.id == idCliente select cli).FirstOrDefault();
                        c.Pontos = c.Pontos + 2;
                        c.DataUltimoPagamento = cp.data;
                        //c.totalComprado = c.totalComprado - resto;
                        db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        db.ClientePagamentos.Add(cp);
                        db.SaveChanges();
                    }
                }
                else { 
                    v.valorrestante = v.valorrestante - valorPagamento;
                    db.Entry(v).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    c = (from cli in db.Cliente where cli.id == idCliente select cli).FirstOrDefault();
                    c.Pontos = c.Pontos + 2;
                    c.DataUltimoPagamento = cp.data;
                    db.Entry(c).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    db.ClientePagamentos.Add(cp);
                    db.SaveChanges();
                }
                return true;
            }

            
        }
        public bool RealizarPagamentoComTroco(int idVenda, int idCliente, decimal valorRestante, decimal valorPagamento)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                Venda v = new Venda();
                Cliente c = new Cliente();
                ClientePagamentos cp = new ClientePagamentos();
                cp.data = DateTime.Now;
                
                cp.idCliente = idCliente;
                v = (from ven in db.Venda where ven.id == idVenda select ven).FirstOrDefault();
                decimal? resto = valorRestante - valorPagamento;
                cp.valor = valorPagamento;
                v.valorrestante = v.valorrestante - valorPagamento;
                    db.Entry(v).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                c = (from cli in db.Cliente where cli.id == idCliente select cli).FirstOrDefault();
                c.Pontos = c.Pontos + 2;
                db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                db.ClientePagamentos.Add(cp);
                db.SaveChanges();

                return true;
            }


        }
        public static List<ClienteModel> carregarClientesParaCondicional()
        {
            List<ClienteModel> cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())//timespan não funcionou dentro da query, mudar isso
            {
                cp = (from p in db.Pessoa
                      
                      join cli in db.Cliente on p.id equals cli.idPessoa
                      join pag in db.ClientePagamentos on cli.id equals pag.idCliente
                      join comp in db.Venda on cli.id equals comp.idCliente
                      join e in db.Endereco on p.idEndereco equals e.id
                      join c in db.City on e.idCidade equals c.Id
                      join s in db.State on c.IdState equals s.Id
                      //where (TimeSpan.Parse(DateTime.Now.ToString()) - TimeSpan.Parse(cli.DataUltimoPagamento.ToString())).TotalDays < 30 && cli.Pontos > 20 && cli.limitecredito > 1000
                      
                      //where (System.Data.Entity.SqlServer.SqlFunctions.DateDiff(Day,DateTime.Now,(cli.DataUltimoPagamento))) < 30 && cli.Pontos > 20 && cli.limitecredito > 1000
                      
                      where cli.Pontos > 20 && cli.limitecredito > 1000
                      select new ClienteModel()
                      {
                          nome = p.nome,
                          celular = p.celular,
                          celular2 = p.celular2,
                          CPF = p.CPF,
                          dataNascimento = p.datanascimento.Value,
                          dataUltimoPagamento = cli.DataUltimoPagamento.Value,
                          email = p.email,
                          id = p.id,
                          telefone = p.telefone,
                          telefone2 = p.telefone2,
                          limitecredito = cli.limitecredito.Value,
                          totalComprado = cli.totalComprado.Value,
                          bairro = e.bairro,
                          idCidade = c.Id,
                          idEndereco = e.id,
                          numero = e.numero,
                          rua = e.rua,
                          idEstado = s.Id,
                          RG = p.RG,
                          CEP = e.CEP,
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
