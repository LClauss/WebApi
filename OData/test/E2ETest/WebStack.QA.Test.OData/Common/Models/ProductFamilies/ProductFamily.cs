﻿using System.Collections.Generic;

namespace WebStack.QA.Test.OData.Common.Models.ProductFamilies
{
    public class ProductFamily
    {
        public ProductFamily()
        {
            Products = new List<Product>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long LongProperty { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
