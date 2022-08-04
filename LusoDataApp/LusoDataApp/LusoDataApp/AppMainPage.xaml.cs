using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace LusoDataApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppMainPage : TabbedPage
    {

        private readonly ChartEntry[] entries = new[]
        {
            new ChartEntry(212)
            {
                Label = "Android",
                ValueLabel= "112",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(128)
            {
                Label = "iOS",
                ValueLabel = "429",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(514)
            {
                Label = "Forms",
                ValueLabel = "214",
                Color = SKColor.Parse("#3498db")


            }



        };
        public AppMainPage()
        {
            InitializeComponent();
            chartViewBar.Chart = new DonutChart { Entries = entries };
        }
       


    }
}