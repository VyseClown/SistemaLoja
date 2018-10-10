using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class VendaModel
    {
        public int id { get; set; }
        public Nullable<int> idCliente { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<decimal> valorrestante { get; set; }
        public string categoriapagamento { get; set; }
        public Nullable<int> qtdParcelas { get; set; }
       // public string status { get; set; }
    }
}
