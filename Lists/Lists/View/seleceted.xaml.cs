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
    public partial class seleceted : ContentPage
    {
        public seleceted(string name,string desc,string detail,ImageSource image)
        {
            InitializeComponent();
            
            CaffName.Text = name;
            CaffDesc.Text = desc;
            CaffImage.Source = image;
            CaffDetail.Text = detail;
        }
    }
}