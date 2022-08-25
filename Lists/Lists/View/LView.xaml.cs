using Lists.Model;
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
        private List<Product> ProductArrayList=new List<Product>();
        public LView()
        {
            InitializeComponent();
            ProductArrayList.Add(new Product
            {
                Name = "Mocca",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("Mocca.png"),
                Quantity=10
            });
            ProductArrayList.Add(new Product
            {
                Name = "Espresso",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("esspresso.jpg"),
                Quantity = 5
            });
            ProductArrayList.Add(new Product
            {
                Name = "Latte",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("Latte.jpg"),
                Quantity = 15
            });
            ProductArrayList.Add(new Product
            {
                Name = "Americano",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("Amrecano.jpg"),
                Quantity = 7
            });
            ProductArrayList.Add(new Product
            {
                Name = "Arabica",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("Arabic.jpg"),
                Quantity = 8
            });
            listView.ItemsSource = ProductArrayList;
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var product = listView.SelectedItem as Product;
             await Navigation.PushAsync(new seleceted(product.Name,product.Description,product.Details,product.image));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var container = ProductArrayList;
           
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