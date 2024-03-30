using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User enters custom password
            string password = Console.ReadLine();

            PassworCheckerLogic(password);

            // Waiting for user input to close program
            Console.ReadKey();
        }

        static void PassworCheckerLogic(string userPassword)
        {
            // Logic to log if entered password has uppercase letter
            bool passwordHasUppercaseLetter = userPassword.Any(char.IsUpper);
            bool passwordCheckerUppercaseLetter = passwordHasUppercaseLetter == true;

            // Logic to log if entered password has number
            bool passwordHasNumber = userPassword.Any(char.IsDigit);
            bool passwordCheckerNumber = passwordHasNumber == true;

            // Logic to log if entered password has special character
            bool passwordHasSpecialCharacters = userPassword.Any(ch => !Char.IsLetterOrDigit(ch));
            bool passwordCheckerSpecialCharacter = passwordHasSpecialCharacters == true;

            // Confirming that password is successful (no special characters and atleast one uppercase)
            bool successfulPassword = passwordCheckerSpecialCharacter && passwordCheckerUppercaseLetter && passwordCheckerNumber;

            // Console shows that entered password meets requirements
            Console.WriteLine(successfulPassword);
        }
    }
}
