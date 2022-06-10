using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings{
    class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Title).IsRequired().HasColumnName("Title").HasColumnType("VARCHAR").HasMaxLength(160);
            builder.Property(x => x.Summary).IsRequired().HasColumnName("Summary").HasColumnType("VARCHAR").HasMaxLength(255);
            builder.Property(x => x.Body).IsRequired().HasColumnName("Body").HasColumnType("TEXT");
            builder.Property(x => x.Slug).IsRequired().HasColumnName("Slug").HasColumnType("VARCHAR").HasMaxLength(80);
            builder.Property(x => x.CreateDate).IsRequired().HasColumnName("CreateDate").HasColumnType("DATETIME");
            //builder.Property(x => x.LastUpdateDate).IsRequired().HasColumnName("LastUpdateDate").HasColumnType("SMALLDATETIME").HasDefaultValue(DateTime.Now.ToUniversalTime());
            builder.Property(x => x.LastUpdateDate).IsRequired().HasColumnName("LastUpdateDate").HasColumnType("SMALLDATETIME").HasMaxLength(60).HasDefaultValueSql("GETDATE()");

            // Index
            builder.HasIndex(x => x.Slug, "IX_Post_Slug").IsUnique();

            // Relacionamentos
            //1xN
            builder.HasOne(x => x.Author).WithMany(x => x.Posts).HasConstraintName("FK_Post_Author").OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Category).WithMany(x => x.Posts).HasConstraintName("FK_Post_Category").OnDelete(DeleteBehavior.Cascade);
            //MxN
            builder.HasMany(x => x.Tags).WithMany(x => x.Posts).UsingEntity<Dictionary<string, object>>(
                "PostTag",
                post => post.HasOne<Tag>()
                    .WithMany()
                    .HasForeignKey("PostID")
                    .HasConstraintName("FK_PostTag_PostId")
                    .OnDelete(DeleteBehavior.Cascade),

                tag => tag.HasOne<Post>()
                    .WithMany()
                    .HasForeignKey("TagId")
                    .HasConstraintName("FK_PostTag_TagId")
                    .OnDelete(DeleteBehavior.Cascade)
            );
        }
    }
}