using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    [Table("TimeLog")]
    public class TimeLog
    {
        [Key]
        public int LogID { get; set; }
        public DateTime Clock_In { get; set; }
        public DateTime Clock_Out { get; set; }
        public double HoursWorked { get; set; }
        public string PhoneNumber { get; set; }
        public string LastName { get; set; }

    }
}