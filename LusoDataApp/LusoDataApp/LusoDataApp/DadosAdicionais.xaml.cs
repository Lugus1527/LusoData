using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LusoDataApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DadosAdicionais : ContentPage
    {
        public DadosAdicionais()
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