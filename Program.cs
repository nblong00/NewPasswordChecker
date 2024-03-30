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
            Console.WriteLine("Please enter a password you'd like to test: ");
            string password = Console.ReadLine();

            // Calling main logic method to check password aganist requirements
            PassworCheckerLogic(password);

            // Asks user if they want to check a new password
            PlayerContinue();

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

        static void PlayerContinue(bool anotherComputation = false)
        {
            Console.WriteLine("Would you like the check another password?: ");

            // Logic to check if player wants to perform another calculation. 
            // Forces user to provide expected answer or go through the loop again
            while (!anotherComputation)
            {
                // Variable to hold user's answer
                string playerAnswer = Console.ReadLine();
                switch (playerAnswer)
                {
                    case "yes":
                        anotherComputation = true;

                        break;
                    case "ye":
                        anotherComputation = true;
                        break;
                    case "y":
                        anotherComputation = true;
                        break;
                    case "no":
                        Console.WriteLine("So be it.");
                        anotherComputation = true;
                        break;
                    case "n":
                        Console.WriteLine("So be it.");
                        anotherComputation = true;
                        break;
                    default:
                        Console.WriteLine("No valid answer provided. Type 'yes' or 'no' dependent on if you want to check another password.");
                        break;
                }
            }
        }
    }
}
