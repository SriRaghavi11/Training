using System;
class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the number of words: ");
      int numWords = int.Parse (Console.ReadLine ());
      string[] words = new string[numWords];
      for (int i = 0; i < numWords; i++) {
         Console.Write ($"Enter word {i + 1}: ");
         words[i] = Console.ReadLine ();
      }
      string abecedarianWord = FindAbecedarianWord (words);
      if (!string.IsNullOrEmpty (abecedarianWord)) {
         Console.WriteLine ($"The first abecedarian word is: {abecedarianWord}");
      } else {
         Console.WriteLine ("No abecedarian word found.");
      }
   }
   static string FindAbecedarianWord (string[] words) {
      foreach (string word in words) {
         if (IsAbecedarian (word)) {
            return word;
         }
      }
      return null;
   }
   static bool IsAbecedarian (string word) {
      for (int i = 1; i < word.Length; i++) {
         if (word[i] < word[i - 1]) {
            return false;
         }
      }
      return true;
   }
}
