using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models.DbModels
{
    public class PrincipalOwner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PrincipalOwnerID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [MaxLength(250)]
        public string AddressLine1 { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }


        [MaxLength(20)]
        public string State { get; set; }

        [MaxLength(10)]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [MaxLength(20)]
        public string Province { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(20)]
        public string County { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(250)]
        public string PrincipalEmail { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(250)]
        public string PersonalEmail { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(250)]
        public string BusinessEmail { get; set; }

        [MaxLength(12)]
        public string NationalIdType { get; set; }

        [MaxLength(20)]
        public string NationalIdValue { get; set; }

        [MaxLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string HomeTelephone { get; set; }


        public int ? LengthOfTimeAsPartner { get; set; }

        [MaxLength(50)]
        public string Nationality { get; set; }

        [MaxLength(50)]
        public string NationalInsuranceNumber { get; set; }
        public int ? Principal1Ownership { get; set; }


        // Foreign key   
        [Display(Name = "PrimaryContact")]
        public virtual long PrimaryContactID { get; set; }

        [ForeignKey("PrimaryContactID")]
        public virtual PrimaryContact PrimaryContacts { get; set; }
    }
}
