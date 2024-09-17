using NavigationServices.MVVM.ViewModels;
using NavigationServices.Services;
using NavigationServices.Stores;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NavigationServices
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore = new NavigationStore();

        private INavigationService HomeNavigationService;
        private INavigationService OtherNavigationService;

        protected override void OnStartup(StartupEventArgs e)
        {
            OtherNavigationService = new NavigationService<OtherViewModel>(_navigationStore, () => new OtherViewModel(HomeNavigationService));
            HomeNavigationService = new NavigationService<HomeViewModel>(_navigationStore, () => new HomeViewModel(OtherNavigationService));
            HomeNavigationService.Navigate();

            MainWindow mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            mainWindow.Show();

            base.OnStartup(e);
        }

    }
}
