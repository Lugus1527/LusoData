using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LusoDataApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            
            MainPage = new NavigationPage(new MainPage());
            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new LoginIn());

            
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
