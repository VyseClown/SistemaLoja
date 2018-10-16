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
                      where ( (TimeSpan.Parse(c.DataUltimoPagamento.ToString()) - TimeSpan.Parse(agora.ToString())).TotalDays > 30)
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

        public List<CondicionalModel> carregarPagamentosPorCliente(int id)
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
    }
}
