using LibraryManager.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Core.EntityConfigs;

public class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(author => author.Id);

        builder.Property<string>(author => author.Name)
            .IsRequired()
            .HasMaxLength(100);

#nullable disable
        builder.Property<string>(author => author.Bio)
            .IsRequired(false)
            .HasColumnType("text");
    }
}