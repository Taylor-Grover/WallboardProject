using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.Models
{
    [Table("Project")]
    public class Project
    {
        //Project Attributs
        [Key]
        public int projectID { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Location")]
        public string location { get; set; }

        [DisplayName("Supervisor ID")]
        public string supervisor { get; set; }
    }
}