using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDükkanı.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı.Configurations;

public class BaseEntityConfiguration<T>:IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.OlusturmaTarihi).IsRequired();
        builder.Property(x => x.DegisimTarihi).IsRequired(false);
        builder.Property(x => x.SilmeTarihi).IsRequired(false);

    }

}
