using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class MainMenu
    {
        public static void PrintMenu() //логіку треба поміняти, бо не паше
        {
            TestResults testResults = new TestResults();
            TestContainer testContainer = new TestContainer();
            TestRunner testRunner = new TestRunner(testContainer);

            /*test 1*/
            string[] options = { "1356", "1265", "12 century", "1256" };
            CaseTest caseTest = new CaseTest(0001, "history", "when was Lviv founded?", "1256", options);
            TestContainer.AddTest(caseTest);

            /*test 2*/
            string[] options2 = { "1814-1861", "1816-1861", "1861-1917", "20century" };
            CaseTest caseTest2 = new CaseTest(0001, "history", "What are years of living T.Shevchenko", "1814-1861", options2);
            TestContainer.AddTest(caseTest2);

            Console.WriteLine("You are in main menu. To select test - enter '1'. " +
                "To see results - enter '2'");
            string userInput = Console.ReadLine();


            if (userInput == "1")
            {
                Console.WriteLine("Pls enter the topic u want to choose");
                string input = Console.ReadLine();
                Console.WriteLine("Are you ready to begin? Enter a key!");
                Console.ReadKey();
                testRunner.RunTest(input);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Pls enter the topic u want to see your score");
                string input = Console.ReadLine();

                testResults.PrintResult(input);
            }
            else
            {
                Console.WriteLine("not correct input");
            }
        }
    }
}


