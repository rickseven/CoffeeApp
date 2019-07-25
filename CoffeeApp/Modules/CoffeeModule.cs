using Coffee.Core.Services;
using Ninject.Modules;

namespace CoffeeApp.Modules
{
    public class CoffeeModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICoffeeService>().To<CoffeeService>().WhenInjectedInto<CreamCoffeeService>();
        }
    }
}
