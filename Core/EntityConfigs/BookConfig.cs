using LibraryManager.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Core.EntityConfigs;

public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(book => book.ID);

        builder.Property<string>(book => book.Title)
            .IsRequired()
            .HasMaxLength(100);

#nullable disable
        builder.Property<string>(book => book.Description)
            .IsRequired(false)
            .HasColumnType("TEXT");

        builder.HasOne(book => book.Author)
            .WithMany(author => author.Books)
            .HasForeignKey(book => book.AuthorID);
    }
}