using NavigationServices.Core;
using NavigationServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationServices.MVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public RelayCommand OtherPageCommand => new RelayCommand(NavigateToOtherView);

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private void NavigateToOtherView()
        {
            _navigationService.Navigate();
        }


    }
}
