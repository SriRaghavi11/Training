using System;
namespace PrintDiamond {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Input number of rows (half of the diamond) : ");
         int r = int.Parse (Console.ReadLine ());
         PrintDiamondUpperHalf (r);
         PrintDiamondLowerHalf (r);
      }
      static void PrintDiamondUpperHalf (int r) {
         for (int i = 0; i <= r; i++) {
            for (int j = 1; j <= r - i; j++)
               Console.Write (" ");
            PrintStars (2 * i - 1);
            Console.WriteLine ();
         }
      }
      static void PrintDiamondLowerHalf (int r) {
         for (int i = r - 1; i >= 1; i--) {
            for (int j = 1; j <= r - i; j++)
               Console.Write (" ");
            PrintStars (2 * i - 1);
            Console.WriteLine ();
         }
      }
      static void PrintStars (int count) {
         for (int j = 1; j <= count; j++)
            Console.Write ("*");
      }
   }
}
