using PrismApp1.Helpers;
using PrismApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp1.ViewModels
{
    public class DashboardViewModel:BindableBase
    {
        private INavigationService _navigationService { get; }

        FirebaseHelper firebaseHelper = new FirebaseHelper();

        ObservableCollection<Esp> espList = new ObservableCollection<Esp>();
        IEnumerable<Esp> espListDB = new List<Esp>();

        public DashboardViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public async void GetAllEsp()
        {
            espListDB = await firebaseHelper.GetAllEsps();

            
        }
    }
}
