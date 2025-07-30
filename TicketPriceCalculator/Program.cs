using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Error: Age cannot be negative.");
                    return;
                }

                decimal ticketPrice = GetTicketPrice(age);
                Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        static decimal GetTicketPrice(int age)
        {
            if (age >= 65 || age <= 12) return 7m;
            else return 10m;
        }
    }
}

