using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public interface ITransactionHistoryRepository<T>
    {
        IEnumerable<TransactionHistory> GetAllTransactionHistory();
        IEnumerable<TransactionHistory> GetById(object Id);
    }
}
