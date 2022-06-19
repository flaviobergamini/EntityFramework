using FMInvestigacao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FMInvestigacao.Data.Mappings{
    class CrimeMap : IEntityTypeConfiguration<Crime>
    {
        public void Configure(EntityTypeBuilder<Crime> builder)
        {

            builder.ToTable("Crime");
            //Criando chave primária
            builder.HasKey(x => x.idCrime);
            builder.Property(x => x.idCrime).ValueGeneratedOnAdd().UseIdentityColumn();
            // Criando os demais atributos da tabela
            builder.Property(x => x.nome)
            .IsRequired()
            .HasColumnName("nome")
            .HasColumnType("VARCHAR")
            .HasMaxLength(45);

            builder.Property(x => x.data)
            .IsRequired()
            .HasColumnName("data")
            .HasColumnType("DATETIME");

            builder.Property(x => x.local)
            .HasColumnName("local")
            .HasColumnType("VARCHAR")
            .HasMaxLength(45);

            builder.Property(x => x.duracao)
            .HasColumnName("duracao")
            .HasColumnType("INT");
            
            // Criando relacionamento 1xN, UM VILÃO PARA MUITOS CRIMES
            builder.HasOne( x => x.Vilao)
            .WithMany(x => x.Crimes)
            .HasConstraintName("FK_Vilao_Crime")
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}