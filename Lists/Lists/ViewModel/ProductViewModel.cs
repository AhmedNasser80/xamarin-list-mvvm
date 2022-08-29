using Lists.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lists.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private List<Product> _products;

     

        public List<Product> Products
        {
            get { return _products; }
            set { _products = value;
            OnPropertyChanged("Products");
            }
        }

        public ProductViewModel()
        {
            
           Products = getProducts();
            
        }
        private List<Product> getProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                     Name = "Mocca",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("Mocca.png"),
                Quantity=10
                },
                new Product()
                {
                    Name = "Espresso",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("esspresso.jpg"),
                Quantity = 5
                },
                new Product()
                {
                    Name = "Latte",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("Latte.jpg"),
                Quantity = 15
                },
                new Product()
                {
                    Name = "Americano",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("Amrecano.jpg"),
                Quantity = 7
                },
                new Product()
                {
                     Name = "Arabica",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("Arabic.jpg"),
                Quantity = 8
                },
                new Product()
                {
                     Name = "Iced Coffe",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("iced.jpg"),
                Quantity = 15
                },
                new Product()
                {
                     Name = "Iced Coffe",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("iced.jpg"),
                Quantity = 15
                },
                new Product()
                {
                     Name = "Iced Coffe",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("iced.jpg"),
                Quantity = 15
                },
                new Product()
                {
                     Name = "Iced Coffe",
                Description = "mocha is essentially a chocolate-flavored latte.",
                Details = "Save the cheap chocolate syrup for your ice cream. Your homemade mocha coffee should have the good stuff! We recommend anything from Seattle Chocolates and Joe Chocolate Co., both of of which can be found in our Chocolate Collection Gift Box. You might also like our Coffee + Chocolate Tasting Box, which features four freshly roasted coffees and four artisan chocolates. Upgrade to the Deluxe Coffee + Chocolate Tasting Box for eight coffee and chocolate pairings.",
                image = ImageSource.FromFile("iced.jpg"),
                Quantity = 15
                }
              };
          }


        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
       
    }
}
