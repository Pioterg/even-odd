using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj mi dowolną liczbę całkowitą a ja powiem Ci czy ta liczba jest parzysta czy nieparzysta.");
            var selectedNumber = GetNumber();
            var rest = (selectedNumber % 2);
            if (rest == 0)
            {
                Console.WriteLine("Podana przez Ciebie licza jest parzysta.");
            }
            else
            {
                Console.WriteLine("Podana przez Ciebie liczba jest nieparzysta.");
            }
        }
        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Musisz podać Liczbę.");
                    continue;
                }
                return number;
            }
        }
    }
}
