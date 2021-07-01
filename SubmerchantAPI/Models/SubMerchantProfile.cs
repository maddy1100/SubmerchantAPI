using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models
{
    public class SubMerchantProfile
    {
        public long PrimaryContactID { get; set; }
        public string SubMerchantID { get; set; }
        public string MerchantName { get; set; }
        public string LegalName { get; set; }
        public int? CompanyRegistrationNumber { get; set; }
        public int? ApplicationStatus { get; set; }
        public DateTime ApplicationReceivedDate { get; set; }
        public string createdBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }


    }
}
