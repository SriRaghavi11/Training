using System;
namespace NumberGuessingGame {
   class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Welcome to the number Guessing game.Find the number I have in mind by guessing it");
         int guess;
         int n = new Random ().Next (1, 100);
         for (int i = 0; ; i++) {
            Console.Write ("Enter your guess:");
            bool var = int.TryParse (Console.ReadLine (), out guess);
            if (var == false) 
            Console.WriteLine ("Invalid format or number");
            if (guess < n)
               Console.WriteLine ("Your guess is low");
            else if (guess > n)
               Console.WriteLine ("Your guess is high");
            else Console.WriteLine ($"Your guess is correct and you got it in {i} tries");
         }
      }
   }
}