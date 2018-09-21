namespace CRUDwithMVCUsingEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RDMSDBModel : DbContext
    {
        public RDMSDBModel()
            : base("name=RDMSDBModel")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.FullName)
                .IsUnicode(false);
        }
    }
}
