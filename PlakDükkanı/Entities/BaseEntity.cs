using PlakDükkanı.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? DegisimTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public Status Status { get; set; }
    }
}
