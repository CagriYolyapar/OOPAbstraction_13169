using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstraction_1.Tools
{
    public class Product
    {
        public Product(string productName,decimal unitPrice)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
        }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public override string ToString()
        {
            return $"{ProductName}..Fiyatı => {UnitPrice:C2}";

        }
    }
}
