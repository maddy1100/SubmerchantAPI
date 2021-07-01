using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public interface IResponseCodeMaster<T>
    {
        IEnumerable<T> GetAll();
    }
}
