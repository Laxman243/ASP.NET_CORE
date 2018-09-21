namespace CRUDwithEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTrain
    {
        [Key]
        public int TrainNo { get; set; }

        [Required]
        public string TrainName { get; set; }

        public DateTime Departure { get; set; }

        [Required]
        public string Destination { get; set; }
    }
}
