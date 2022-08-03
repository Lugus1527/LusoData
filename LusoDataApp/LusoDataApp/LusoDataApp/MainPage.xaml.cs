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

        private void ToLoginInPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }

        private void ToSignUpPage(object sender, EventArgs e)
        {
         
        }

    }
}
