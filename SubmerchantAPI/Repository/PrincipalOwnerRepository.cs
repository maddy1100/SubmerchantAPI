using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class PrincipalOwnerRepository : IRepository<PrincipalOwner>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public PrincipalOwnerRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PrincipalOwner> GetAll()
        {
            return _submerchantDBContext.PrincipalOwners.ToList();
        }

        public PrincipalOwner GetById(object Id)
        {
            return _submerchantDBContext.PrincipalOwners.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64(Id));
        }

        public void Insert(PrincipalOwner obj)
        {
            _submerchantDBContext.PrincipalOwners.Add(obj);
            _submerchantDBContext.SaveChanges();
        }


        public void Update(PrincipalOwner DBobj, PrincipalOwner obj)
        {
            DBobj.FirstName = obj.FirstName;
            DBobj.LastName = obj.LastName;
            DBobj.DOB = obj.DOB;
            DBobj.AddressLine1 = obj.AddressLine1;
            DBobj.City = obj.City;
            DBobj.Country = obj.Country;
            DBobj.County = obj.County;
            DBobj.State = obj.State;
            DBobj.PostalCode = obj.PostalCode;
            DBobj.Province = obj.Province;
            DBobj.PrincipalEmail = obj.PrincipalEmail;
            DBobj.HomeTelephone = obj.HomeTelephone;
            DBobj.LengthOfTimeAsPartner = obj.LengthOfTimeAsPartner;
            DBobj.NationalIdType = obj.NationalIdType;
            DBobj.NationalIdValue = obj.NationalIdValue;
            DBobj.NationalInsuranceNumber = obj.NationalInsuranceNumber;
            DBobj.Nationality = obj.Nationality;
            DBobj.PersonalEmail = obj.PersonalEmail;
            DBobj.BusinessEmail = obj.BusinessEmail;
            DBobj.Phone = obj.Phone;
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            DBobj.Principal1Ownership = obj.Principal1Ownership;
            _submerchantDBContext.SaveChanges();

        }
    }
}
