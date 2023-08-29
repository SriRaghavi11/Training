using System;
namespace PrintDiamond {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Input number of rows (half of the diamond) :");
         int r = int.Parse (Console.ReadLine ());
         for (int i = 0; i <= r; i++) {
            for (int j = 1; j <= r - i; j++)
               Console.Write (" ");
            for (int j = 1; j <= 2 * i - 1; j++)
               Console.Write ("*");
            Console.Write ("\n");
         }
         for (int i = r - 1; i >= 1; i--) {
            for (int j = 1; j <= r - i; j++)
               Console.Write (" ");
            for (int j = 1; j <= 2 * i - 1; j++)
               Console.Write ("*");
            Console.Write ("\n");
         }
      }
   }
}