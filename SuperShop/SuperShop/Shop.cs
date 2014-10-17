using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public static List<Product> Products;

        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
            Products = new List<Product>();
        }

        public string Add(Product aProduct)
        {
            foreach (Product newProduct in Products)
            {
                if (newProduct.ID == aProduct.ID)
                {
                    newProduct.Quantity += aProduct.Quantity;
                    return "Successfully Added.";
                }
            }
            Products.Add(aProduct);
            return "New Iteam Added.";
        }
    }
}
