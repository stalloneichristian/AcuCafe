using System;
using AcuCafe;
using System.Configuration;
using System.Linq;

namespace ConsoleUI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            OpenApplication();

            string input = Console.ReadLine();

            //Check Valid Input
            bool isInputValid = CheckIfInputIsValid(input);
            if(isInputValid == true)
            {
                IDrink drink = CafeFactory.CreateDrink(ConfigurationManager.AppSettings[input]);

                if (drink != null)
                {
                    AcuCafeLibrary.OrderDrink(drink);

                    Console.WriteLine($"The cost of your drink is {AcuCafeLibrary.GetCost(drink)}");
                }
                else
                {
                    Console.WriteLine("Drink unavailable");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input\n");

            }
            
        }

        private static void OpenApplication()
        {
            Console.WriteLine("Welcome to Acu Cafe \n");
            Console.WriteLine("Please select from one of the numbers following options and press enter: \n");

            foreach (string key in ConfigurationManager.AppSettings)
            {
                string value = ConfigurationManager.AppSettings[key];

                Console.WriteLine($"{key} - {value}");
            }
            Console.WriteLine();
        }

        private static bool CheckIfInputIsValid(string input)
        {
            bool containsInput = ConfigurationManager.AppSettings.AllKeys.Contains(input);
            return containsInput;
            
        }
    }
}
