using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings {
    public class PostTagMap : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.HasKey(x => x.TagId);
            builder.Property(x => x.TagId).IsRequired().HasColumnName("TagId").HasColumnType("INT");

            builder.HasKey(x => x.PostId);
            builder.Property(x => x.PostId).IsRequired().HasColumnName("PostId").HasColumnType("INT");
        }
    }
}