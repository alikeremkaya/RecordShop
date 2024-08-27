using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDükkanı.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı.Configurations
{
    public class AlbumConfiguration:BaseEntityConfiguration<Album>
    {
        public override void Configure(EntityTypeBuilder<Album> builder)
        {

            builder.Property(x => x.AlbumName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Artist).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Price).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ReleseadDate).IsRequired().HasMaxLength(50);
            builder.Property(x => x.IsDiscountinued).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Discount).IsRequired().HasMaxLength(50);

            base.Configure(builder);
        }
    }
}
