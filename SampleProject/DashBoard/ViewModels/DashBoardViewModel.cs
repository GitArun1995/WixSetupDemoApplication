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
            Console.WriteLine("Constructor called in DashBoard Project");

        }
        public bool IsNavigationTarget(NavigationContext navigationContext) => true;
    
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
          
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            try
            {
                Console.WriteLine("OnNavigated called in DashBoard Project");
                Process.Start(@"SampleBackendApplication.exe");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
