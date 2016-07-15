using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SimpleProduct.Models
{
    public class SProductDB
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string make { get; set; }

        [Required]
        public string model { get; set; }

        [Required]
        public string year { get; set; }

        [Required]
        public double unitPrice { get; set; }

        [Required]
        public int NumberInStock { get; set; }
    }
}