using Prism;
using Prism.Autofac;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XF.MasterDetailPage.Prism.Views;

namespace XF.MasterDetailPage.Prism {

    public partial class App : PrismApplication {

        public App(IPlatformInitializer initializer = null) : base(initializer) {

            InitializeComponent();
        }

        protected override void OnInitialized() {

            NavigationService.NavigateAsync(nameof(MenuPage) + "/"+ nameof(NavigationPage) + "/" + nameof(ViewA));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry) {

            containerRegistry.RegisterForNavigation<MenuPage>();
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
            containerRegistry.RegisterForNavigation<CustomViewPage>();
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
