using OpendeurdagApp.Models;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace OpendeurdagApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            BackendDataSource.LoadBackendData();

            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;

            BitmapImage hogentBanner = new BitmapImage(new Uri("ms-appx:///Assets/hogentI.jpg", UriKind.RelativeOrAbsolute));
            BitmapImage opleidingTI = new BitmapImage(new Uri("ms-appx:///Assets/ToegepasteInformatica.jpg", UriKind.RelativeOrAbsolute));
            BitmapImage opleidingBedfrijfsMan = new BitmapImage(new Uri("ms-appx:///Assets/Bedrijfsmanagement.jpg", UriKind.RelativeOrAbsolute));
            BitmapImage opleidingOffice = new BitmapImage(new Uri("ms-appx:///Assets/OfficeManagement.jpg", UriKind.RelativeOrAbsolute));

            flipOpleidingen.Items.Add(hogentBanner);
            flipOpleidingen.Items.Add(opleidingTI);
            flipOpleidingen.Items.Add(opleidingBedfrijfsMan);
            flipOpleidingen.Items.Add(opleidingOffice);

            BitmapImage hogentAalstBanner = new BitmapImage(new Uri("ms-appx:///Assets/hAgent.png", UriKind.RelativeOrAbsolute));
            BitmapImage coverBuiten = new BitmapImage(new Uri("ms-appx:///Assets/campusAalstCoverBuiten.jpg", UriKind.RelativeOrAbsolute));
            BitmapImage klassen = new BitmapImage(new Uri("ms-appx:///Assets/Bedrijfsmanagement.jpg", UriKind.RelativeOrAbsolute));
            BitmapImage auditoriums = new BitmapImage(new Uri("ms-appx:///Assets/OfficeManagement.jpg", UriKind.RelativeOrAbsolute));

            flipRondleiding.Items.Add(hogentAalstBanner);
            flipRondleiding.Items.Add(coverBuiten);
            flipRondleiding.Items.Add(auditoriums);
            flipRondleiding.Items.Add(klassen);


        }

        private void FlipView_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }
    }
}
