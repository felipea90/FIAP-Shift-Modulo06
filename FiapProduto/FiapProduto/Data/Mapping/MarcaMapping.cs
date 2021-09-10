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
    public class MarcaMapping : IEntityTypeConfiguration<MarcaVM>
    {
        public void Configure(EntityTypeBuilder<MarcaVM> builder)
        {
            builder
                .ToTable(name: "Marcas", schema: "dbo")
                .HasKey(x => x.MarcaId);

            builder
                .Property(x => x.MarcaId)
                .HasColumnName("MarcaId");

            builder
                .Property(x => x.NomeMarca)
                .HasColumnName("NomeMarca")
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsRequired();

            builder
                .HasMany<ProdutoVM>()
                .WithOne()
                .HasForeignKey(x => x.MarcaId);
        }
    }
}
