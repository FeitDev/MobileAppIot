using System;
using System.Collections.ObjectModel;
using PrismApp1.Helpers;
using PrismApp1.Models;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace PrismApp1.Views
{
    public partial class Dashboard : ContentPage
    {
        FirebaseHelper firebaseHelper=new FirebaseHelper();

        ObservableCollection<Esp> espList = new ObservableCollection<Esp>();
        IEnumerable<Esp> espListDB = new List<Esp>();

        public  Dashboard()
        {
            InitializeComponent();

            espList = new ObservableCollection<Esp>
            {
                new Esp
                {
                    Name="Living room lights",
                    SSID="HomeNetwork",
                    Password="12345",
                    IpAddress="127.0.0.1",
                    HasLight=1
                },
                new Esp
                {
                    Name="Garage",
                    SSID="Network",
                    Password="12345",
                    IpAddress="127.0.0.2",
                    HasLight=1
                },
                new Esp
                {
                    Name="Bedroom lights",
                    SSID="HomeNetwork",
                    Password="12345",
                    IpAddress="127.0.0.3",
                    HasLight=1

                }
            };


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            
               // await firebaseHelper.AddPerson();            
            
            
            espListDB =await firebaseHelper.GetAllEsps();

            espView.ItemsSource = espListDB;
        }

        private async void espView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var temp = (Esp)e.CurrentSelection.First();
            var details = new DashboardDetails
            {
                BindingContext = temp
            };
            await Navigation.PushAsync(details);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DashboardDetails());
        }
    }
}
