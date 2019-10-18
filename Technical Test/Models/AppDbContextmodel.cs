using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Technical_Test.Models
{
    public class AppDbContextmodel : DbContext
    {
        public AppDbContextmodel() : base("ConnSQL")
        {

        }
        public DbSet<Labour> labour { get; set; }
    }
}