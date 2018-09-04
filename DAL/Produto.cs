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
    
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            this.ProdutosPedido = new HashSet<ProdutosPedido>();
            this.ItensCondicional = new HashSet<ItensCondicional>();
            this.ItensVenda = new HashSet<ItensVenda>();
        }
    
        public int id { get; set; }
        public Nullable<int> categoriaid { get; set; }
        public Nullable<decimal> preco { get; set; }
        public Nullable<int> marca { get; set; }
        public string descricao { get; set; }
        public string codigodebarra { get; set; }
        public Nullable<int> modelo { get; set; }
        public Nullable<int> tamanho { get; set; }
        public Nullable<decimal> precoCompra { get; set; }
        public string condicional { get; set; }
        public Nullable<int> cor { get; set; }
        public Nullable<int> quantidade { get; set; }
        public Nullable<System.DateTime> data { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Marcas Marcas { get; set; }
        public virtual Modelo Modelo1 { get; set; }
        public virtual Tamanhos Tamanhos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutosPedido> ProdutosPedido { get; set; }
        public virtual Cor Cor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItensCondicional> ItensCondicional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItensVenda> ItensVenda { get; set; }
    }
}
