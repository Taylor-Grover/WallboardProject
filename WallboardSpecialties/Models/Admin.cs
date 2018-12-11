using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    public class Admin
    {
        //attributes for Admin

        [Required(ErrorMessage = "Please enter your username")]
        [DisplayName("Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DisplayName("Password")]
        public string password { get; set; }
    }
}