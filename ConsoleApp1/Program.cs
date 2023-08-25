using System;

namespace PalindromeChecker {
   class Program {
      static bool IsPalindrome (string input) {
         input = input.ToLower ().Replace (" ", "").Replace (".", "").Replace (",", "").Replace ("?", "").Replace ("'", "").Replace ("!", "");
         int left = 0;
         int right = input.Length - 1;

         while (left < right) {
            if (input[left] != input[right]) {
               return false;
            }
            left++;
            right--;
         }

         return true;
      }

      static void Main (string[] args) {
      Console.WriteLine ("Enter a sentence or word:");
      string input = Console.ReadLine ();

         if (IsPalindrome (input)) {
            Console.WriteLine ("It is a palindrome.");
         } else {
            Console.WriteLine ("It is not a palindrome.");
         }
      }
   }
}
