using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage ="enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="enter first address line")]
        [Display(Name="Line 1")]
        public string Line1 { get; set; }
        [Display(Name="Line 2")]
        public string Line2 { get; set; }
        [Display(Name="Line 3")]
        public string Line3 { get; set; }

        [Required(ErrorMessage ="enter city")]
        public string City { get; set; }

        [Required(ErrorMessage ="State")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage ="Enter country")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
