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
    public class UsuarioMapping : IEntityTypeConfiguration<UsuarioVM>
    {
        public void Configure(EntityTypeBuilder<UsuarioVM> builder)
        {
            builder
                .ToTable(name: "Usuarios", schema: "dbo")
                .HasKey(x => x.UsuarioId);

            builder
                .Property(x => x.UsuarioId)
                .HasColumnName("UsuarioId");

            builder
                .Property(x => x.NomeUsuario)
                .HasColumnName("NomeUsuario")
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.Senha)
                .HasColumnName("Senha")
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.Regra)
                .HasColumnName("Regra");
        }
        
    }
}
