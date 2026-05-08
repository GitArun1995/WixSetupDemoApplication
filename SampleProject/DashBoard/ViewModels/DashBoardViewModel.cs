using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.ViewModels
{
    public class DashBoardViewModel : BindableBase, INavigationAware
    {
        private readonly IEventAggregator _eventAggregator;
        public DashBoardViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }
        public bool IsNavigationTarget(NavigationContext navigationContext) => true;
    
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
          
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            try
            {
                Process.Start(@"SampleBackendApplication.exe");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
