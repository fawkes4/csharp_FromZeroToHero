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

        public TestResults RunTest(string topic)
        {
            int correctAnswers = 0;

            List<Test> chosenTopicTests = testContainer.GetTestByTopic(topic);

            foreach (Test test in chosenTopicTests)
            {
                test.PrintTest();
                string userAnswer = Console.ReadLine();

                if (test.CheckAnswer(userAnswer))
                {
                    correctAnswers++;
                }
            }

            Console.Clear();
            mainMenu.PrintMenu();

            TestResults result = new TestResults()
            {
                Topic = topic,
                Tests = tests,
                Date = DateTime.Now,
                CorrectAnswers = correctAnswers
            };
            return result;
        }
    }
}
