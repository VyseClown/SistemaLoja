﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class quiteriamodasEntities : DbContext
    {
        public quiteriamodasEntities()
            : base("name=quiteriamodasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutosPedido> ProdutosPedido { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tamanhos> Tamanhos { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Cor> Cor { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<ContasAPagar> ContasAPagar { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
    }
}