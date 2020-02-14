using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Soru2.Models
{
    public class MenuDbContext   :DbContext
    {
        public MenuDbContext() : base("MenuDb")
        {        
        }

        public DbSet<Menu> Menus { get; set; }
    }
}