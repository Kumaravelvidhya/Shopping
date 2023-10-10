using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Commonview
    {
        public BillingAddress BillingCreate { get; set; }

        public ShippingAddress ShippingCreate { get; set; }

        public AddProduct AddProduct { get; set; }
    }
}
