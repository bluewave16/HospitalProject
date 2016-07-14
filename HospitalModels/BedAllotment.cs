using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class BedAllotment
    {
        [Key]
        public int BedID { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        [Display(Name = "Bed Number")]
        public string BedNumber { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        [StringLength(50)]
        public string Ward { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string PatientName { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public DateTime AllotmentDate { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        [DataType(DataType.Date)]
        public DateTime DischargeDate { get; set; }
    }
}
