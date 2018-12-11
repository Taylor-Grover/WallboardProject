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
    }
}