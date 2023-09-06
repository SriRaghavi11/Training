using System;
namespace StrongPasswordCheck {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter the password:");
         string password = Console.ReadLine ();
         if (isStrongPassword (password))
            Console.WriteLine ("The password is strong.");
         else {
            Console.WriteLine ("The password is not strong");
            if (!isStrongPassword (password)) {
               if (password.Length < 6) {
                  Console.Write ("Please ensure the password has 6 characters");
               }
               if (!hasDigit (password)) {
                  Console.Write ("Please ensure you have entered a number.");
               }
               if (!hasUppercase (password)) {
                  Console.Write ("Kindly ensure you entered an uppercase letter.");
               }
               if (!hasLowercase (password)) {
                  Console.Write ("Kindly ensure you entered a lowercase letter.");
               }
               if (!hasSpecialCharacter (password)) {
                  Console.Write ("Kindly ensure you entered a special character (!@#$%^&*()-+)");
               }
            }
         }
         static bool isStrongPassword (string password) {
            if (password.Length < 6)
               return false;
            return hasDigit (password) && hasUppercase (password) && hasLowercase (password) && hasSpecialCharacter (password);
         }
         static bool hasDigit (string password) {
            foreach (char c in password) {
               if (char.IsDigit (c))
                  return true;
            }
            return false;
         }
         static bool hasUppercase (string password) {
            foreach (char c in password) {
               if (char.IsUpper (c))
                  return true;
            }
            return false;
         }
         static bool hasLowercase (string password) {
            foreach (char c in password) {
               if (char.IsLower (c))
                  return true;
            }
            return false;
         }
         static bool hasSpecialCharacter (string password) {
            foreach (char c in password) {
               if ("!@$%^*()+".Contains (c))
                  return true;
            }
            return false;
         }
      }
   }
}
