using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using WpfApp1.Model;

namespace WpfApp1.Congiration
{
    public class BooksCongiration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.Pages)
                .IsRequired();

            builder.Property(b => b.YearPress)
              .IsRequired()
              .HasMaxLength(30);

            builder.Property(b => b.Comment)
              .HasDefaultValue("Comment Netu")
              .HasMaxLength(500);

            builder.Property(b => b.Quantity)
            .HasDefaultValue("Not Quantity")
            .HasMaxLength(850);

            builder.HasOne<Themes>()
            .WithMany()
            .HasForeignKey(x => x.ThemesID);

            builder.HasOne<Category>()
           .WithMany()
           .HasForeignKey(x => x.CategoryID);

            builder.HasOne<Authors>()
           .WithMany()
           .HasForeignKey(x => x.AuthorID);

            builder.HasOne<Press>()
           .WithMany()
           .HasForeignKey(x => x.PressID);

        }
    }
}
