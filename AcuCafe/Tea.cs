using System;
namespace AcuCafe
{
    public class Tea : IDrink
    {

        public string Description
        {
            get { return "Hot Tea"; }
        }

        public double Cost()
        {
            double cost = 1;

            return cost;
        }

        public void Prepare()
        {
            string message = "We are preparing the following drink for you: " + Description;

            Console.WriteLine(message);
        }
    }
}
