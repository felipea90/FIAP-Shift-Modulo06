using FiapProduto.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapProduto.Data.Mapping
{
    public class CategoriaMapping : IEntityTypeConfiguration<CategoriaVM>
    {
        public void Configure(EntityTypeBuilder<CategoriaVM> builder)
        {
            builder
                .ToTable(name: "Categorias", schema: "dbo")
                .HasKey(x => x.CategoriaId);

            builder
                .Property(x => x.CategoriaId)
                .HasColumnName("CategoriaId");

            builder
                .Property(x => x.NomeCategoria)
                .HasColumnName("NomeCategoria")
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsRequired();

            builder
                .HasMany<ProdutoVM>()
                .WithOne()
                .HasForeignKey(x => x.CategoriaId);
        }
        
    }
}
