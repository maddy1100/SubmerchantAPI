using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class BankDetailsRepository : IRepository<BankDetails>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public BankDetailsRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }

        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankDetails> GetAll()
        {
            return _submerchantDBContext.BankDetails.ToList();
        }

        public BankDetails GetById(object Id)
        {
            return _submerchantDBContext.BankDetails.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64(Id));
        }

        public void Insert(BankDetails obj)
        {
            _submerchantDBContext.BankDetails.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        public void Update(BankDetails DBobj, BankDetails obj)
        {
            DBobj.AccountNumber = obj.AccountNumber;
            DBobj.ApplicationCurrency = obj.ApplicationCurrency;
            DBobj.SortCode = obj.SortCode;
            DBobj.BranchPostCode = obj.BranchPostCode;
            DBobj.BusinessOrPersonal = obj.BusinessOrPersonal;
            DBobj.NameOfAccount = obj.NameOfAccount;
            DBobj.NameOfBank = obj.NameOfBank;
            DBobj.NatureOfBusiness = obj.NatureOfBusiness;
            DBobj.PrimaryContacts = obj.PrimaryContacts;

            _submerchantDBContext.SaveChanges();
        }
    }
}
