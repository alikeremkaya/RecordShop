using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı.Entities
{
    public class Album:BaseEntity   
    {
        public string AlbumName { get; set; }
        public string Artist { get; set; }

        public DateTime ReleseadDate { get; set; }
        public int Price { get; set; }

        public double Discount { get; set; }

        public bool IsDiscountinued { get; set; }=false;

    }
}
