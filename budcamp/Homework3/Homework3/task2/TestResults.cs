using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class TestResults
    {
        private Dictionary<string, int> results;

        public TestResults()
        {
            results = new Dictionary<string, int>();
        }

        public void AddResults(string topic, int mark)
        {
            results[topic] = mark;
        }

        public int GetResults(string topic)
        {
            if (results.ContainsKey(topic))
            {
                return results[topic];
            }
            
            return 100500;
        }
    }
}
