using System;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main()
        {//CONDITIONAL STATEMENTS CHALLENGE
         //Using Visual studio, write and execute C# code that utilizes if, else if and else statements and displays output to the console.
            string fruit = "apple";
                if (fruit == "orange")
                {
                    Console.WriteLine("You prefer orange over apple.");
                }
                else if (fruit == "pear")
                {
                    Console.WriteLine("You do not prefer orange or apple.");
                }
                else
                {
                    Console.WriteLine("You do not prefer apple or pear.");
                }

            }
        }
    }

    

