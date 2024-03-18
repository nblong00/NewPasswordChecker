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

            // Logic to log if entered password has uppercase letter
            bool passwordHasUppercaseLetter = password.Any(char.IsUpper);
            bool passwordCheckerUppercaseLetter = passwordHasUppercaseLetter == true;

            // Logic to log if entered password has number
            bool passwordHasNumber = password.Any(char.IsDigit);
            bool passwordCheckerNumber = passwordHasNumber == true;

            // Logic to log if entered password has special character
            bool passwordHasSpecialCharacters = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool passwordCheckerSpecialCharacter = passwordHasSpecialCharacters == true;

            // Confirming that password is successful (no special characters and atleast one uppercase)
            bool successfulPassword = passwordCheckerSpecialCharacter && passwordCheckerUppercaseLetter && passwordCheckerNumber;

            // Console shows that entered password meets requirements
            Console.WriteLine(successfulPassword);

            // Waiting for user input to close program
            Console.ReadKey();
        }
    }
}
