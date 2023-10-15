using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Congiration
{
    public class S_CardCongiration : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            builder.HasOne<Students>()
             .WithMany()
             .HasForeignKey(x => x.StudentId);

            builder.HasOne<Books>()
              .WithMany()
              .HasForeignKey(x => x.BooksId);

            builder.Property(b => b.DateIn)
           .IsRequired();


            builder.Property(b => b.DateOut)
           .IsRequired();
        }
    }
}
