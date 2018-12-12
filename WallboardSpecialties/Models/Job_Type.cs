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
        public string Description { get; set; }
        public double Rate { get; set; }
    }
}