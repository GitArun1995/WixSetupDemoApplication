using DashBoard.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    [Module(ModuleName = "DashBoardModule", OnDemand = false)]
    public class DashBoardModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _region;
        public DashBoardModule(IUnityContainer container, IRegionManager region)
        {
            _region = region;
            _container = container ?? throw new ArgumentNullException(nameof(container));

        }
        public void Initialize()
        {
            _container.RegisterTypeForNavigation<DashBoardView>(nameof(DashBoardView));
        }
    }
}
