using System;
namespace LcmGcdFinder {
   class Program {
      static void Main (string[] args) {
         int a, b, temp, gcd, lcm;
         Console.WriteLine ("Enter two numbers:");
         int n1 = int.Parse (Console.ReadLine ());
         int n2 = int.Parse (Console.ReadLine ());
         a = n1;
         b = n2;
         while (b != 0) {
            temp = b;
            b = a % b;
            a = temp;
         }
         gcd = a;
         lcm = (n1 * n2) / gcd;
         Console.WriteLine ($"GCD:{gcd}");
         Console.WriteLine ($"LCM:{lcm}");
         Console.ReadLine ();
      }
   }
}
