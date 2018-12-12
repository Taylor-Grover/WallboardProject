using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    [Table("TempEmployee")]
    public class TempEmployee
    {
        [Key, Column(Order = 0)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string PhoneNumber { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

    }
}