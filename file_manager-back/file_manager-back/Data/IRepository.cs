using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace file_manager_back.Data
{
    interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        T GetByID(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
