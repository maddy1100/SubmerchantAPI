using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public interface ISearchRepository<T>
    {
        IEnumerable<SearchModel> Serach(string serachTerm);
        IEnumerable<SearchModel> GetAll();

        IEnumerable<SearchModel> AdvanceSearch(SearchModel serachTerm);

    }
}
