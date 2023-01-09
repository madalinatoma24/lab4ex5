using System;

namespace lab4ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 5
             Scrieti o functie recursiva care va calcula suma numerelor de la 1 
             pana la n, apelati-o si afisati-i rezultatul

             */
            Console.Write("Introduceti valoare lui n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Suma numerelor este: " + SumNumbers(n));
        }

        static int SumNumbers(int n)
        {
            var sum = 0;
          
            if(n != 0)
            {
                sum= n + SumNumbers(n - 1);
                return sum;
            }
            return sum;
        }
    }
}
