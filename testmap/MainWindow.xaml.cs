using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace testmap
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String loca { get; set; }
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

            loca = "35.87613809062744, 10.581433008655555";

            //************************************methode 1*********************PARCOURIR UNE BOUCLE ********************************************************************
            /*
            map1.Center = new Location(55.6760970, 12.5683370);
            map1.ZoomLevel = 12;
            int a = 1;
            var x = 55.6760970;
            var y = 12.5683370;
            while (a < 5)
            {
                x = x + 0.1;
                y = y + 0.1;
                Pushpin pin = new Pushpin();
                pin.Location = new Location(x, y);
                pin.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 100, 100, 100));
                // Adds the pushpin to the map.
                map1.Children.Add(pin);
                a = a + 1;
            }
            */


            //****************************************methode 2*****************PARCOURIR une liste  ********************************************************************
            //centraliser la vue de map
            map1.Center = new Location(35.87613809062744, 10.581433008655555);
            map1.ZoomLevel = 12;
            // Créer une liste
            List<PushpinClass> places = new List<PushpinClass>();

            // Ajouter des éléments à la liste 
            places.Add(new PushpinClass() { Longitude = 35.87905464583415, Latitude = 10.579875926759339 });
            places.Add(new PushpinClass() { Longitude = 35.883220710051624, Latitude = 10.576418289803316 });
            places.Add(new PushpinClass() { Longitude = 35.88683870218131, Latitude = 10.573815492944375 });
            places.Add(new PushpinClass() { Longitude = 35.89018778176488, Latitude = 10.571085108077373 });
            foreach (PushpinClass item in places)
            {
                Pushpin pin = new Pushpin();
                pin.Location = new Location(item.Longitude,item.Latitude);
                pin.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 100, 100, 100));
                // Adds the pushpin to the map.
                map1.Children.Add(pin);
            }

        }
    }

    class PushpinClass
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
