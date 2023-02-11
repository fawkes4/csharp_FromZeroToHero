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

        public TestRunner(TestContainer testContainer)
        {
            this.testContainer = testContainer;
        }

        public void RunTest(string topic)
        {
            int correctAnswers = 0;

            var chosenTopicTests = testContainer.GetTestByTopic(topic);

            foreach (Test test in chosenTopicTests)
            {
                test.PrintTest();
                string userAnswer = Console.ReadLine();

                if (test.CheckAnswer(userAnswer))
                {
                    correctAnswers++;
                }

                TestResults result = new TestResults         // TestResult result = new TestResult();
                {
                    Tests = (List<Test>)chosenTopicTests,    // result.Tests = tests
                    Topic = topic,                           // result.Topic = topic
                    CorrectAnswers = correctAnswers,
                    DateOfTest = DateTime.Now
                };
            }

            Console.Clear();

            Console.WriteLine("Press any button to go to the main menu");
            Console.ReadKey();
            Console.Clear();

            MainMenu.PrintMenu();
        }
    }
}
