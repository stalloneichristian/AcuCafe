using System;
namespace AcuCafe.Decorators
{
    public class SugarDecorator : CondimentDecorator
    {
        public SugarDecorator(IDrink drink)
            :base(drink)
        {
            _name = "Sugar";
            _price = 0.50;
        }
    }
}
