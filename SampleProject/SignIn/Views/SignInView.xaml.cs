using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SignIn.Views
{
    /// <summary>
    /// Interaction logic for SignInView.xaml
    /// </summary>
    public partial class SignInView : UserControl
    {
        private readonly IRegionManager _regionManager;
        public SignInView(IRegionManager regionManager)
        {
            InitializeComponent();
            _regionManager = regionManager;
        }

        private void SignInClick(object sender, RoutedEventArgs e)
        {
            _regionManager.RequestNavigate("MainRegion", "DashBoardView");
            _regionManager.RequestNavigate("HeaderRegion", "HeaderView");
        }
    }
}
