using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Patient
    {
        public int PatientID { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string Email { get; set; }
        [StringLength(maximumLength:50,MinimumLength = 8,ErrorMessage ="Enter more than 8 letters")]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(20)]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:D}")]
        public string BirthDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Age { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [StringLength(10)]
        public string BloodGroup { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        public string RelativeNumber { get; set; }
        [MaxLength(255)]
        [DataType(DataType.ImageUrl)]

        public string ImageUrl { get; set; }
        public  List<Doctor> doctor { get; set; }
    }
}
