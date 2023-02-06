using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class TestResults
    {
        public List<Test> Tests { get; set; }
        public string Topic { get; set; }
        public int CorrectAnswers { get; set; }
        public DateTime DateOfTest { get; set; }

        private Dictionary<string, TestResults> testResults = new Dictionary<string, TestResults>();

        public TestResults(Dictionary<string, TestResults> results)
        {
            this.testResults = results;
        }

        public void AddResults(string topic, TestResults mark)
        {
            testResults[topic] = mark;
        }

        public TestResults GetResults(string topic)
        {
            if (testResults.ContainsKey(topic))
            {
                return testResults[topic];
            }
            
            return null;
        }
    }
}
