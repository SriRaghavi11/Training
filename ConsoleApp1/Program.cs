namespace MultiplicationTables {
   class Program {
      static void Main (string[] args) {
         for (int i = 1; i <= 10; i++) {
            Console.WriteLine ($"Multiplication Table for {i}\n");
            for (int j = 1; j <= 10; j++) 
               Console.WriteLine ($"{i,2} * {j,2} = {i * j,2}");
            Console.WriteLine ();
         }
      }
   }
}
