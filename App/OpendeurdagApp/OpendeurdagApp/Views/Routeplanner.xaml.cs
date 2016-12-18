

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Appointments;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OpendeurdagApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Routeplanner : Page
    {
        public Routeplanner()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            ShowRouteOnMap2();
        }

        public static Rect GetElementRect(FrameworkElement element)
        {
            GeneralTransform buttonTransform = element.TransformToVisual(null);
            Point point = buttonTransform.TransformPoint(new Point());
            return new Rect(point, new Size(element.ActualWidth, element.ActualHeight));
        }



        private async void ShowRouteOnMap2()
        {
            // Request permission to access location
            var accessStatus = await Geolocator.RequestAccessAsync();

            switch (accessStatus)
            {
                case GeolocationAccessStatus.Allowed:


                    // If DesiredAccuracy or DesiredAccuracyInMeters are not set (or value is                       0), DesiredAccuracy.Default is used.
                    Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = 100 };

                    // Carry out the operation
                    Geoposition startPosition = await geolocator.GetGeopositionAsync().AsTask();

                    // End at the city of Seattle, Washington.
                    BasicGeoposition endLocation = new BasicGeoposition() { Latitude = 51.050460, Longitude = 3.703510 };

                    BasicGeoposition gep = new BasicGeoposition();
                    gep.Latitude = startPosition.Coordinate.Latitude;
                    gep.Longitude = startPosition.Coordinate.Longitude;
                    Geopoint gp1 = new Geopoint(gep);
                    Geopoint gp2 = new Geopoint(endLocation);


                    // Get the route between the points.
                    MapRouteFinderResult routeResult =
                          await MapRouteFinder.GetDrivingRouteAsync(
                          gp1,
                          gp2,
                          MapRouteOptimization.Time,
                          MapRouteRestrictions.None);

                    // Create a MapIcon.
                    MapIcon mapIcon1 = new MapIcon();
                    mapIcon1.Location = gp1;
                    mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
                    mapIcon1.Title = "Start Location";
                    mapIcon1.ZIndex = 0;
                    // Add the MapIcon to the map.
                    MyMap.MapElements.Add(mapIcon1);

                    MapIcon mapIcon2 = new MapIcon();
                    mapIcon2.Location = gp2;
                    mapIcon2.NormalizedAnchorPoint = new Point(0.5, 1.0);
                    mapIcon2.Title = "Somewhere over the ............";
                    mapIcon1.ZIndex = 0;
                    MyMap.MapElements.Add(mapIcon2);





                    if (routeResult.Status == MapRouteFinderStatus.Success)
                    {
                        // Use the route to initialize a MapRouteView.
                        MapRouteView viewOfRoute = new MapRouteView(routeResult.Route);
                        viewOfRoute.RouteColor = Colors.Red;
                        viewOfRoute.OutlineColor = Colors.Black;

                        // Add the new MapRouteView to the Routes collection
                        // of the MapControl.
                        MyMap.Routes.Add(viewOfRoute);

                        // Fit the MapControl to the route.
                        await MyMap.TrySetViewBoundsAsync(
                              routeResult.Route.BoundingBox,
                              null,
                              Windows.UI.Xaml.Controls.Maps.MapAnimationKind.None);
                    }

                    break;

                case GeolocationAccessStatus.Denied:
                    //              
                    break;
            }


            // Start at Microsoft in Redmond, Washington.
            BasicGeoposition startLocation = new BasicGeoposition() { Latitude = 51.030460, Longitude = 3.703510 };

        }
    }
}