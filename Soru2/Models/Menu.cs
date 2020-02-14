using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Soru2.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
    }
}