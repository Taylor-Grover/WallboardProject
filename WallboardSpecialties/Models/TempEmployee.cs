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
        [RegularExpression(@"^(\d{3})-?(\d{3})-?(\d{4})$", ErrorMessage = "Phone must me 0000000000 or 000-000-0000")]
        public string PhoneNumber { get; set; }

        [Key, Column(Order = 1)]
        public string LastName { get; set; }

        public string FirstName { get; set; }

    }
}