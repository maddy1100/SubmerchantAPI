using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public interface IRepository<T> 
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);
        void Insert(T obj);
        void Update(T DBobj, T obj);
        void Delete(Object Id);
        //void Save();        
    }
}
