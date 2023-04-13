using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimplesmenteBolos.API.Models;
using System.Text.Json;

namespace SimplesmenteBolos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .Property(e => e.Cliente)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<Cliente>(v, (JsonSerializerOptions)null));

            modelBuilder.Entity<Pedido>()
                .Property(p => p.ItensPedido)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<ItemPedido>>(v, (JsonSerializerOptions)null),
                    new ValueComparer<List<ItemPedido>>(
                        (c1, c2) => c1.SequenceEqual(c2),
                        c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                        c => (List<ItemPedido>)c.ToList()));
        }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
