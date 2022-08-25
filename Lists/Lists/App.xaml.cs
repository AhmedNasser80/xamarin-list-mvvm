using Lists.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lists
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new  LView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
