using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;
using XF.MasterDetailPage.Prism.Events;

namespace XF.MasterDetailPage.Prism.ViewModels
{
    public class CustomViewPageViewModel
    {
        public DelegateCommand OpenMasterMenuCommand { get; private set; }

        public CustomViewPageViewModel(IEventAggregator eventAggregator)
        {
            OpenMasterMenuCommand = new DelegateCommand(() => eventAggregator.GetEvent<ShowHideMasterMenuEvent>().Publish());
        }
    }
}
