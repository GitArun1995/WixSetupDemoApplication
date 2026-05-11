using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.ViewModels
{
    public class SignInViewModel : BindableBase, INavigationAware
    {
        private readonly IEventAggregator _eventAggregator;
        public SignInViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Console.WriteLine("Constructor called in Sign Project");
        }
        public bool IsNavigationTarget(NavigationContext navigationContext) => true;
       

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            Console.WriteLine("OnNavigated called in Sign Project");
        }
    }
}
