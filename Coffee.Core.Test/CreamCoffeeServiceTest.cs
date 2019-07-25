using Coffee.Core.Services;
using Coffee.Core.Test.Modules;
using Ninject;
using NUnit.Framework;

namespace Coffee.Core.Test
{
    class CreamCoffeeServiceTest
    {
        private IKernel _kernel;

        [SetUp]
        public void setup() {
            _kernel = new StandardKernel(new CoffeeModule());
        }

        [Test]
        public void CreamCoffeeService_GetCoffee_MustReturnTheCupWithTheIngredientsOfCoffeePowderAndHotWaterAndCream()
        {
            // Initialize DI
            ICoffeeService coffeeService = _kernel.Get<CreamCoffeeService>();

            // Act
            Cup cup = coffeeService.GetCoffee();

            // Assert
            Assert.That(cup.ingredients.Contains("Coffee Powder"));
            Assert.That(cup.ingredients.Contains("Hot Water"));
            Assert.That(cup.ingredients.Contains("Cream"));
        }
    }
}
