using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber;

        do
        {
            Console.Write("Enter a number(0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            float average = (float)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The max is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}