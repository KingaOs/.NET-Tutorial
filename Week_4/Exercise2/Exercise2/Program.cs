using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę");
            FizzBuzz fizzBuzz = new FizzBuzz();
            var message = fizzBuzz.Calculate(Console.ReadLine());
            Console.WriteLine(message);
        }
    }
}
