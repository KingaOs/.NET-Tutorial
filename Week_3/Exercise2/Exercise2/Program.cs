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
            int numberOfGuesses = 0;
            Random rand = new Random();
            var randomNumber = rand.Next(0, 101);
            Console.WriteLine("Wylosowano liczbę z przedziału 0-100. Zgadnij jaka to liczba!");
            int userInput;
            do
            {
                numberOfGuesses++;
                userInput = int.Parse(Console.ReadLine());
                if (userInput > randomNumber)
                    Console.WriteLine("Niżej");
                if (userInput < randomNumber)
                    Console.WriteLine("Wyżej");
            } while (userInput != randomNumber);

            Console.WriteLine($"Dobrze! Odgadłeś liczbę w {numberOfGuesses} próbach!");
        }
    }
}
