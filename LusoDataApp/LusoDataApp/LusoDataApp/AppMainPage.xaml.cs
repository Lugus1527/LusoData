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
        //Grafico Dounut Overview
        private readonly ChartEntry[] overview = new[]
        {
            new ChartEntry(212)
            {
                Label = "Renda",
                ValueLabelColor=SKColor.Parse("#2CA02C"),
                ValueLabel= "112",
                Color = SKColor.Parse("#2CA02C")
            },
            new ChartEntry(128)
            {
                Label = "Alimentação",
                ValueLabelColor=SKColor.Parse("#D62728"),
                ValueLabel = "429",
                Color = SKColor.Parse("#D62728")
            },
            new ChartEntry(514)
            {
                Label = "Combustivel",
                ValueLabelColor=SKColor.Parse("#FF7F0E"),
                ValueLabel = "214",
                Color = SKColor.Parse("#FF7F0E")

            },
            
              new ChartEntry(514)
            {
                Label = "Outras Despesas",
                ValueLabelColor=SKColor.Parse("#535558"),
                ValueLabel = "214",
                Color = SKColor.Parse("#535558")


            },
              new ChartEntry(514)
            {
                Label = "Eletricidade",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "214",
                Color = SKColor.Parse("#1F77B4")


            },
                new ChartEntry(514)
            {
                Label = "Água",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            }



        };
        private readonly ChartEntry[] overviewemlinha = new[]
       {
             new ChartEntry(212)
            {
                Label = "Renda",
                ValueLabelColor=SKColor.Parse("#2CA02C"),
                ValueLabel= "112",
                Color = SKColor.Parse("#2CA02C")
            },
            new ChartEntry(128)
            {
                Label = "Alimentação",
                ValueLabelColor=SKColor.Parse("#D62728"),
                ValueLabel = "429",
                Color = SKColor.Parse("#D62728")
            },
            new ChartEntry(514)
            {
                Label = "Combustivel",
                ValueLabelColor=SKColor.Parse("#FF7F0E"),
                ValueLabel = "214",
                Color = SKColor.Parse("#FF7F0E")

            },

              new ChartEntry(514)
            {
                Label = "Outras Despesas",
                ValueLabelColor=SKColor.Parse("#535558"),
                ValueLabel = "214",
                Color = SKColor.Parse("#535558")


            },
              new ChartEntry(514)
            {
                Label = "Eletricidade",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "214",
                Color = SKColor.Parse("#1F77B4")


            },
                new ChartEntry(514)
            {
                Label = "Água",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            }
        };

        public AppMainPage()
        {
            InitializeComponent();
            chartViewBar.Chart = new DonutChart { Entries = overview, LabelTextSize=30 };
            chartViewBar.Chart = new LineChart { Entries = overview, LabelTextSize = 30 };
        }
       


    }
}