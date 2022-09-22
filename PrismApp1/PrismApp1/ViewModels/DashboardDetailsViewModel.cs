using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp1.ViewModels
{
    public class DashboardDetailsViewModel:BindableBase
    {
        INavigationService _navigationService;
        public DashboardDetailsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
