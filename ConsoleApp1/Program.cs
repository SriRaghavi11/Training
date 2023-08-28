using System;
namespace NumberConversionGame {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter the number:");
         int input = int.Parse (Console.ReadLine ());
         String Hexadecimal = Convert.ToString (input, 16).ToUpper ();
         String Binary = Convert.ToString (input, 2);
         Console.WriteLine ($"Input:{input}");
         Console.WriteLine ($"HEX:{Hexadecimal}");
         Console.WriteLine ($"Binary:{Binary}");
         Console.ReadLine ();
      }
   }
}