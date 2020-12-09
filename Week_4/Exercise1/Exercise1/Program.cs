using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Wprowadź liczbę lub wprowadź Q/q aby zamknąć aplikacje");
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == "q" || userInput == "Q")
                    break;
                if (!int.TryParse(userInput, out number))
                    Console.WriteLine("Podałeś złe dane! Spróbuj jeszcze raz");
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Liczba parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba nieparzysta");
                }
            }

        }
    }
}

