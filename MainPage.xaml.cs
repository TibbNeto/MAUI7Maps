//using Android.Content.PM;
using Android.Widget;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Graphics.Text;
using Microsoft.Maui.Maps;
using Microsoft.Maui.Maps.Handlers;
#if (ANDROID)
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
#endif

namespace MAUI7Maps
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
                //descript_lbl.Text = "Navegue por conteúdos selecionados com base em seus interesses e comportamentos. Nossa tecnologia aprende com você, destacando aquilo que pode realmente fazer a diferença no seu dia a dia. Desde tendências emergentes até pérolas escondidas, cada clique é uma oportunidade de encontrar algo que você ainda não sabia que precisava";
//            #if (ANDROID)
//            //DETERMINE LOCATION
//            Location location = new Location(-12.843421, 15.760762);
//            //ASSIGN LOCATION AS STARTER FOR MAP, AS WELL AS THE STARTING DISTANCE
//            //AKA MAP SPAN
//            MapSpan mapSpan = new MapSpan(location, 0.01,0.01);
//            //INITIALIZE MAP WITH MAPSPAN
//            Microsoft.Maui.Controls.Maps.Map iMap = new Microsoft.Maui.Controls.Maps.Map(mapSpan);
//            //SET MAP AS CONTENT FOR THE PAGE
//            Content = iMap;
//            //MAP PROPERTIES
//            iMap.MapType = MapType.Street;
//            iMap.IsShowingUser = true;
//            //PINS
//            //SINGLE
//            Pin pin = new Pin()
//            {
//                Location = location,
//                Label = "My Pin Here",
//                Type = PinType.Place,

//            };
//            Pin pin2 = new Pin()
//            {
//                Location = new Location(-12.844369, 15.763534),
//                Label = "Loja de Lembranças",
//                Type = PinType.Place,

//            };
//            Pin pin3 = new Pin()
//            {
//                Location = new Location(-12.845425, 15.763600),
//                Label = "My Pin Here",
//                Type = PinType.Place,
                

//            };
            
//            pin.MarkerClicked += Pin_MarkerClicked;
//            iMap.Pins.Add(pin);
//            iMap.Pins.Add(pin2);
//            iMap.Pins.Add(pin3);

//            //COLLECTION
//            var points = new List<(string name, double lat, double lon)>()
//            {
//                ("Bolinhos Quentinhos", -12.843798, 15.762539),
//                ("Casa do Churrasco", -12.843201, 15.762277),
//                ("Carne Seca", -12.843786, 15.761646)


//            };
//            Pin colectPin = new Pin() 
//            {
                
//            };

//            //var circle = new Circle()
//            //{
//            //    Center = new Location(-12.844493, 15.762954),
//            //    Radius = new Distance(1),
//            //    StrokeColor = Colors.Red,
//            //    FillColor = Colors.Yellow.AddLuminosity(5),
//            //    StrokeWidth = 20,
//            //};
//            //iMap.MapElements.Add(circle);
            
//#endif
        }

        private async void Pin_MarkerClicked(object? sender, PinClickedEventArgs e)
        {
//#if (ANDROID)
            string action = await DisplayActionSheet(string.Empty, "Cancel", null,"Ver Menu", "Visitar", "Especial", "Outros");
            
               //Toast.MakeText(Android.App.Application.Context,"Current Location", ToastLength.Long)?.Show();
  //          #endif

            //throw new NotImplementedException();
        }
    }

}
