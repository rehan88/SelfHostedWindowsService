using WindowsServiceSelfHosted.Contracts.Contracts;
using WindowsServiceSelfHosted.Services.Services;
using Ninject.Modules;
using Ninject.Web.Common;

namespace WindowsServiceSelfHosted.Module
{
    namespace Modules
    {
        public class Module : NinjectModule
        {
            public override void Load()
            {
                Bind<IStringProvider>().To<DefaultStringProvider>().InRequestScope();
            }
        }
    }
}