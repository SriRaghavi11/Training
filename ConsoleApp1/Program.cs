using System;
namespace DigitalRootFinder {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter the number:");
         int n = int.Parse (Console.ReadLine ());
         if (n != 0) {
            int digitalroot = 1 + ((n - 1) % 9);
            Console.WriteLine ($"The digital root is {digitalroot}");
         } else {
            Console.WriteLine ("The digital root is 0");
         }
      }
   }
}

