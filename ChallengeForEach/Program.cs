using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace ChallengeForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Procedure();
            
        }
        public static void Procedure()
        {
            // Entering the Input
            Console.WriteLine("Enter the first input:");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Select the type of the first input:");
            Console.WriteLine("1 for string");
            Console.WriteLine("=============");
            Console.WriteLine("2 for integer");
            Console.WriteLine("=============");
            Console.WriteLine("3 for boolean");
            Console.WriteLine("=============");
            string choiceUser = Console.ReadLine();
            
            switch(choiceUser) 
            {
                case "1": Console.WriteLine($"You have entered: {userInput1}");
                    if (Regex.IsMatch(userInput1, @"^[\p{L}]+$") == true)
                    {
                        Console.WriteLine("It is a valid string");
                    }else
                    {
                        Console.WriteLine("It is not a valid string");
                    }
                    break;
                case "2": Console.WriteLine($"You have entered: {userInput1}");
                    bool success = int.TryParse(userInput1 , out int result);
                    if(success == true)
                    {
                        Console.WriteLine("It is a valid integer");
                    }
                    else
                    {
                        Console.WriteLine("It is not a valid integer");
                    }                                  
                    break;
                case "3": Console.WriteLine($"You have entered: {userInput1}");
                    bool success2 = bool.TryParse(userInput1, out bool parsedBool);
                    if (success2 == true)
                    {
                        Console.WriteLine("It is a valid boolean");
                    }
                    else
                    {
                        Console.WriteLine("It is not a valid boolean");
                    }

                    break;
                default: Console.WriteLine("Enter a valid option next time");
                    Console.ReadKey();
                    Console.Clear();
                    Procedure();
                    break;
            }
        }
    }
}
