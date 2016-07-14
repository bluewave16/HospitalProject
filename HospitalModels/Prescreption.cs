using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Prescreption
    {
        [Key]
        public int PrescreptionID { get; set; }

        public List<Doctor> doctors { get; set; }
        public List<Patient> patients { get; set; }
        [StringLength(50)]

        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string CaseHostory { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        [StringLength(50)]
        public string Medication { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
