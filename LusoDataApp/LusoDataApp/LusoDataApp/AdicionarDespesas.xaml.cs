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
    public partial class AdicionarDespesas : ContentPage
    {
        public AdicionarDespesas()
        {
            InitializeComponent();
            
        }

        private async void ToAppMain(object sender, EventArgs e)
        {
          
            
            await Navigation.PushModalAsync(new AppMainPage());
        }
    }
}