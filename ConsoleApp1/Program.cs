using System;
namespace DigitalRootFinder {
   class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter the number:");
         int number=int.Parse(Console.ReadLine());
         int DigitalRoot=CalculateDigitalRoot (number);
         Console.WriteLine ($"The digital root of {number} is {DigitalRoot}");
      }
      static int CalculateDigitalRoot(int num) {
         while (num >= 10) {
            int sum = 0;
            while (num > 0) {
               sum += num % 10;
               num /= 10;
            }
            num = sum;
         }
         return num;
      }
   }
}
