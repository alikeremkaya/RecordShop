using PlakDükkanı.DataService.Concrete;
using PlakDükkanı.DataService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı
{
    public class UnitOfWork
    {
        private static UnitOfWork instance;
        public static UnitOfWork Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnitOfWork();
                }
                return instance;

            }
        }
        public IAlbumDataService Albums
        {
            get
            {
                return new AlbumDataService();

            }
        }
    }
    
}
