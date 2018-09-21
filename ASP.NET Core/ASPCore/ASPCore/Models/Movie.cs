using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASPCore.Models
{
    public class Movie
    {
        public int  Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
