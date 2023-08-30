using System;
namespace ReduceString {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a string:");
         string input = Console.ReadLine ();
         string output = ReducedString (input);
         Console.WriteLine ("Reduced String:" + output);
      }
      static string ReducedString (string input) {
         System.Text.StringBuilder result = new System.Text.StringBuilder ();
         foreach (char c in input) {
            if (result.Length > 0 && result[result.Length - 1] == c) {
               result.Length--;
            } else {
               result.Append (c);
            }
         }
         return result.ToString ();
      }
   }
}



