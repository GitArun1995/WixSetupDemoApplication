using Prism.Modularity;
using Prism.Unity;
using ShellProject.Views;
using System.Windows;
using Microsoft.Practices.Unity;
using SignIn;
using DashBoard;
using Header;

namespace ShellProject
{
    class Bootstrapper : UnityBootstrapper
    { 
    
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<ShellProjectView>();
        }

        protected override void InitializeShell()
        {
            if (Application.Current.MainWindow != null) Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {

            var catalog = (ModuleCatalog)ModuleCatalog;

            catalog.AddModule(typeof(SignInModule));
            catalog.AddModule(typeof(DashBoardModule));
            catalog.AddModule(typeof(HeaderModule));
        }
    }
}

