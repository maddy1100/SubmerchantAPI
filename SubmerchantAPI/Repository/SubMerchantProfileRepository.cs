using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class SubMerchantProfileRepository : ISubMerchantProfile<SubMerchantProfile>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public SubMerchantProfileRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public IEnumerable<SubMerchantProfile> GetDataById(long Id)
        {
            List<PrimaryContact> primaryContacts = _submerchantDBContext.PrimaryContacts.ToList();
            List<SubMerchantDetails> subMerchantDetails = _submerchantDBContext.SubmerchantDetails.ToList();

            var result = from p in primaryContacts
                         join s in subMerchantDetails
                         on p.PrimaryContactID equals s.PrimaryContactID into pGroup
                         from s in pGroup.DefaultIfEmpty()
                         where (p.PrimaryContactID == Id)

                         select new SubMerchantProfile
                         {
                             PrimaryContactID = p.PrimaryContactID,
                             CompanyRegistrationNumber = p.CompanyRegistrationNumber,
                             LegalName = p.LegalName,
                             MerchantName = p.MerchantName,
                             ApplicationReceivedDate = p.ApplicationReceivedDate,
                             SubMerchantID = s == null ? null : s.SubMerchantID,
                             ApplicationStatus = s == null ? 0 : s.ApplicationStatus,

                             createdBy = "Admin",
                             LastModifiedDate = DateTime.Now

                         };

            return result;

        }
    }
}
