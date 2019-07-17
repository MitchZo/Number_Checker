using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///input
            ///Ask user for name
            /// </summary>
            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();

            ///<summary>
            ///ask the user for a number
            /// </summary>
            Console.WriteLine($"Thank you {userName}. Please enter a whole number between 1 an 100.");
            string userinput = Console.ReadLine();

            ///<summary>
            ///validation has yet to occur so it cannot be valid
            /// </summary>
            bool isValid = false;
            
            ///<summary>
            ///loop to run through validating the number in multiple ways
            /// </summary>
            while (!isValid)
            {    
                ///<summary>
                ///validate it's a number. if it is, convert it to an int
                ///</summary>
                bool isNumber = int.TryParse(userinput, out int chosenNumber);
                ///<summary>
                ///validate the number is between 1 and 100
                /// </summary>
                bool isBetween = (chosenNumber <= 100 && chosenNumber >= 1);
                ///<summary>
                ///if both previous validations pass, one varaible determines whether to loop or not
                /// </summary>
                isValid = (isNumber && isBetween);

                if (isValid)
                {
                    ///<summary>
                    ///evaluate the numbers for which ranges they fall in
                    /// </summary>

                    if ((chosenNumber % 2 == 0) && (chosenNumber < 25))
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if((chosenNumber % 2 == 0) && (chosenNumber > 25 &&chosenNumber <=60))
                    {
                        Console.WriteLine("Even");
                    }
                    else if ((chosenNumber %2 == 0) && (chosenNumber >60))
                    {
                        Console.WriteLine(chosenNumber + " Even");
                    }
                    else 
                    {
                        Console.WriteLine(chosenNumber + " Odd");
                    }
                Console.WriteLine($"Thank you for using the GC Number Analyzer {userName}. Goodbye.");
                }
                else
                {
                    ///<summary>
                    ///ask the user for another number
                    /// </summary>
                    Console.WriteLine($"I'm sorry {userName}, I can't do that. Please try again.");
                    Console.WriteLine($"Please enter a whole number between 1 an 100. And do it right this time.");
                    userinput = Console.ReadLine();
                    isValid = false;
                }
            }
        }
    }
}
