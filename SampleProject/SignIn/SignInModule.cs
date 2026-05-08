using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using SignIn.Views;
using System;

namespace SignIn
{
    [Module(ModuleName = "SignInModule", OnDemand = false)]
    public class SignInModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _region;

        public SignInModule(IUnityContainer container, IRegionManager region)
        {
            _region = region;
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        public void Initialize()
        {
            _region.RegisterViewWithRegion("MainRegion", typeof(SignInView));
            _container.RegisterTypeForNavigation<SignInView>(nameof(SignInView));
        }
    }
}
