using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LandivarApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") //constructor
        {


        }

        public System.Data.Entity.DbSet<LandivarApi.Models.Landivar> Landivars { get; set; }
    }
}