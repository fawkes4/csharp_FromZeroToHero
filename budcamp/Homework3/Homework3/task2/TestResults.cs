using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /* клас, який зберігає результати тестів.*/
    internal class TestResults
    {
        //public int ID { get; set; } - треба добавити можливість брати ІД тесту.
        public List<Test>? Tests { get; set; }
        public string? Topic { get; set; }
        public int CorrectAnswers { get; set; }
        public DateTime DateOfTest { get; set; }

        Test? test;

        //місце зберігання результатів
        private Dictionary<string, TestResults> testResults = new Dictionary<string, TestResults>();

        public void PrintResult(string topic)
        {
            try
            {
                var results = testResults[topic];

                Console.WriteLine("Your passed tests:");
                Console.WriteLine($"Id: {test.ID}");
                Console.WriteLine($"Topic: {results.Topic}");
                Console.WriteLine($"Date: {results.DateOfTest}");
                Console.WriteLine($"Result: {results.CorrectAnswers}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
