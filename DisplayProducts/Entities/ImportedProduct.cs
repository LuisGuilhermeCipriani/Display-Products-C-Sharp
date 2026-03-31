using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayProducts.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {}

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomsFee = customFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag();
        }

        public double TotalPrice()
        {

        }
    }
}
