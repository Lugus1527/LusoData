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
            new ChartEntry(350)
            {
                Label = "Renda",
                ValueLabelColor=SKColor.Parse("#2CA02C"),
                ValueLabel= "€350",
                Color = SKColor.Parse("#2CA02C")
            },
            new ChartEntry(128)
            {
                Label = "Alimentação",
                ValueLabelColor=SKColor.Parse("#D62728"),
                ValueLabel = "€250",
                Color = SKColor.Parse("#D62728")
            },
            new ChartEntry(150)
            {
                Label = "Combustivel",
                ValueLabelColor=SKColor.Parse("#FF7F0E"),
                ValueLabel = "€150",
                Color = SKColor.Parse("#FF7F0E")

            },
            
              new ChartEntry(214)
            {
                Label = "Outras Despesas",
                ValueLabelColor=SKColor.Parse("#535558"),
                ValueLabel = "€214",
                Color = SKColor.Parse("#535558")


            },
              new ChartEntry(50)
            {
                Label = "Eletricidade",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "€50",
                Color = SKColor.Parse("#1F77B4")


            },
                new ChartEntry(10)
            {
                Label = "Água",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "€10",
                Color = SKColor.Parse("#00CFE6")


            }



        };
        private readonly ChartEntry[] alimentacaochart = new[]
       {
             new ChartEntry(400)
            {
                Label = "Janeiro",
                ValueLabelColor=SKColor.Parse("#2CA02C"),
                ValueLabel= "400",
                Color = SKColor.Parse("#2CA02C")
            },
            new ChartEntry(200)
            {
                Label = "Fevereiro",
                ValueLabelColor=SKColor.Parse("#D62728"),
                ValueLabel = "200",
                Color = SKColor.Parse("#D62728")
            },
            new ChartEntry(214)
            {
                Label = "Março",
             
                ValueLabelColor=SKColor.Parse("#FF7F0E"),
                ValueLabel = "214",
                Color = SKColor.Parse("#FF7F0E")

            },

              new ChartEntry(150)
            {
                Label = "Abril",
                ValueLabelColor=SKColor.Parse("#535558"),
                ValueLabel = "150",
                Color = SKColor.Parse("#535558")


            },
              new ChartEntry(50)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "50",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(214)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              new ChartEntry(214)
            {
                Label = "Agosto",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              new ChartEntry(214)
            {
                Label = "Setembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              new ChartEntry(214)
            {
                Label = "Outubro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              new ChartEntry(214)
            {
                Label = "Novembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
               new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },

        };
        private readonly ChartEntry[] eletricidadechart = new[]
       {
             new ChartEntry(400)
            {
                Label = "Janeiro",
                ValueLabelColor=SKColor.Parse("#2CA02C"),
                ValueLabel= "400",
                Color = SKColor.Parse("#2CA02C")
            },
            new ChartEntry(200)
            {
                Label = "Fevereiro",
                ValueLabelColor=SKColor.Parse("#D62728"),
                ValueLabel = "200",
                Color = SKColor.Parse("#D62728")
            },
            new ChartEntry(214)
            {
                Label = "Março",

                ValueLabelColor=SKColor.Parse("#FF7F0E"),
                ValueLabel = "214",
                Color = SKColor.Parse("#FF7F0E")

            },

              new ChartEntry(150)
            {
                Label = "Abril",
                ValueLabelColor=SKColor.Parse("#535558"),
                ValueLabel = "150",
                Color = SKColor.Parse("#535558")


            },
              new ChartEntry(50)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "50",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(214)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              new ChartEntry(214)
            {
                Label = "Agosto",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              new ChartEntry(214)
            {
                Label = "Setembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              new ChartEntry(214)
            {
                Label = "Outubro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              new ChartEntry(214)
            {
                Label = "Novembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
               new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")
                   


            },

        };

        public AppMainPage()
        {
            InitializeComponent();
            Overview.Chart = new DonutChart { Entries = overview, LabelTextSize=30 };
            Alimentacao.Chart = new LineChart { Entries = alimentacaochart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal};
            Eletricidade.Chart = new LineChart { Entries = eletricidadechart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal };
           
        }
       


    }
}