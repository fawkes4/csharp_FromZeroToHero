using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class TestRunner
    {
        private TestContainer testContainer;
        private TestResults testResults;

        int correctAnswers = 0;
        string userAnswer = "";

        public TestRunner(TestContainer testContainer)
        {
            this.testContainer = testContainer;
            testResults = new TestResults();
        }

        public void RunTest(string topic)
        {
            List<Test> chosenTopic = testContainer.GetTestByTopic(topic);

            foreach (Test test in chosenTopic)
            {
                test.PrintTest();

                if (test.CheckAnswer(userAnswer))
                {
                    correctAnswers++;
                }
            }

            testResults.AddResults(topic, correctAnswers);
            Console.Clear();

            Console.WriteLine($"Your score is {correctAnswers}");
            Console.WriteLine();
            Console.WriteLine("Press any key");

            MainMenu mainMenu = new MainMenu();
            mainMenu.PrintMenu();
        }
    }
}
