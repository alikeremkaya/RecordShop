using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı.VMS
{
    public class AlbumVM
    {
        public Guid Id { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }

        public DateTime ReleseadDate { get; set; }
        public int Price { get; set; }

        public double Discount { get; set; }

        public bool IsDiscountinued { get; set; } = false;

    }
}
