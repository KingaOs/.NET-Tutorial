using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class FizzBuzz
    {
        int number;

        public string Calculate(string userInput)
        {
            if (!int.TryParse(userInput, out number))
                return "Złe dane. Spróbuj jeszcze raz.";
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return userInput;
        }

    }
}
