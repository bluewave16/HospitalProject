using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [StringLength(50)]
        [Display(Name ="Dapartment Name")]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string DepartmentName { get; set; }
        [Display(Name = "Description Dapartment")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string Description { get; set; }
        public virtual List<Doctor> doctor { get; set; }
        public virtual List<AdmitHistory> admithistory { get; set; }
        public virtual List<Nurses>nurses { get; set; }

             
    }
}
