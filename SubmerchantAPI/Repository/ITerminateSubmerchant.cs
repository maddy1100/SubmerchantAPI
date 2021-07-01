using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public interface ITerminateSubmerchant<T>
    {
        void Delete(string Id);
        //long GetById(object Id);
        void Insert(T obj);
    }
}
