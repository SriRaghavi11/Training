using System;
namespace MultiplicationTables {
   class Program {
      static void Main (string[] args) {
         for (int i = 1; i <= 10; i++) {
            Console.WriteLine ($"Multiplication Table for {i}");
            for (int j = 1; j <= 10; j++) {
               Console.WriteLine (String.Format ("{0,2} * {1,2} = {2,2}", i, j, i * j));
            }
            Console.WriteLine ("\n");
         }
         Console.ReadLine ();
      }
   }
}
