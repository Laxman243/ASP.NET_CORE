using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameWorkWebApp.Models
{
    public class NorthWindContext : DbContext
    {
        // now here whenever you create an object of NorthwindContext class
        // this costructor will be responsible to create a connection to the your database
        public NorthWindContext() // constructor
            : base("name=NorthwindConnection")
        {
        }
        // after interaction with database it should be interact with table
        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductsTable { get; set; }

    }
}
