using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        BreathingActivity breathing = new BreathingActivity(
                            "Breathing Activity",
                            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                        );
                        breathing.Run();
                        break;

                    case 2:
                        ReflectingActivity reflecting = new ReflectingActivity(
                            "Reflecting Activity",
                            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                        );
                        reflecting.Run();
                        break;

                    case 3:
                        ListingActivity listing = new ListingActivity(
                            "Listing Activity",
                            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                        );
                        listing.Run();
                        break;

                    case 4:
                        Console.WriteLine("Goodbye! Thanks for using the Mindfulness Program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }

                if (choice != 4)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadKey();
            }
        }
    }
}
