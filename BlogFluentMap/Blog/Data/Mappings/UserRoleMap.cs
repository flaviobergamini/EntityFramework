using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => x.PK_Role);
            builder.Property(x => x.PK_Role).IsRequired().HasColumnName("PK_Role").HasColumnType("INT");

            builder.HasKey(x => x.UQ_Role_Slug);
            builder.Property(x => x.UQ_Role_Slug).IsRequired().HasColumnName("UQ_Role_Slug").HasColumnType("INT");
        }
    }
}