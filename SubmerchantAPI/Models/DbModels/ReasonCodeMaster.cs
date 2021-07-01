using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubmerchantAPI.Models.DbModels
{
    public class ReasonCodeMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DescID { get; set; }
        public int ReasonCode { get; set; }
        public string Descriptions { get; set; }
    }
}
