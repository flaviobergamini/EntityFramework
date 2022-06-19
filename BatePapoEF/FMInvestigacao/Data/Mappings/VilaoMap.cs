using FMInvestigacao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FMInvestigacao.Data.Mappings{
    class VilaoMap : IEntityTypeConfiguration<Vilao>
    {
        public void Configure(EntityTypeBuilder<Vilao> builder)
        {
            builder.ToTable("Vilao");

            builder.HasKey(x => x.idVilao);
            builder.Property(x => x.idVilao).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.nome)
            .IsRequired()
            .HasColumnName("nome")
            .HasColumnType("VARCHAR")
            .HasMaxLength(45);

            builder.Property(x => x.numCrime)
            .IsRequired()
            .HasColumnName("numCrime")
            .HasColumnType("INT");
        }
    }
}