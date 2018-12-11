using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    public class Project
    {
        //Project Attributs
        public int projectID { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Location")]
        public string location { get; set; }

        [DisplayName("Supervisor ID")]
        public string supervisor { get; set; }
    }
}