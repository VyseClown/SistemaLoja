using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALCobranca
    {
        public List<ClienteModel> carregarClientes()
        {
            List<ClienteModel> cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                //DateTime ultimo = (from c in db.Cliente select c.DataUltimoPagamento);
                TimeSpan? diferenca;
                
                DateTime? agora = DateTime.Now;
                int dias = 0; //= diferenca.Days;
                
                cp = (from c in db.Cliente
                      where ( (TimeSpan.Parse(c.DataUltimoPagamento.ToString()) - TimeSpan.Parse(agora.ToString())).TotalDays > 30 && c.totalComprado > 0 && TimeSpan.Parse(c.DataUltimaCobranca.ToString()).Days > 7)
                      join pag in db.ClientePagamentos on c.id equals pag.idCliente
                      join pes in db.Pessoa on c.idPessoa equals pes.id
                      join ven in db.Venda on c.id equals ven.idCliente
                      select new ClienteModel()
                      {
                          id = c.id,
                          totalComprado = c.totalComprado,
                          nome = pes.nome,
                          dataUltimoPagamento = DateTime.Parse(c.DataUltimoPagamento.ToString()),
                          telefone = pes.telefone,


                      }).ToList();
            }
            return cp;
        }

        public List<ClientePagamentos> carregarPagamentosPorCliente(int id)
        {
            List<ClientePagamentos> cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                cp = (from c in db.ClientePagamentos
                      join cli in db.Cliente on c.idCliente equals cli.id
                      join pes in db.Pessoa on cli.idPessoa equals pes.id
                      where c.idCliente == id

                      select new ClientePagamentos()
                      {
                          idCliente = cli.id,
                          data = c.data,
                          valor = c.valor,



                      }).ToList();
            }
            return cp;
        }
        public bool realizarCobranca(int idCliente)
        {
            try
            {
                Cliente cli = new Cliente();

                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    cli = (from con in db.Cliente where con.id == idCliente select con).FirstOrDefault();
                    cli.DataUltimaCobranca = DateTime.Now;
                    cli.Pontos = cli.Pontos - 1;
                    db.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;

            }
        }
    }
}
