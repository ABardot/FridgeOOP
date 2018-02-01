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
            Console.WriteLine("Hello, welcome to the fridge app.");
            Fridge userFridge = new Fridge(false, "Deluxe dispenser", 70, true);
            do
            {
                
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1.");
                Console.WriteLine("To change the light bulb, type 2.");
                Console.WriteLine("To clean, type 3.");
                Console.WriteLine("To take food, type 4.");
                Console.WriteLine("To check food supplies, type 5.");
                Console.WriteLine("To see all fridge details, type 6.");
                //Console.WriteLine("To restart, type 7.");
                Console.WriteLine("To quit, type 8.");

                userChoice = int.Parse(Console.ReadLine());

               

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;

                    case 2:
                       
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;

                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;

                    case 4:
                        Console.WriteLine("How much food do you want to remove, please type in amount?");
                        int foodNumber = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodNumber);
                        break;

                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;

                    case 6:
                        Console.WriteLine("It is {0} that the fridge is clean. \nThe dispenser type is {1}. \nThe food amount is {2}. \nIt is {3} that the bulbs work.", userFridge.IsClean, userFridge.DispenserType, userFridge.FoodAmount, userFridge.BulbsWork);
                        Console.WriteLine();
                        break;

                    default:
                        break;
                }
            } while (userChoice != 8); // Restart the app
        }
    }
}