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
    public class ProdutoMapping : IEntityTypeConfiguration<ProdutoVM>
    {
        public void Configure(EntityTypeBuilder<ProdutoVM> builder)
        {
            builder
                .ToTable(name: "Produtos", schema: "dbo")
                .HasKey(x => x.ProdutoId);

            builder
                .Property(x => x.ProdutoId)
                .HasColumnName("ProdutoId");

            builder
                .Property(x => x.Nome)
                .HasColumnName("NomeProduto")
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.Sku)
                .HasColumnName("SKU")
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.Preco)
                .HasColumnName("Preco");

            builder
                .Property(x => x.DataLancamento)
                .HasColumnName("DataLancamento");

            builder
                .Property(x => x.CategoriaId)
                .HasColumnName("CategoriaId");

            builder
                .Property(x => x.MarcaId)
                .HasColumnName("MarcaId");

            builder
                .HasOne<CategoriaVM>()
                .WithMany()
                .HasForeignKey(x => x.CategoriaId);

            builder
                .HasOne<MarcaVM>()
                .WithMany()
                .HasForeignKey(x => x.MarcaId);
        }
    }
}
