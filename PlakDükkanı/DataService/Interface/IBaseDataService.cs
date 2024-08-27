using PlakDükkanı.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı.DataService.Interface
{
    public interface IBaseDataService<T> where T : BaseEntity
    {
        T GetById(Guid id);
        T Add(T entity);
        T Update(T entity);
        void Remove(Guid id);

        List<T> GetAll();





    }
}
