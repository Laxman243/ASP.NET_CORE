namespace CRUDwithEF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RDBMSModel : DbContext
    {
        public RDBMSModel()
            : base("name=RDBMSModel")
        {
        }

        public virtual DbSet<tblTrain> tblTrains { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
