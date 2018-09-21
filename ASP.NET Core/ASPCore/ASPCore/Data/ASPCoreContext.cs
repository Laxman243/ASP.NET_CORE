using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPCore.Models
{
    public class ASPCoreContext : DbContext
    {
        public ASPCoreContext (DbContextOptions<ASPCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ASPCore.Models.Movie> Movie { get; set; }
    }
}
