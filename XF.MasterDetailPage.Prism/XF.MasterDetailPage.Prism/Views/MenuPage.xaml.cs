using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MasterDetailPage.Prism.Events;

namespace XF.MasterDetailPage.Prism.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : Xamarin.Forms.MasterDetailPage
    {
        public MenuPage(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            eventAggregator.GetEvent<ShowHideMasterMenuEvent>().Subscribe(ShowHideMasterMenu);
        }

        private void ShowHideMasterMenu()
        {
            IsPresented = !IsPresented;
        }
    }
}