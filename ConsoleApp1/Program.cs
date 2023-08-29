using System;
namespace StrongPasswordCheck {
   class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter the password:");
         string password = Console.ReadLine ();
         if (isStrongPassword (password))
            Console.WriteLine ("The password is strong.");
         else Console.WriteLine ("The password is not strong.Please ensure that the pasword contains atleast six characters-atleast one digit,atleast one upper and lowercase letter and atleast one special character !@#$%^&()-+");
      }
      static bool isStrongPassword (string password) {
         if (password.Length < 6)
            return false;
         bool hasDigit = false;
         bool hasUppercase = false;
         bool hasLowercase = false;
         bool hasSpecialcharacter = false;
         foreach (char c in password) {
            if (char.IsDigit (c))
               hasDigit = true;
            else if (char.IsUpper (c))
               hasUppercase = true;
            else if (char.IsLower (c))
               hasLowercase = true;
            else if ("!@$%^7890-+".Contains (c))
               hasSpecialcharacter = true;
         }
         return hasDigit && hasUppercase && hasLowercase && hasSpecialcharacter;
      }
   }
}