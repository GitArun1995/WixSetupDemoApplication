using DashBoard.Models;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.ViewModels
{
    public class DashBoardViewModel : BindableBase, INavigationAware
    {
        private readonly IEventAggregator _eventAggregator;
       public ObservableCollection<CardItem> Items { get; set; } = new ObservableCollection<CardItem>();
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
                Items.Add(new CardItem
                {
                    Title = "Title1",
                    Description = "This is Card 1"
                });
                Items.Add(new CardItem
                {
                    Title = "Title2",
                    Description = "This is Card 2"
                });
                Items.Add(new CardItem
                {
                    Title = "Title3",
                    Description = "This is Card 3"
                });
                Items.Add(new CardItem
                {
                    Title = "Title4",
                    Description = "This is Card 4"
                });
                Items.Add(new CardItem
                {
                    Title = "Title5",
                    Description = "This is Card 5"
                });

                Process.Start(@"SampleBackendApplication.exe");

            }
            catch (Exception)
            {


            }
        }
    }
}
