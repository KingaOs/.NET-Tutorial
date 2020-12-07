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
            int year;
            int month;
            int day;
            Console.WriteLine("Podaj imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Podaj swoją datę urodzenia. \nPodaj rok urodzenia:");
            if (!int.TryParse(Console.ReadLine(),out year))
                throw new Exception("Podałeś złe dane!");
            Console.WriteLine("Podaj miesiąc:");
            if (!int.TryParse(Console.ReadLine(), out month))
                throw new Exception("Podałeś złe dane!");
            Console.WriteLine("Podaj dzień:");
            if (!int.TryParse(Console.ReadLine(), out day))
                throw new Exception("Podałeś złe dane!");
            Console.WriteLine("Podaj miejsce urodzenia:");
            var placeOfBirth = Console.ReadLine();

            var age = CheckUserAge(year,month,day);

            Console.WriteLine($"Cześć {name}. Urodziłeś się w {placeOfBirth} i masz {age} lat.");
            Console.ReadLine();

        }

        static int CheckUserAge(int year, int month, int day)
        {
            var currentDate = DateTime.Now;
            var currentYear = DateTime.Now.Year;
            int age = currentYear - year;
            var currentDayOfYear = DateTime.Now.DayOfYear;
            var birthDayOfYear = new DateTime(currentYear, month, day).DayOfYear;
            if (currentDayOfYear < birthDayOfYear)
                age--;
            return age;
        }


    }
}
