//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProdutosPedido
    {
        public int id { get; set; }
        public Nullable<int> produtoid { get; set; }
        public Nullable<int> pedidoid { get; set; }
        public string tamanhosdesc { get; set; }
        public int qtd { get; set; }
        public decimal precoUnitarioPago { get; set; }
        public decimal precototalpago { get; set; }
        public decimal precounitariovenda { get; set; }
        public decimal precototalvenda { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }
    }
}