using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    [Table("Job_Type")]
    public class Job_Type
    {
        [Key]
        public int Job_TypeID { get; set; }
        [Display(Name = "Job Type")]
        public string Description { get; set; }
        [Display(Name = "Pay Rate")]
        public double Rate { get; set; }
    }
}