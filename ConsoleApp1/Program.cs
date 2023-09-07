using System;
class Program {
   static void Main () {
      Console.Write ("Enter the value of a: ");
      int a = int.Parse (Console.ReadLine ());
      Console.Write ("Enter the value of b: ");
      int b = int.Parse (Console.ReadLine ());
      (a, b) = (b, a); 
      Console.WriteLine ($"After swapping, a = {a}, b = {b}");
   }
}
