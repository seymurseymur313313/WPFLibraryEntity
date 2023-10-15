using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Congiration
{
    public class T_CardCongiration : IEntityTypeConfiguration<T_Cards>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T_Cards> builder)
        {
            builder.HasOne<Books>()
           .WithMany()
           .HasForeignKey(x => x.BookID);

            builder.HasOne<Teacher>()
            .WithMany()
            .HasForeignKey(x => x.TeacherID);

            builder.HasOne<Libs>()
           .WithMany()
           .HasForeignKey(x => x.LibID);

            builder.Property(b => b.DateIn)
             .IsRequired();


            builder.Property(b => b.DateOut)
              .IsRequired();

        }
    }
}
