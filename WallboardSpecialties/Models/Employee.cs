using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    [Table("TempEmployee")]
    public class Employee
    {
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name= "Last Name")]
        public string lastName { get; set; }
        [Key, Column(Order = 0)]
        [Display(Name = "Phone")]
        public string phone { get; set; }
        public string jobType { get; set; }
        public string subcontractor { get; set; }
        public string location { get; set; }
        public string isClockedIn { get; set; }
        public string isClockedOut { get; set; }
        public DateTime timeIN { get; set; }
        public DateTime timeOUT { get; set; }
    }
}