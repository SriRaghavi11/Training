using System;
namespace PrimeNumberChecker {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number: ");
         int n = int.Parse (Console.ReadLine ());
         bool IsPrime (int number) {
            if (number <= 1)
               return false;
            if (number <= 3)
               return true;
            if (number % 2 == 0 || number % 3 == 0)
               return false;
            for (int i = 5; i * i <= number; i += 6) {
               if (number % i == 0 || number % (i + 2) == 0)
                  return false;
            }
            return true;
         }
         bool isInputPrime = IsPrime (n);
         if (isInputPrime)
            Console.WriteLine ($"{n} is a prime number.");
         else
            Console.WriteLine ($"{n} is not a prime number.");
      }
   }
}

