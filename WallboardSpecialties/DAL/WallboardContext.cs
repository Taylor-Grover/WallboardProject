using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WallboardSpecialties.DAL
{
    public class WallboardContext : DbContext
    {
        public WallboardContext() : base("WallboardContext")
        {

        }

        public System.Data.Entity.DbSet<WallboardSpecialties.Models.Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<WallboardSpecialties.Models.Subcontractor> Subcontractors { get; set; }

        public System.Data.Entity.DbSet<WallboardSpecialties.Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<WallboardSpecialties.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<WallboardSpecialties.Models.TimeLog> TimeLogs { get; set; }

        public System.Data.Entity.DbSet<WallboardSpecialties.Models.Job_Type> Job_Type { get; set; }

        public System.Data.Entity.DbSet<WallboardSpecialties.Models.TempEmployee> TempEmployees { get; set; }
    }
}