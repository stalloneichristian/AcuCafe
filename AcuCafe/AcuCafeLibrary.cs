using System;

namespace AcuCafe
{
    public static class AcuCafeLibrary 
    {
        // Order your favorite drink from the menu
        public static IDrink OrderDrink(IDrink drink)
        {
            try
            {
                drink.Prepare();
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are unable to prepare your drink. " + ex.Message);
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }

            return drink;
        }

        //Get the cost of the drink
        public static double GetCost(IDrink drink)
        {

            return drink.Cost();
        }

    }

}