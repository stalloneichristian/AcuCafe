using System;
namespace AcuCafe
{
    public class IceTea : IDrink
    {

        public string Description
        {
            get { return "Ice Tea"; }
        }

        public double Cost()
        {
            double cost = 1.5;

            return cost;
        }

        public void Prepare()
        {
            string message = "We are preparing the following drink for you: " + Description;

            Console.WriteLine(message);
        }
    }
}
