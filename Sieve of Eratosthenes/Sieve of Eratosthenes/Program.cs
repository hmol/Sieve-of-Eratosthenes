using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sieve_of_Eratosthenes
{
    /// <summary>
    /// My implementation of The Sieve of Eratosthenes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //If the user want to enter rubbish he is welcome to do so, but he should not be suprised if the program chrashes

            Console.WriteLine("Enter the limit(N) to find primenumbers form 0-N: ");

            int nr = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe primes from 0 to {0} and are:", nr);
            bool[] primes = SieveOfEratosthenes(nr);
            for (int i = 0; i < primes.Count(); i++)
            {
                if (primes[i])
                    Console.Write("{0}, ", i.ToString());
            }

            Console.ReadKey();
        }

        public static bool[] SieveOfEratosthenes(int n)
        {
            bool[] checkPrime = new bool[n + 1];

            //According to Eratosthenes we must start with assuing that all numbers are prime
            for (int i = 2; i <= n; i++)
                checkPrime[i] = true;           

            // With the help of the Sieve, values that is not is set prime to false in our array
            //the multipples of i will be set to false
            for (int i = 2; i * i <= n; i++)      
                if (checkPrime[i])
                    for (int j = i; i * j <= n; j++)
                        checkPrime[i * j] = false;

            return checkPrime;
        }
    }
}
