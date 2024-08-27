using PlakDükkanı.DataService.Interface;
using PlakDükkanı.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı.DataService.Concrete
{
    public class BaseDataService<T> : IBaseDataService<T> where T : BaseEntity
    {
        public T Add(T entity)
        {
            var entry = AppDataBase.Context.Set<T>().Add(entity);

            AppDataBase.Context.SaveChanges();
            return entry.Entity;

        }

        public List<T> GetAll()
        {
            return AppDataBase.Context.Set<T>().Where(x=>x.Status !=Enum.Status.Silindi).ToList();
        }

        public T GetById(Guid id)
        {
            return AppDataBase.Context.Set<T>().FirstOrDefault(x=>x.Id==id&& x.Status != Enum.Status.Silindi);
        }

        public void Remove(Guid id)
        {
           var deletedEntity= GetById(id);
            AppDataBase.Context.Set<T>().Remove(deletedEntity);
            AppDataBase.Context.SaveChanges();

        }

        public T Update(T entity)
        {
           var entry =AppDataBase.Context.Set<T>().Update(entity);
            AppDataBase.Context.SaveChanges();
            return entry.Entity;

        }
    }
}
