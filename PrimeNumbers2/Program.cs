using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers2
{
    internal class Program
    {
        static ulong maxNumber = 1000000000000;
        static void Main(string[] args)
        {
            for (ulong i = 0; i < maxNumber; i++)
            {
                if (IsPrime(i) == true)
                {
                    Console.WriteLine(i + " = " + IsPrime(i) + ", ");
                }
            }
            Console.ReadKey(true);
        }

        static bool IsPrime(ulong num)
        {
            if (num < 2) return false;
            for (ulong i = 2; i < Math.Sqrt(num); i++)// i = 1... num -1 
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
