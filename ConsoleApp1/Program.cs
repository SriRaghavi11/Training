using System;
namespace IsogramCheck {
   class Program {
      static bool IsIsogram (string word) {
         word = word.ToLower ();
         char[] letters = word.ToCharArray ();
         Array.Sort (letters);
         for (int i = 1; i < letters.Length; i++) {
            if (letters[i] == letters[i - 1]) {
               return false;
            }
         }
         return true;
      }
      static void Main (string[] args) {
         Console.Write ("Enter a word: ");
         string word = Console.ReadLine ();
         if (IsIsogram (word)) {
            Console.WriteLine ("The word is an isogram.");
         } else {
            Console.WriteLine ("The word is not an isogram.");
         }
      }
   }
}
