using System;
namespace ArmstrongNumberFinder {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number:");
         int number = int.Parse (Console.ReadLine ());
         if (isArmstrongNumber (number)) { Console.WriteLine ("It is an armstrong number"); } else { Console.WriteLine ("It is not an armstrong number"); }
      }
      private static bool isArmstrongNumber (int num) {
         int originalNum = num;
         int sum = 0;
         int numDigits = num.ToString ().Length;
         while (num > 0) {
            int digit = num % 10;
            sum += (int)Math.Pow (digit, numDigits);
            num /= 10;
         }
         return sum == originalNum;
      }
   }
}