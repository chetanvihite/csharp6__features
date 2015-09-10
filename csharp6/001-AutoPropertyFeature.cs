using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6
{

    public sealed class Order
    {
        public Order()
        {
            OrderNumber = 123;
        }
        //read-only property
        public int OrderNumber { get; }
        public string OrderType { get; set; } = "ECommerceOrder";
    }
}
