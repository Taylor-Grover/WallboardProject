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
    public class SubContractor
    {
        //SubContractor Attributes
        [Key]
        [DisplayName("Subcontractor ID")]
        public int subcontractorID { get; set; }

        [DisplayName("Name")]
        public string subcontractorName { get; set; }

        [DisplayName("Phone")]
        public string subcontractorPhone { get; set; }

        [DisplayName("Type")]
        public string subcontractorType { get; set; }
    }
}