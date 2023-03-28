using Microsoft.EntityFrameworkCore;
using SimplesmenteBolos.API.Models;
using System.Collections.Generic;

namespace SimplesmenteBolos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Bolo> Bolos { get; set; }
    }
}
