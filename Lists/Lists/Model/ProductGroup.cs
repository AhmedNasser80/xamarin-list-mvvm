using System;
using System.Collections.Generic;
using System.Text;

namespace Lists.Model
{
    public class ProductGroup:List<Product>
    {
        public string Title { get; set; }
        public ProductGroup(string title,List<Product>products):base(products)
        {
            Title = title;
        }
    }
}
