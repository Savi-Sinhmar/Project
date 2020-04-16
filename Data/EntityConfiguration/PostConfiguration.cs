using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Domain.Posts;

namespace Data.EntityConfiguration
{
    public class PostConfiguration: IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Content).HasMaxLength(5000).IsRequired();

            builder.Property(p => p.CreatedById).HasMaxLength(450).IsRequired();

            builder.HasOne(p => p.CreatedBy)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.CreatedById);

        }
    }
}