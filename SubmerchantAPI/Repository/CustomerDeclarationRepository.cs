using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class CustomerDeclarationRepository : IRepository<CustomerDeclaration>
    {

        readonly SubmerchantDBContext _submerchantDBContext;

        public CustomerDeclarationRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }


        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDeclaration> GetAll()
        {
            return _submerchantDBContext.CustomerDeclarations.ToList();
        }

        public CustomerDeclaration GetById(object Id)
        {
            return _submerchantDBContext.CustomerDeclarations.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64( Id));
        }

        public void Insert(CustomerDeclaration obj)
        {
            _submerchantDBContext.CustomerDeclarations.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        public void Update(CustomerDeclaration DBobj, CustomerDeclaration obj)
        {
            DBobj.DateOfSignature = obj.DateOfSignature;
            DBobj.EmailAddress = obj.EmailAddress;
            DBobj.MandatoryProofOfIdentity = obj.MandatoryProofOfIdentity;
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            _submerchantDBContext.SaveChanges();
        }
    }
}
