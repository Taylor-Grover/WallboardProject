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
        [Required(ErrorMessage = "Please enter your username")]
        [DisplayName("Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DisplayName("Password")]
        public string password { get; set; }
    }
}