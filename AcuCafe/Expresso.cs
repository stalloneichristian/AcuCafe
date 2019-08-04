using System;
namespace AcuCafe
{
    public class Expresso : IDrink
    {

        public string Description
        {
            get { return "Expresso"; }
        }

        public double Cost()
        {
            double cost = 1.25;

            return cost;
        }

        public void Prepare()
        {
            string message = "We are preparing the following drink for you: " + Description;

            Console.WriteLine(message);
        }
    }
}
