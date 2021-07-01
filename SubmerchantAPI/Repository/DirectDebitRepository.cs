using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class DirectDebitRepository : IRepository<DirectDebit>
    {

        readonly SubmerchantDBContext _submerchantDBContext;

        public DirectDebitRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DirectDebit> GetAll()
        {
            return _submerchantDBContext.DirectDebits.ToList();
        }

        public DirectDebit GetById(object Id)
        {
            return _submerchantDBContext.DirectDebits.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64(Id));
        }

        public void Insert(DirectDebit obj)
        {
            _submerchantDBContext.DirectDebits.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        public void Update(DirectDebit DBobj, DirectDebit obj)
        {
            //DBobj.PrimaryContactID = obj.PrimaryContactID;
            //DBobj.DirectDebitID = obj.DirectDebitID;

            DBobj.AccountHolderName = obj.AccountHolderName;
            DBobj.BankOrBuildingSocietyAccountNumber = obj.BankOrBuildingSocietyAccountNumber;
           // DBobj.Date = obj.Date;
           
            DBobj.NameOfBank = obj.NameOfBank;
            DBobj.PostalAddress = obj.PostalAddress;
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            DBobj.ReferenceNumber = obj.ReferenceNumber;
            DBobj.SortCode = obj.SortCode;
            _submerchantDBContext.SaveChanges();

        }
    }
}
