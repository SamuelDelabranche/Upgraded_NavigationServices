using NavigationServices.Core;
using NavigationServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationServices.MVVM.ViewModels
{
    public class OtherViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public RelayCommand HomePageCommand => new RelayCommand(NavigateToHomeView);


        public OtherViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private void NavigateToHomeView()
        {
            _navigationService.Navigate();
        }
    }
}
