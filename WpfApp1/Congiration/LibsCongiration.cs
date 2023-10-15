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
    public class LibsCongiration : IEntityTypeConfiguration<Libs>
    {
        public void Configure(EntityTypeBuilder<Libs> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.firstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
