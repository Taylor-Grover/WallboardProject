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
        public string PhoneNumber { get; set; }

        [Key, Column(Order = 1)]
        public string LastName { get; set; }

        public string FirstName { get; set; }

    }
}