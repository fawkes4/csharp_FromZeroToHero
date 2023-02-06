using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class CaseTest: Test
    {
        public string[] Options { get; set; }

        const int countOfTestOptions = 4;

        public CaseTest(int identifier, string topic, string question, string correctAnswer, string[] variants): 
            base(identifier, topic, question, correctAnswer)
        {
            this.Options = variants;

            if (variants.Count() != countOfTestOptions)
            {
                throw new Exception("має бути 4-ри варіанти");
            }
        }

        public override void PrintTest()
        {
            Console.WriteLine(Topic); //useless
            Console.WriteLine();
            Console.WriteLine(Question);
            Console.WriteLine();
            Console.WriteLine($"a) {Options[0]}");
            Console.WriteLine($"b) {Options[1]}");
            Console.WriteLine($"c) {Options[2]}");
            Console.WriteLine($"d) {Options[3]}");
        }

        public override bool CheckAnswer(string userAnswer)
        {
            return userAnswer == CorrectAnswer;
        }
    }
}
