using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AddProduct
    {
        public int No { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Quantity { get; set; }
        public int Unitprice { get; set; }
        public int Subtotal { get; set; }
    }
}
