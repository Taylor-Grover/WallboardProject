using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    [Table("Admin")]
    public class Admin
    {
        //attributes for Admin

        [Key]
        [DisplayName("Username")]
        [Required(ErrorMessage = "Please enter your username")]
        public string username { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter your password")]
        public string password { get; set; }
    }
}