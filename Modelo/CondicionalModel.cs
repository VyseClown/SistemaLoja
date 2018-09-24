using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CondicionalModel
    {
        public int idCliente { get; set; }
        public string NomeCliente { get; set; }
        public DateTime ?data { get; set; }
        public int idCondicional { get; set; }
        
    }
}
