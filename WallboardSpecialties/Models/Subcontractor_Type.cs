using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    [Table("Subcontractor_Type")]
    public class Subcontractor_Type
    {
        [Key]
        public int subcontractor_typeID { get; set; }
        public string description { get; set; }
    }
}