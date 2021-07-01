using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class TransactionHistoryRepository : ITransactionHistoryRepository<TransactionHistory>
    {

        readonly SubmerchantDBContext _submerchantDBContext;

        public TransactionHistoryRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }



        public IEnumerable<TransactionHistory> GetAllTransactionHistory()
        {
            List<PrimaryContact> primaryContacts = _submerchantDBContext.PrimaryContacts.ToList();
            List<BankDetails> bankDetails = _submerchantDBContext.BankDetails.ToList();
            List<SubMerchantDetails> subMerchantDetails = _submerchantDBContext.SubmerchantDetails.ToList();
            var result = from p in primaryContacts
                         join s in subMerchantDetails on p.PrimaryContactID equals s.PrimaryContactID
                         join b in bankDetails on p.PrimaryContactID equals b.PrimaryContactID
                         select new TransactionHistory
                         {
                             PrimaryContactID = p.PrimaryContactID,
                             SubMerchantName = p.MerchantName,
                             SubMerchantID = s.SubMerchantID,
                             AccountNumber = b.AccountNumber,
                             Currency = b.ApplicationCurrency,

                             SattlementDay = System.DateTime.Now,
                             PaymentID = 4672456709,
                             FundTransferID = "200",
                             Amount = 6754,
                             FundingInstructionType = "Credit"
                         };

            return result;
        }


        public IEnumerable<TransactionHistory> GetById(object Id)
        {
            List<PrimaryContact> primaryContacts = _submerchantDBContext.PrimaryContacts.ToList();
            List<BankDetails> bankDetails = _submerchantDBContext.BankDetails.ToList();
            List<SubMerchantDetails> subMerchantDetails = _submerchantDBContext.SubmerchantDetails.ToList();
            var result = from p in primaryContacts
                         join s in subMerchantDetails on p.PrimaryContactID equals s.PrimaryContactID
                         join b in bankDetails on p.PrimaryContactID equals b.PrimaryContactID
                         where p.PrimaryContactID == Convert.ToInt64(Id)
                         select new TransactionHistory
                         {
                             PrimaryContactID = p.PrimaryContactID,
                             SubMerchantName = p.MerchantName,
                             SubMerchantID = s.SubMerchantID,
                             AccountNumber = b.AccountNumber,
                             Currency = b.ApplicationCurrency,

                             SattlementDay = System.DateTime.Now,
                             PaymentID = 4672456709,
                             FundTransferID = "200",
                             Amount = 6754,
                             FundingInstructionType = "Credit"
                         };

            return result;
        }
    }
}
