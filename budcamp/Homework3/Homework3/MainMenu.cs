﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class MainMenu
    {
        public MainMenu() { }

        public void PrintMenu()
        {
            Console.WriteLine("You are in main menu. To select test - enter '1'. " +
                "To see results - enter '2'");
            string userInput = Console.ReadLine();
            
            if(userInput == "1")
            {
                Console.WriteLine("Pls enter the topic u want to choose");
                string input = Console.ReadLine();

                TestContainer testContainer = new TestContainer();
                testContainer.GetTestByTopic(input);

                Console.WriteLine("Are you ready to begin? Enter a key!");
                Console.ReadKey();
                TestRunner testRunner = new TestRunner(testContainer);
                testRunner.RunTest(input);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Pls enter the topic u want to see your score");
                string input = Console.ReadLine();

                TestResults testResults = new TestResults();
                testResults.GetResults(input);
            }
            else
            {
                Console.WriteLine("not correct input");
            }
        }

    }
}

