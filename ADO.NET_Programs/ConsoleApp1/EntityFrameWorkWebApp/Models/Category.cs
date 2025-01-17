﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkWebApp.Models
{
    [Table("tblCategories")]
    public class Category
    {
        [Key] // [Key] primary key
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
