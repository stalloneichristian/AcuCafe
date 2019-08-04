using System;
using AcuCafe.Decorators;

/*
 * Factorty class to create or remove any items from the factory.
 * This is so that the objects are instatciated when required and all the instanceciation is managed in one place.
 */
namespace AcuCafe
{
    public static class CafeFactory
    {
        public static IDrink CreateDrink(string drinkName)
        {
            switch(drinkName)
            {
                //Hot Tea
                case "Hot Tea":
                    return new Tea();
                //Hot Tea with Milk
                case "Hot Tea with Milk":
                    return new MilkDecorator(new Tea());
                //Hot Tea with Sugar
                case "Hot Tea with Sugar":
                    return new SugarDecorator(new Tea());
                //Hot Tea with Milk and Sugar
                case "Hot Tea with Milk and Sugar":
                    return new MilkDecorator(new SugarDecorator(new Tea()));

                //Ice Tea
                case "Ice Tea":
                    return new IceTea();
                //Ice tea with Sugar
                case "Ice Tea with Sugar":
                    return new SugarDecorator( new IceTea());

                //Expresso
                case "Expresso":
                    return new Expresso();
                //Expresso with Milk
                case "Expresso with Milk":
                    return new MilkDecorator(new Expresso());
                //Expresso with Sugar
                case "Expresso with Sugar":
                    return new SugarDecorator(new Expresso());
                //Expresso with Milk and Sugar
                case "Expresso with Milk and Sugar":
                    return new MilkDecorator( new SugarDecorator(new Expresso()));
                //Expresso with Chocolate
                case "Expresso with Chocolate":
                    return new ChocolateDecorator(new Expresso());
                //Expresso with Chocolate and Milk
                case "Expresso with Chocolate and Milk":
                    return new ChocolateDecorator(new MilkDecorator( new Expresso()));
                //Expresso with Chocolate and Sugar
                case "Expresso with Chocolate and Sugar":
                    return new ChocolateDecorator(new SugarDecorator(new Expresso()));
                //Expresso with Chocolate and Milk and Sugar
                case "Expresso with Chocolate and Milk and Sugar":
                    return new ChocolateDecorator(new MilkDecorator(new SugarDecorator((new Expresso()))));

                //Default
                default:
                    return null;
            }
        }

    }
}
