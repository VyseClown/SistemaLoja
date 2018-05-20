using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProdutoModel
    {
        public int id { get; set; }
        public string tamanho { get; set; }
        public decimal preco { get; set; }
        public string marca { get; set; }
        public int quantidade { get; set; }
        public string cor { get; set; }
        public string modelo { get; set; }
        public string categoria { get; set; }
        //public string descricao { get; set; }
        public DateTime data { get; set; }
        public string condicional { get; set; }
        public string codigodebarra { get; set; }       
    }
}
