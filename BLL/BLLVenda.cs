using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLVenda
    {
        public bool Salvar(CategoriaPagamento item)
        {
            try
            {
                DALVenda DALobj = new DALVenda();
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
    }
}
