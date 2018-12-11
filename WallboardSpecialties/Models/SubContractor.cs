using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    public class SubContractor
    {
        //SubContractor Attributes

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