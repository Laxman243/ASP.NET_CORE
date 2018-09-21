using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkWebApp.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [Key] // primary key
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // how to designate Foreign key

        public Category Category { get; set; }
    }
}
