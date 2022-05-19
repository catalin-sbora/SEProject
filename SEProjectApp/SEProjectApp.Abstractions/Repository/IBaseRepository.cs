using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.Abstractions.Repository
{
    public interface IBaseRepository<T>
    {
        T GetById(Guid id);
        ICollection<T> GetAll();
        T Add(T element);
        bool Delete(Guid id);
        T Update(T elementToUpdate);
    }
}
