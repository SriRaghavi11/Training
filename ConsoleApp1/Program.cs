using System;
namespace DigitalRootFinder {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter the number:");
         int n=int.Parse (Console.ReadLine());
         int digitalroot = n % 9;
         Console.WriteLine ($"The digital root of {n} is {digitalroot}");
      }
   }
}