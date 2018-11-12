using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClienteModel
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String telefone { get; set; }
        public String telefone2 { get; set; }
        public String CPF { get; set; }
        public String email { get; set; }
        public String celular { get; set; }
        public String celular2 { get; set; }
        public DateTime dataNascimento { get; set; }
        public String RG { get; set; }
        public decimal? limitecredito { get; set; }
        public decimal? totalComprado { get; set; }
        public DateTime? dataUltimoPagamento { get; set; }
        public int idEndereco { get; set; }
        public int idCidade { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public int idEstado { get; set; }
        public String CEP { get; set; }
    }
}
