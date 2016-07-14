using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Blooddoner
    {
        [Key]
        public int DonerID { get; set; }
        [Display(Name = "Patient Name")]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string NamePatient { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string BloodGroup { get; set; }
        [StringLength(20)]
        public string Gender { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public int Age { get; set; }
        [DisplayFormat(DataFormatString = "{0:D}")]
        [Display(Name = "Last Donation Date")]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public DateTime LastDate { get; set; }
    }
}
