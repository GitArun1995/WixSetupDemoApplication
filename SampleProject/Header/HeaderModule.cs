using Header.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Header
{
    public class HeaderModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;
        public HeaderModule(IRegionManager _regionManager,IUnityContainer _container)
        {
            regionManager = _regionManager;
            container = _container;
        }
        public void Initialize()
        {
            container.RegisterTypeForNavigation<HeaderView>(nameof(HeaderView));
        }
    }
}
