using PlakDükkanı.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı
{
    public class AppDataBase
    {
        private static LoginDbContext context;

        public static LoginDbContext Context
        {




            get
            {
                if (context == null)
                {
                    context = new LoginDbContext();

                }
                return context;
            }
        }
    }
}
