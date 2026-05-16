using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShellProject.ViewModels
{
    public class ShellProjectViewModel : BindableBase, INavigationAware
    {
        private readonly IEventAggregator _eventAggregator;
        public ShellProjectViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            InitializeTheme("Cyan");
            Console.WriteLine("Constructor called in Shell Project");
        }
        public bool IsNavigationTarget(NavigationContext navigationContext) => true;
        

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
           
        }
        private void InitializeTheme(string theme)
        {
            var dictionaryPath = GetThemeDictionaryPath(theme);
            var resourceDictionary = new ResourceDictionary
            { Source = new Uri(dictionaryPath, UriKind.RelativeOrAbsolute) };
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
        public string GetThemeDictionaryPath(string themeName)
        {
            string result = null;
            if (string.Equals(themeName, "Cyan"))
            {
                result = @"pack://application:,,,/MaterialDesign;Component/Themes/DictionaryMergedCyan.xaml";
            }
            else if (string.Equals(themeName, "Blue"))
            {
                result = @"pack://application:,,,/MaterialDesign;Component/Themes/DictionaryMergedBlue.xaml";
            }
            
            return result;
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            Console.WriteLine("OnNavigated called in Shell Project");
        }
    }
}
