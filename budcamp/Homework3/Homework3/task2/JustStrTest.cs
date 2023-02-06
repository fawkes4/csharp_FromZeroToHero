using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class JustStrTest: Test
    {
        public JustStrTest(int identifier, string topic, string question, string correctAnswer) 
            : base(identifier, topic, question, correctAnswer)
        {

        }

        public override void PrintTest()
        {
            Console.WriteLine(Topic);
            Console.WriteLine();
            Console.WriteLine(Question);
            Console.WriteLine();
        }

        public override bool CheckAnswer(string userAnswer)
        {
            return userAnswer == CorrectAnswer;
        }
    }
}
