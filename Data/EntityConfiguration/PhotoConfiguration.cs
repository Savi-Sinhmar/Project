using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Domain.Photos;

namespace Data.EntityConfiguration
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.ToTable("Photo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.FileName).HasMaxLength(256).IsRequired();

            builder.HasOne(p => p.Post)
                .WithMany(p => p.Photos)
                .HasForeignKey(p => p.PostId);
        }
    }
}