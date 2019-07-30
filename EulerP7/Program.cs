/*

    By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    What is the 10 001st prime number?

*/

using System;

namespace EulerP7
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeCount = 0;
            int potentialPrime = 2;

            while (primeCount != 10001)
            {
                if (IsPrime(potentialPrime))
                {
                    primeCount++;
                }

                if (potentialPrime == 2)
                {
                    potentialPrime++;
                }

                // no need to test even numbers for being prime other than two
                else
                {
                    potentialPrime += 2;
                }
            }

            Console.WriteLine($"The 10,001st prime number is {potentialPrime}");
        }

        /// <summary>
        /// This method will test an inputted number to check whether it is a prime number or not.
        /// </summary>
        /// <param name="numToCheck">The number that is being checked for being prime or not.</param>
        /// <returns>Returns true if the parameter is a prime number and false if not.</returns>
        static bool IsPrime(int numToCheck)
        {
            for (int i = 2; i < (numToCheck/2); i++)
            {
                if (numToCheck % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
