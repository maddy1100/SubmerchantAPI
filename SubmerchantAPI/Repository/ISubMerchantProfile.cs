using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public interface ISubMerchantProfile<T>
    {
        IEnumerable<SubMerchantProfile> GetDataById(long Id);

    }
}
