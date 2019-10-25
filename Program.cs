using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, you see the main menu, by selecting below numbers you will navigate to related functions:");


            do
            {
                int userInput = Util.AskForInt("\n 0: Exit the program"
                                              + "\n 1: Get ticket price"
                                              + "\n 2: Print your entered word 10 times"
                                              + "\n 3: Print the third word in your entered sentence");

                switch (userInput)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        userInput = Util.AskForInt("\n 0: return to main menu"
                                                 + "\n 1:Individual Price"
                                                 + "\n 2: Company Price");
                        switch (userInput)
                        {
                            case 0:
                                break;
                            case 1:
                                userInput = Util.AskForInt("Enter your age:");
                                calculateIndividualPrice(userInput);
                                break;
                            case 2:
                                userInput = Util.AskForInt("Enter numbers of personls:");
                                Console.WriteLine($"\n\nTotal Ticket Price for {userInput} Personals is: {calculatePersonalsPrice(userInput)}kr"); 
                                break;
                            default:
                                break;
                        }
                        break;

                    case 2:
                        var arbitraryText = Util.AskForString("Enter an arbitray text, so it will be printed 10 times:");
                        RepeatTenTimes(arbitraryText);
                        break;
                    case 3:
                        var sentence = Util.AskForString("Enter a statement with at least 3 words:");
                        splitSentence(sentence);
                        break;

                    default:
                        break;
                }
            }
            while (true); //Endless loop
        }

        private static void splitSentence(string sentence)
        {
            string[] sentenceList = sentence.Split(" ");
            if(sentenceList.Length > 2)
                Console.WriteLine($"\n The third word in the sentence you have entered is: {sentenceList[2]}");
            else
             Console.WriteLine("The sentence should have at least 3 words");                
        }

        private static void RepeatTenTimes(string arbitraryText)
        {
            for (int i = 0; i < 10; i++)
                Console.Write($"{i +1}. {arbitraryText} ");
            Console.WriteLine();
        }

        private static int calculatePersonalsPrice(int personalNumbers)
        {
            // List<int> personalsTicketPrice = new List<int>();
            int personalsTicketPrice = 0;
            int age;
            for (int i=0; i< personalNumbers; i++)
            {
                age = Util.AskForInt($"\n Enter Personal{i + 1} age:");
                personalsTicketPrice += calculateIndividualPrice(age);
            }

            return personalsTicketPrice;
        }

        private static int calculateIndividualPrice(int age)
        {
            int price = -1;

            if (age < 20)
            {
                price = 80;
                Console.WriteLine("Teenagers Price: 80kr");
            }                
            else if (age > 64)
            {
                price = 90;
                Console.WriteLine("Pensions Price: 90kr");
            }            
            else
            {
                price = 120;
                Console.WriteLine("Standars Price: 120kr");
            }

            return price;
        }
    }
}
