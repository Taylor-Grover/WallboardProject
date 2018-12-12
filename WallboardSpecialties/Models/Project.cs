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
        public int ProjectID { get; set; }

        [DisplayName("Project Description")]
        public string Description { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        public int LocationID { get; set; }

        public virtual Location Location { get; set; }
    }
}