using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class OperationHistory
    {
        [Key]
        public int OperationID { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public virtual List<Doctor> doctors { get; set; }

        public virtual List<Patient> patient { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:D}")]
        public DateTime Date { get; set; }

    }
}
