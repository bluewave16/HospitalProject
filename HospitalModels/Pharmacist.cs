﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Pharmacist
    {
        [Key]
        public int PharmacistID { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string LastName { get; set; }
        [StringLength(50)]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter A valid Email Address")]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 50, ErrorMessage = "Password Must be At least 8 Charters long", MinimumLength = 8)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string Password { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please complete this mandatory field")]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
    }
}
