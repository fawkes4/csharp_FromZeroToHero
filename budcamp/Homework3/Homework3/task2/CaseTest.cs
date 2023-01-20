using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class CaseTest: Test
    {
        public CaseTest Type { get; set; }
        public string[] Variants { get; set; }

        public CaseTest(int identifier, string topic, string question, string correctAnswer, 
            CaseTest type, string[] variants): 
            base(identifier, topic, question, correctAnswer)
        {
            this.Type = type;
            this.Variants = variants;
        }

        public override void PrintTest()
        {
            Console.WriteLine(Topic);
            Console.WriteLine();
            Console.WriteLine(Question);
            Console.WriteLine();
            Console.WriteLine($"a) {Variants[0]}");
            Console.WriteLine($"b) {Variants[1]}");
            Console.WriteLine($"c) {Variants[2]}");
            Console.WriteLine($"d) {Variants[3]}");
        }

        public override bool CheckAnswer(string userAnswer)
        {
            return userAnswer == CorrectAnswer? true : false;
        }
    }
}
