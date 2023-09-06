using System;
class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the number of words: ");
      int numberOfWords = int.Parse (Console.ReadLine ());
      string[] words = new string[numberOfWords];
      for (int i = 0; i < numberOfWords; i++) {
         Console.Write ($"Enter word #{i + 1}: ");
         words[i] = Console.ReadLine ();
      }
      string longestAbecedarianWord = FindLongestAbecedarianWord (words);
      if (!string.IsNullOrEmpty (longestAbecedarianWord)) {
         Console.WriteLine ("Longest Abecedarian Word: " + longestAbecedarianWord);
      } else {
         Console.WriteLine ("No abecedarian word found in the input.");
      }
   }
   static string FindLongestAbecedarianWord (string[] words) {
      string longestAbecedarianWord = "";
      int maxLength = 0;
      foreach (string word in words) {
         if (IsAbecedarian (word) && word.Length > maxLength) {
            maxLength = word.Length;
            longestAbecedarianWord = word;
         }
      }
      return longestAbecedarianWord;
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
