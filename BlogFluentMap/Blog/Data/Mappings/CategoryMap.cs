using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings{

    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            // Chave Primária
            builder.HasKey(x => x.id);
            //Identity
            builder.Property(x => x.id).ValueGeneratedOnAdd().UseIdentityColumn();

            //atributos da tabela

            builder.Property(x => x.Name)
            .IsRequired().
            HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80); 

            builder.Property(x => x.Slug)
            .IsRequired().
            HasColumnName("Slug")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80); 

        }
    }
}