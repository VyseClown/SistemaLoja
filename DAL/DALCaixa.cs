using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALCaixa
    {
        public bool Salvar(Conta item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Conta.Add(item);
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
        public Decimal? calcularContasAPagar()
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                //List<City> lista = new List<City>();
                Decimal? valor = 0;
                List<decimal?> valores = new List<Decimal?>();
                valores = (from e in db.Conta
                         where e.Data >= DateTime.Now
                         select e.Valor).ToList();
                valor = valores.Sum();
                return valor;
            }
        }
        public List<DividaModel> listarDividas()
        {
            List<DividaModel> dividas = new List<DividaModel>();
            using(quiteriamodasEntities db = new quiteriamodasEntities())
            {
                dividas = (from d in db.Conta
                         select new DividaModel()
                         {
                         id = d.id,
                         Nome = d.Nome,
                         Valor = d.Valor,
                         Data = d.Data,
                         Recorrente = d.Recorrente,
                         DataFinal = d.DataFinal,
                         
                         }).ToList();
            }
            return dividas;
        }
        public Conta selecionarConta(int id)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                Conta divida = new Conta();
                divida = (from e in db.Conta
                         where e.id == id
                         select e).FirstOrDefault();
                return divida;
            }
        }
        public bool Alterar(Conta item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Excluir(Conta item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public FluxoCaixa verificarAberturaCaixa()
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                FluxoCaixa Caixa = new FluxoCaixa();
                Caixa = (from e in db.FluxoCaixa
                         where System.Data.Entity.DbFunctions.TruncateTime(DateTime.Now) == System.Data.Entity.DbFunctions.TruncateTime(e.DataAbertura)
                          select e).FirstOrDefault();
                return Caixa;
            }
        }
        public FluxoCaixa verificarFechamento(FluxoCaixa caixa)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                FluxoCaixa Caixa = new FluxoCaixa();
                Caixa = (from e in db.FluxoCaixa
                         where System.Data.Entity.DbFunctions.TruncateTime(caixa.DataFechamento) == System.Data.Entity.DbFunctions.TruncateTime(e.DataAbertura)
                         select e).FirstOrDefault();
                //Caixa.DataFechamento = caixa.DataFechamento;
                //Caixa.ValorFechamento = caixa.ValorFechamento;
                Caixa.Fluxo = Caixa.ValorFechamento - Caixa.ValorAbertura;
                return Caixa;
            }
        }
        public bool AbrirCaixa(FluxoCaixa item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.FluxoCaixa.Add(item);
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
        public bool FecharCaixa(FluxoCaixa item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
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

        public decimal somarBalanco(DateTime inicio, DateTime final)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                decimal fluxo = 0;
                List<decimal?> balanco;
                balanco = (from e in db.FluxoCaixa
                           where System.Data.Entity.DbFunctions.TruncateTime(e.DataFechamento) >= inicio && System.Data.Entity.DbFunctions.TruncateTime(e.DataFechamento) <= final && e.Fluxo != null
                          select e.Fluxo).ToList();
                foreach (decimal item in balanco)
                {
                    fluxo = fluxo + item;
                }
                return fluxo;
            }
        }
    }
}
