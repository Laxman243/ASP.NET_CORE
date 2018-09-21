namespace CRUDwithMVCUsingEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
       
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int EmpID { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        //[Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MangaerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? join_date { get; set; }
    }
}
