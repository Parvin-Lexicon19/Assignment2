using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    //Static class cant make instances of. Exactly as the Console class for example
    class Util
    {
        //internal visible in the same assembly
        //must be static in a static class
        //string return type
        //AskForString method name
        //static internal bool exitProgram = false;
        internal static string AskForString(string prompt)
        {
            bool correct = true;
            string answer; //Scope

            do //Repeat
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                //If answer is not null or empty string
                if (!string.IsNullOrEmpty(answer))
                {
                    //Set bool correct to false to exit loop
                    correct = false;
                }

            } while (correct); //until we have get a correct value

            return answer; //return value
        }

        internal static int AskForInt(string prompt)
        {
            bool success;
            int answer; //Scope

            do //Repeat
            {
                string input = AskForString(prompt);

                //Try to parse string to int returns bool
                //If true exit loop
                success = int.TryParse(input, out answer);

                //If we not successfully parsed string input to int answer
                if (!success)
                {
                    //Write errormessage
                    Console.WriteLine("Wrong format only numbers");
                }

            } while (!success);

            //Returns parsed string
            return answer;

            /*do //Repeat
            {
                string input = AskForString(prompt);

                //Try to parse string to int returns bool
                //If true exit loop
                success = int.TryParse(input, out answer);

                //If we not successfully parsed string input to int answer or the input is 0
                if (!success || answer.Equals(0))
                {
                    switch (answer)
                    {
                        case 0:
                            //Environment.Exit(-1);
                            exitProgram = true;
                            break;

                        default:
                            //Write errormessage
                            Console.WriteLine("Wrong format only numbers");
                            break;
                    }
                }

            } while (!success);

            //Returns parsed string
            return answer;*/
        }
    }
}
