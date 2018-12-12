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
        [Display(Name = "Clock In Time")]
        public DateTime Clock_In { get; set; }
        [Display(Name = "Clock Out Time")]
        public DateTime Clock_Out { get; set; }
        [Display(Name = "Hours Worked")]
        public double HoursWorked { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int ProjectID { get; set; }
        public int Job_TypeID { get; set; }
        public int SubcontractorID { get; set; }
        public virtual Subcontractor Subcontractor { get; set; }
        public virtual Project Project { get; set; }
        public virtual Job_Type Job_Type { get; set; }
        public virtual TempEmployee TempEmployee { get; set; }
    }
}