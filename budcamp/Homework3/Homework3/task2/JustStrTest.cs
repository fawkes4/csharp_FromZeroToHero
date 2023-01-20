using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class JustStrTest: Test
    {
        public JustStrTest Type { get; set; }

        public JustStrTest(int identifier, string topic, string question, string correctAnswer,
            JustStrTest type) :
            base(identifier, topic, question, correctAnswer)
        {
            this.Type = type;
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
            return userAnswer == CorrectAnswer ? true : false;
        }
    }
}
