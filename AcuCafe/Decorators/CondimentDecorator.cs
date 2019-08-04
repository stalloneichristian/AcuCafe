using System;
namespace AcuCafe.Decorators
{
    /*
     * This is the base clase for all the condiments
     * Using the decorator pattern for all condinemts
     * This helps us to add or remove any condiments easily
     */
    public abstract class CondimentDecorator :IDrink
    {
        IDrink _drink;
        protected double _price = 0.0;
        protected string _name = "undefined condiment";

        public CondimentDecorator(IDrink drink)
        {
            _drink = drink;
        }

        public string Description
        {
            get { return $"{_drink.Description} with { _name }"; }
        }

        public double Cost()
        {
            return _drink.Cost() + _price;
        }

        public void Prepare()
        {
            string message = $"We are preparing the following drink for you: {Description}";

            Console.WriteLine(message);
        }
    }
}
