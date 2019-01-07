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
        //public int idCliente { get; set; }
        public DateTime? data { get; set; }
        public decimal? valor { get; set; }
        public List<ClienteModel> carregarClientes()
        {
            List<ClienteModel> cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {

                //DateTime ultimo = (from c in db.Cliente select c.DataUltimoPagamento);
                TimeSpan? diferenca;
                
                DateTime agora = DateTime.Now;
                agora = agora.AddDays(-30);
                DateTime agora2 = DateTime.Now;
                agora2 = agora2.AddDays(-7);
                
                int dias = 0; //= diferenca.Days;
                
                cp = (from c in db.Cliente
                      where ((c.DataUltimoPagamento <= agora || c.DataUltimoPagamento == null) && c.totalComprado > 0 && (c.DataUltimaCobranca < agora2 || c.DataUltimaCobranca == null))//&& System.Data.Entity.DbFunctions.TruncateTime(c.DataUltimaCobranca.Value) < agora2)
                      //join pag in db.ClientePagamentos on c.id equals pag.idCliente
                      join p in db.Pessoa on c.idPessoa equals p.id
                      join e in db.Endereco on p.idEndereco equals e.id 
                      //join ven in db.Venda on c.id equals ven.idCliente
                      select new ClienteModel()
                      {
                          //id = c.id,
                          //totalComprado = c.totalComprado,
                          //nome = pes.nome,
                          //dataUltimoPagamento = c.DataUltimoPagamento,
                          //telefone = pes.telefone,



                          nome = p.nome,
                          celular = p.celular,
                          celular2 = p.celular2,
                          CPF = p.CPF,
                          dataNascimento = p.datanascimento.Value,
                          dataUltimoPagamento = c.DataUltimoPagamento.Value,
                          email = p.email,
                          id = p.id,
                          telefone = p.telefone,
                          telefone2 = p.telefone2,
                          limitecredito = c.limitecredito.Value,
                          totalComprado = c.totalComprado.Value,
                          bairro = e.bairro,
                          idEndereco = e.id,
                          numero = e.numero,
                          rua = e.rua,
                          RG = p.RG,
                          CEP = e.CEP,






                      }).ToList();
            }
            return cp;
        }

        public List<DALCobranca> carregarPagamentosPorCliente(int id)
        {
            List<DALCobranca> cp;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                cp = (from c in db.ClientePagamentos
                      //join cli in db.Cliente on c.idCliente equals cli.id
                      //join pes in db.Pessoa on cli.idPessoa equals pes.id
                      where c.idCliente == id

                      select new DALCobranca()
                      {
                         // idCliente = cli.id,
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
