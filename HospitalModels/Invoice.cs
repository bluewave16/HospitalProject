using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string Title { get; set; }
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string PatientName { get; set; }
        [DataType(DataType.Date)]
        public string Date { get; set; }
        [Required(ErrorMessage = "Please complete this mandatory field")]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
