using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SportsStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage ="enter product name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage ="enter price")]
        [Range(0.01, double.MaxValue, ErrorMessage ="enter positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="enter category")]
        public string Category { get; set; }
    }
}
