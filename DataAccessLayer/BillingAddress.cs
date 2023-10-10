using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class BillingAddress
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Address2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{10}$")]
        public string ContactNo { get; set; }
    }
}
