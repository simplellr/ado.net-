using System.Data.Entity;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1Assignment.Models
{
    public class MyDbContext : DbContext
    {
         
        public MyDbContext()
            : base("name=conn")
        {

        }
        public DbSet<User> Users { get; set; }

    }
}