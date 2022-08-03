using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LusoDataApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }
      

        private async void ToLoginInPage(object sender, EventArgs e)
        {
           
            await Navigation.PushModalAsync(new LoginIn());
        }
        private async void ToSignUpPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EcradeRegistro());
        }
    }

     

    
}
