using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DividaModel
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? Data { get; set; }
        public string Recorrente { get; set; }
        public DateTime? DataFinal { get; set; }
    }
}
