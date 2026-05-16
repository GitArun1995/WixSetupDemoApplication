using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Header.ViewModels
{
    public class HeaderViewModel : BindableBase, INavigationAware
    {
        private readonly IEventAggregator eventAggregator;
        public HeaderViewModel(IEventAggregator _eventAggregator)
        {
            eventAggregator = _eventAggregator;
        }
        public bool IsNavigationTarget(NavigationContext navigationContext) => true;
        
        

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
           
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
    }
}
