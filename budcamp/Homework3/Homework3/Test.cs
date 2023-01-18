using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Test
    {
        public int ID { get; set; }
        public string Topic { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }

        public Test(int identifier, string topic, string question, string correctAnswer)
        {
            this.ID = identifier;
            this.Topic = topic;
            this.Question = question;
            this.CorrectAnswer = correctAnswer;
        }
        public virtual void PrintTest() { }

        public virtual bool CheckAnswer(string userAnswer)
        {
            return userAnswer == CorrectAnswer;
        }
    }
}
