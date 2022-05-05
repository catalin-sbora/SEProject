using SEProjectApp.Abstractions.Repository;
using SEProjectApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataAccess
{
    public class BaseRepository<T> : IBaseRepository<T>  where T : EntityClass
    {
        protected readonly SEProjectAppDbContext dbContext;
        public BaseRepository(SEProjectAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public T Add(T element)
        {
            var returnEntity = dbContext.Set<T>().Add(element)
                                     .Entity;
            dbContext.SaveChanges();

            return returnEntity;
        }

        public bool Delete(Guid id)
        {
            var itemToRemove = GetById(id);
            if (itemToRemove != null)
            {
                dbContext.Set<T>().Remove(itemToRemove);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    

        public virtual ICollection<T> GetAll()
        {
            return dbContext.Set<T>()
                            .ToList();                                     
        }

        public T GetById(Guid id)
        {
           return dbContext.Set<T>()
                            .Single(entity => entity.Id == id);
        }

        public T Update(T elementToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
