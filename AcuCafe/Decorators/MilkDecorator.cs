using System;
namespace AcuCafe.Decorators
{
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(IDrink drink)
            :base(drink)
        {
            _name = "Milk";
            _price = 0.50;
        }
    }
}
