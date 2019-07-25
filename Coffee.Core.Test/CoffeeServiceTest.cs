using Coffee.Core.Services;
using Coffee.Core.Test.Modules;
using Ninject;
using NUnit.Framework;

namespace Coffee.Core.Test
{
    class CoffeeServiceTest
    {
        private IKernel _kernel;

        [SetUp]
        public void Setup()
        {
            _kernel = new StandardKernel(new CoffeeModule());
        }

        [Test]
        public void CoffeeService_GetCoffee_MustReturnTheCupWithTheIngredientsOfCoffeePowderAndHotWater()
        {
            // Initialize DI
            ICoffeeService coffeeService = _kernel.Get<CoffeeService>();

            // Act
            Cup cup = coffeeService.GetCoffee();

            // Assert
            Assert.That(cup.ingredients.Contains("Coffee Powder"));
            Assert.That(cup.ingredients.Contains("Hot Water"));
        }
    }
}
