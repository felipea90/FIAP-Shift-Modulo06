using FiapProduto.Data.Mapping;
using FiapProduto.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapProduto.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DataContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<CategoriaVM> Categorias { get; set; }
        public DbSet<MarcaVM> Marcas { get; set; }
        public DbSet<ProdutoVM> Produtos { get; set; }
        public DbSet<UsuarioVM> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMapping());
            modelBuilder.ApplyConfiguration(new MarcaMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());

        }
    }
}
