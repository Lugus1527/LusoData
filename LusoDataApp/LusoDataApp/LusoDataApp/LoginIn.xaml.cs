using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LusoDataApp
{
    public partial class LoginIn : ContentPage
    {
        public LoginIn()
        {
            InitializeComponent();


        }

        private async void BackToMainPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void ToAppMainPage(object sender, EventArgs e)
        {
            
            await Navigation.PushModalAsync(new AppMainPage());
        }
    }




}

