using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LusoDataApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EcradeRegistro : ContentPage
    {
        public EcradeRegistro()
        {
            InitializeComponent();
        }

        private async void BackToMainPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void ToDadosAdicionais(object sender, EventArgs e)
        {
            InformacoesUtilizador informacoesutilizador = new InformacoesUtilizador()
            {
                Nome = nomeEntry.Text,
                Email = emailEntry.Text,
                Senha = senhaEntry.Text,
                

            };
            


            await Navigation.PushModalAsync(new DadosAdicionais());

        }
    }
}