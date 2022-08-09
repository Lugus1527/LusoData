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

        public string Nome
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Senha
        {
            get;
            set;
        }
        public static float Ordenadov
        {
            get;
            set;
        }
        public static float Rendav
        {
            get;
            set;
        }
        public static float Eletricidadev
        {
            get;
            set;
        }
        public static float Aguav
        {
            get;
            set;

        }
        public static float Combustivelv
        {
            get;
            set;
        }
        public static float Alimentacaov
        {
            get;
            set;
        }
        public static float OutrasDespesasv
        {
            get;
            set;
        }
        //Grafico Dounut Overview
        private readonly ChartEntry[] overview = new[]
        {
            new ChartEntry(Rendav)
            {
                Label = "Renda",
                ValueLabelColor=SKColor.Parse("#2CA02C"),
                ValueLabel= "€"+Convert.ToString(Rendav),
                Color = SKColor.Parse("#2CA02C")
            },
            new ChartEntry(Alimentacaov)
            {
                Label = "Alimentação",
                ValueLabelColor=SKColor.Parse("#D62728"),
                ValueLabel = "€"+Convert.ToString(Alimentacaov),
                Color = SKColor.Parse("#D62728")
            },
            new ChartEntry(Combustivelv)
            {
                Label = "Combustivel",
                ValueLabelColor=SKColor.Parse("#FF7F0E"),
                ValueLabel = "€"+Convert.ToString(Combustivelv),
                Color = SKColor.Parse("#FF7F0E")

            },
            
              new ChartEntry(OutrasDespesasv)
            {
                Label = "Outras Despesas",
                ValueLabelColor=SKColor.Parse("#535558"),
                ValueLabel = "€"+Convert.ToString(OutrasDespesasv),
                Color = SKColor.Parse("#535558")


            },
              new ChartEntry(Eletricidadev)
            {
                Label = "Eletricidade",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "€"+Convert.ToString(Eletricidadev),
                Color = SKColor.Parse("#1F77B4")


            },
                new ChartEntry(Aguav)
            {
                Label = "Água",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "€"+Convert.ToString(Aguav),
                Color = SKColor.Parse("#00CFE6")


            }



        };
        private readonly ChartEntry[] alimentacaochart = new[]
       {     new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
             new ChartEntry(150)
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
              new ChartEntry(232)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "50",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(244)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
              

        };
        private readonly ChartEntry[] overview6chart = new[]
       {      new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "1035",
                Color = SKColor.Parse("#00CFE6")


            },
             new ChartEntry(400)
            {
                Label = "Janeiro",
                ValueLabelColor=SKColor.Parse("#2CA02C"),
                ValueLabel= "1032.5",
                Color = SKColor.Parse("#2CA02C")
            },
            new ChartEntry(200)
            {
                Label = "Fevereiro",
                ValueLabelColor=SKColor.Parse("#D62728"),
                ValueLabel = "998",
                Color = SKColor.Parse("#D62728")
            },
            new ChartEntry(214)
            {
                Label = "Março",
                ValueLabelColor=SKColor.Parse("#FF7F0E"),
                ValueLabel = "1100",
                Color = SKColor.Parse("#FF7F0E")

            },

              new ChartEntry(150)
            {
                Label = "Abril",
                ValueLabelColor=SKColor.Parse("#535558"),
                ValueLabel = "950",
                Color = SKColor.Parse("#535558")


            },
              new ChartEntry(50)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "1150",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(214)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "1300",
                Color = SKColor.Parse("#00CFE6")


            },
          

        };
        private readonly ChartEntry[] rendachart = new[]
       {     new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
             new ChartEntry(150)
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
              new ChartEntry(232)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "50",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(244)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },


        };
        private readonly ChartEntry[] combustivelchart = new[]
       {     new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
             new ChartEntry(150)
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
              new ChartEntry(232)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "50",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(244)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },


        };
        private readonly ChartEntry[] outrasdespesaschart = new[]
       {     new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
             new ChartEntry(150)
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
              new ChartEntry(232)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "50",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(244)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },


        };
        private readonly ChartEntry[] aguachart = new[]
       {     new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
             new ChartEntry(150)
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
              new ChartEntry(232)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "50",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(244)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },


        };
        private readonly ChartEntry[] eletricidadechart = new[]
       {     new ChartEntry(214)
            {
                Label = "Dezembro",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },
             new ChartEntry(150)
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
              new ChartEntry(232)
            {
                Label = "Junho",
                ValueLabelColor=SKColor.Parse("#1F77B4"),
                ValueLabel = "50",
                Color = SKColor.Parse("#1F77B4")


            },
              new ChartEntry(244)
            {
                Label = "Julho",
                ValueLabelColor=SKColor.Parse("#00CFE6"),
                ValueLabel = "214",
                Color = SKColor.Parse("#00CFE6")


            },


        };


        public AppMainPage()
        {
            InitializeComponent();
            Overview.Chart = new DonutChart { Entries = overview, LabelTextSize=30 };
            Overview6.Chart = new LineChart { Entries = overview6chart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal, };
            Alimentacao.Chart = new LineChart { Entries = alimentacaochart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal};
            Renda.Chart = new LineChart{ Entries = rendachart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal };
            Eletricidade.Chart = new LineChart{ Entries = eletricidadechart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal};
            Agua.Chart = new LineChart{ Entries = aguachart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal};
            OutrasDespesas.Chart = new LineChart{ Entries = outrasdespesaschart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal };
            Combustivel.Chart = new LineChart{ Entries = combustivelchart, LabelTextSize = 30, LabelOrientation = Orientation.Horizontal };
            
        }

        private async void ToAdicionarDes(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AdicionarDespesas());
        }
    }
}