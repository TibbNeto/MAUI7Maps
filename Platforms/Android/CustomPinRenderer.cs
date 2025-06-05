using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content.Res;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MAUI7Maps.Platforms.Android
{
    class CustomPinRenderer: Java.Lang.Object, IOnMapReadyCallback
    {
        readonly Microsoft.Maui.Controls.Maps.Map _map;
        private Microsoft.Maui.Maps.IMap map;

        public CustomPinRenderer(Microsoft.Maui.Maps.IMap map)
        {
            this.map = map;
        }

        //CustomPinRenderer(Microsoft.Maui.Controls.Maps.Map map)
        //{
        //    _map = map;
        //}
        public void OnMapReady(GoogleMap googleMap)
        {
            googleMap.Clear();
            foreach (var pin in _map.Pins)
            {
                var markerOptions = new MarkerOptions()
                    .SetPosition(new LatLng(pin.Location.Latitude, pin.Location.Longitude))
                    .SetTitle(pin.Label)
                    .SetSnippet(pin.Address)
                    .SetIcon(BitmapDescriptorFactory.FromAsset("bread.png"));

                googleMap.AddMarker(markerOptions);
            }
        }
    }
}
