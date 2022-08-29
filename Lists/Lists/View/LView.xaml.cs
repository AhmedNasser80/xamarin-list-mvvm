using Lists.Model;
using Lists.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lists.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LView : ContentPage
    {
        private ProductViewModel ProductsVM=new ProductViewModel();
       
        public LView()
        {
            InitializeComponent();
            
            
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var product = listView.SelectedItem as Product;
             await Navigation.PushAsync(new seleceted(product.Name,product.Description,product.Details,product.image));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            var container = ProductsVM.Products ;
           
            listView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                listView.ItemsSource = container;
            else
            {
                var mini = new List<Product>();
                for(int i = 0; i < container.Count; i++)
                {
                    var item = container[i];
                    if(item.Name.ToLower().Contains(e.NewTextValue.ToLower()))
                        mini.Add(item);    
                }
                listView.ItemsSource = mini;
            }
            listView.EndRefresh();

        }
    }
}