using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:D}")]
        public DateTime Date { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Time { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string PatientName { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string DoctorName { get; set; }

    }
}
