using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ebay.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(1,5)]
        public int Stars { get; set; }
        public bool Offer { get; set; }
    }
}
