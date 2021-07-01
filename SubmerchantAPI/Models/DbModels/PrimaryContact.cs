using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models
{
    public class PrimaryContact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PrimaryContactID { get; set; }

        public Guid PublicKey { get; set; }

        [Required]
        [MaxLength(100)]
        public string MerchantName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LegalName { get; set; }

        [Required]
        [MaxLength(20)]
        public string TaxID { get; set; }

        [Required]
        [MaxLength(1)]
        public string ContractType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ApplicationReceivedDate { get; set; }

        public int ? LegalForm { get; set; }

        public int ? CompanyRegistrationNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime ? BusinessStartDate { get; set; }

        [Required]
        [MaxLength(250)]
        public string TradingAddressLine1 { get; set; }

        [Required]
        [MaxLength(20)]
        public string TradingCity { get; set; }

        [MaxLength(20)]
        public string TradingCounty { get; set; }

        [MaxLength(20)]
        public string TradingState { get; set; }

        [MaxLength(10)]
        public string TradingPostalCode { get; set; }

        [MaxLength(20)]
        public string TradingProvince { get; set; }

        [Required]
        [MaxLength(3)]
        public string TradingCountryCode { get; set; }

        [Required]
        [MaxLength(250)]
        public string BillToAddressLine1 { get; set; }

        [Required]
        [MaxLength(50)]
        public string BillToCity { get; set; }

        [MaxLength(20)]
        public string BillToCounty { get; set; }

        [Required]
        [MaxLength(3)]
        public string BillToState { get; set; }

        [MaxLength(10)]
        [DataType(DataType.PostalCode)]
        public string BillToZip { get; set; }

        [MaxLength(20)]
        public string BillToProvince { get; set; }

        [MaxLength(20)]
        public string BillToCountry { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Emailaddress { get; set; }

        [MaxLength(100)]
        public string UKTDAccountHandler { get; set; }

        public int ? TypeOfBusiness { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        [MaxLength(100)]
        public string Nationality { get; set; }

        [DataType(DataType.PhoneNumber)]
        [MaxLength(20)]
        public string MobileTelephone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [MaxLength(20)]
        public string HomeTelephone { get; set; }

        [DataType(DataType.Date)]
        public DateTime ? DateOfBirth { get; set; }

        public int ? NationalInsuranceNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string PersonalEmail { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string BusinessEmail { get; set; }

        public decimal ? PercentageShare { get; set; }
    }
}
