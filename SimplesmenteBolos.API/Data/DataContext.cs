using Microsoft.EntityFrameworkCore;
using SimplesmenteBolos.API.Models;
using System.Collections.Generic;

namespace SimplesmenteBolos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pedido>()
                .HasMany(p => p.ItensPedido)
                .WithOne(i => i.Pedido);
        }

        public DbSet<ItemPedido> Itens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
