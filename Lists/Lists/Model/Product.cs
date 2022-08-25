using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lists.Model
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ImageSource image { get; set; }
        public string Details { get; set; }
        public int Quantity { get; set; }
    }
}
