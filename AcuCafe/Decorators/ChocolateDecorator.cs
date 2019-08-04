using System;
namespace AcuCafe.Decorators
{
    public class ChocolateDecorator : CondimentDecorator
    {
        public ChocolateDecorator(IDrink drink)
        : base(drink)
        {
            _name = "Chocolate";
            _price = 0.50;
        }
    }
}
