using System;
namespace Fibonacciseries {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Enter the number of terms:");
            int number = int.Parse (Console.ReadLine ());
            int a = 0, b = 1;
            Console.Write ($"Fibonacci series : {a} {b} ");
            for (int i = 2; i < number; i++) {
                int c = a + b;
                Console.Write ($"{c} ");
                a = b;
                b = c;
            }
            Console.ReadLine ();
        }
    }
}
