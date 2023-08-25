using System;
class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the number of rows for the Pascal's triangle: ");
      int numRows = int.Parse (Console.ReadLine ());
      for (int i = 0; i < numRows; i++) {
         int currentValue = 1;
         Console.Write (new string (' ', numRows - i - 1));
         for (int j = 0; j <= i; j++) {
            Console.Write ($"{currentValue} ");
            currentValue = currentValue * (i - j) / (j + 1);
         }
         Console.WriteLine ();
      }
   }
}

