using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XF.MasterDetailPage.Prism.Models;
using XF.MasterDetailPage.Prism.Views;

namespace XF.MasterDetailPage.Prism.ViewModels
{
    public class MenuPageViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public ObservableCollection<MyMenuItem> MenuItems { get; set; }

        private MyMenuItem selectedMenuItem;
        public MyMenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MenuItems = new ObservableCollection<MyMenuItem>();

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "ic_viewa",
                PageName = nameof(ViewA),
                Title = "View A"
            });

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "ic_viewb",
                PageName = nameof(ViewB),
                Title = "View B"
            });

            NavigateCommand = new DelegateCommand(Navigate);
        }

        async void Navigate()
        {
            await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + SelectedMenuItem.PageName);
        }
    }
}
