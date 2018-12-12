using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    [Table("Subcontractor")]
    public class Subcontractor
    {
        [Key]
        [DisplayName("Subcontractor ID")]
        public int SubcontractorID { get; set; }

        [DisplayName("Name")]
        public string CompanyName { get; set; }

        [DisplayName("Phone")]
        public string subcontractorPhone { get; set; }

        [DisplayName("Type")]
        public string subcontractorTypeID { get; set; }
    }
}