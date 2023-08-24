using System;

namespace PalindromeandReverse {
   class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter the number:");
         int number = int.Parse (Console.ReadLine ());
         int originalNumber = number;

         int reversedNumber = 0;
         while (number > 0) {
            int digit=number% 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
         }
         Console.WriteLine ("Reversed Number: " + reversedNumber);
         if (originalNumber == reversedNumber) {
            Console.WriteLine ("The number is a palindrome.");
         } else {
            Console.WriteLine ("The number is not a palindrome.");
         }
      }
   }
}
