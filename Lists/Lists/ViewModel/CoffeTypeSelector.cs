using Lists.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lists.ViewModel
{
    internal class CoffeTypeSelector : DataTemplateSelector
    {
        public DataTemplate Hot { get; set; }
        public DataTemplate Cold { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Coffe = (Product)item;
            return Coffe.Name == "Iced Coffe" ? Cold : Hot;

        }
    }
}
