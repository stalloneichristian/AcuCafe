using System;
using System.Collections.Generic;
using AcuCafe.Decorators;
using Xunit;

namespace AcuCafe.Tests
{
    public class AcuCafeLibraryTest
    {
        //Test of the condiments are supported by the drink
        [Fact]
        public void ShouldSupportCondiments()
        {
            //Arrange
            var drinks = new List<IDrink>()
            {
                new MilkDecorator(new SugarDecorator(new Tea())),
                new SugarDecorator( new IceTea()),
                new ChocolateDecorator(new MilkDecorator(new SugarDecorator((new Expresso()))))
            };

            //Act
            /*  Values to check
             *  Hot Tea with Milk and Sugar
             *  Ice Tea with Sugar
             *  Expresso with Chocolate and Milk and Sugar
             *  */
            IDrink actual = AcuCafeLibrary.OrderDrink(CafeFactory.CreateDrink("Expresso with Chocolate and Milk and Sugar"));

            //Asert
            Assert.Equal(drinks[2].Description, actual.Description);
        }


        //Tes the cost of the drink.
        [Fact]
        public void ShouldGetCost()
        {
            //Arrange
            var drinks = new List<IDrink>()
            {
                new MilkDecorator(new SugarDecorator(new Tea())),
                new SugarDecorator( new IceTea()),
                new ChocolateDecorator(new MilkDecorator(new SugarDecorator((new Expresso()))))
            };

            //Act
            /*  Values to check
             *  Hot Tea with Milk and Sugar
             *  Ice Tea with Sugar
             *  Expresso with Chocolate and Milk and Sugar
             *  */
            double actualCost = AcuCafeLibrary.GetCost(CafeFactory.CreateDrink("Expresso with Chocolate and Milk and Sugar"));

            //Assert
            /*  Values to check
             *  Hot Tea with Milk and Sugar - 2
             *  Ice Tea with Sugar - 2
             *  Expresso with Chocolate and Milk and Sugar - 2.75
             *  */
            Assert.Equal(2.75, actualCost);
        }
    }

}
