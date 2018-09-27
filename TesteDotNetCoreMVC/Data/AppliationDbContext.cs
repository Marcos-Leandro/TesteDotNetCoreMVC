using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDotNetCoreMVC.Models;

namespace TesteDotNetCoreMVC.Data
{
    public class AppliationDbContext : DbContext
    {
        public AppliationDbContext(DbContextOptions<AppliationDbContext> options): base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Produto>().ToTable("Prod");
            modelBuilder.Entity<Produto>().Property(p => p.Nome).HasMaxLength(100);
            //modelBuilder.Entity<Categoria>().ToTable("Cat");
            modelBuilder.Entity<Categoria>().Property(p => p.Nome).HasMaxLength(50);
        }
    }
}
