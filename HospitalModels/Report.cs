using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Doctor> doctors { get; set; }
        public virtual List<Patient> patients { get; set; }
    }
}
