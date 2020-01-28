using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto: DbContext
    {
        
        // tudo que está no plural será o nome das tabelas dentro do banco de dados
        // DbSets criados 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormasPagamentos { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        //sobreEscrevendo o model builder 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de Mapeamento aqui... 
            modelBuilder.ApplyConfiguration (new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
