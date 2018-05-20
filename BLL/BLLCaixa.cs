using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BLL
{
    public class BLLCaixa
    {
        public bool Salvar(Conta item)
        {
            try
            {
                DALCaixa DALobj = new DALCaixa();
                if (DALobj.Salvar(item) == true)
                {
                    DALobj = null;
                    return true;
                }
                else
                {
                    DALobj = null;
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public decimal? calcularContasAPagar()
        {
            Decimal? valor = 0;
            List<decimal?> valores = new List<Decimal?>();
            try
            {
                DALCaixa DALObj = new DALCaixa();

                if ((valor = DALObj.calcularContasAPagar()) != null)
                {
                    return valor;
                }
                else
                    return valor;
            }
            catch (Exception)
            {
                return valor;
            }
        }
        public List<DividaModel> listarDividas()
        {
            List<DividaModel> div = new List<DividaModel>();
            try
            {
                DALCaixa DALObj = new DALCaixa();
                if((div = DALObj.listarDividas()) != null)
                {
                    return div;
                }
                else
                    return null;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public Conta retornarDivida(int id)
        {
            Conta divida = new Conta();
            try
            {
                DALCaixa DALObj = new DALCaixa();
                if ((divida = DALObj.selecionarConta(id)) != null)
                {
                    return divida;
                }
                else
                    return null;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool AlterarConta(Conta cont)
        {
            try
            {
                DALCaixa DALObj = new DALCaixa();
                DALObj.Alterar(cont);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
