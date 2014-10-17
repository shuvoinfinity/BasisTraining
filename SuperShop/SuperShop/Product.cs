using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop
{
    class Product
    {
        public string ID { get; set; }
        public int Quantity { get; set; }

        public Product(string id, int quantity)
        {
            ID = id;
            Quantity = quantity;
        }
    }
}
