using System;
namespace AcuCafe
{
    public class Drink : IDrink
    {
        public string Description { get; }

        public double Cost()
        {
            return 0;
        }

        public void Prepare()
        {
            string message = "We are preparing the following drink for you: " + Description;

            Console.WriteLine(message);
        }
    }
}
