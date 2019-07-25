
namespace Coffee.Core.Services
{
    public class CreamCoffeeService : ICoffeeService
    {
        private readonly ICoffeeService _coffeeService;
        public CreamCoffeeService(ICoffeeService coffeeService) {
            _coffeeService = coffeeService;
        }
        public Cup GetCoffee()
        {
            Cup cup = _coffeeService.GetCoffee();
            cup.ingredients.Add("Cream");
            return cup;
        }
    }
}
