using System;

namespace FridgeOOP
{
    internal class Program
    {
        private static void Main()
        {
            // Create interactive console user
            // Prompt user to choose what to do with the
            // Call methods on fridge object to do what the user wants
            int userChoice;
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1.");
                Console.WriteLine("To change the light bulb, type 2.");
                Console.WriteLine("To clean, type 3.");
                Console.WriteLine("To take food, type 4.");
                Console.WriteLine("To check food supplies, type 5.");
                Console.WriteLine("To see all fridge details, type 6.");
                Console.WriteLine("To restart, type 7.");
                Console.WriteLine("To quit, type 8.");

                userChoice = int.Parse(Console.ReadLine());


            } while (userChoice != 8); // Restart the app
        }
    }
}