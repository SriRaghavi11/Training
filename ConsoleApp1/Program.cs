using System;
class Program {
   static void Main () {
      Console.Write ("Enter a number: ");
      string input = Console.ReadLine ();
      Console.Write ("Integral part: ");
      bool decimalPointFound = false;
      foreach (char digit in input) {
         if (char.IsDigit (digit)) {
            Console.Write (digit + " ");
         } else if (digit == '.' && !decimalPointFound) {
            decimalPointFound = true;
            Console.WriteLine ();
            Console.Write ("Fractional part: ");
         }
      }
      if (!decimalPointFound) {
         Console.WriteLine ("No fractional part.");
      }
   }
}
