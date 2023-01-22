using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class TestContainer
    {
        private Dictionary<string, List<Test>> dictOfTests;

        public TestContainer()
        {
            dictOfTests = new Dictionary<string, List<Test>>();
        }

        public IEnumerable<Test> AddTest(Test test)
        {
            if (!dictOfTests.ContainsKey(test.Topic))
            {
                dictOfTests[test.Topic] = new List<Test>();
                dictOfTests[test.Topic].Add(test);
            }
            else
            {
                //dictOfTests[test.Topic].Add(test);
                Console.WriteLine("this test is alredy exists or ID reserved");
            }

            return //Enumerable.Empty<Test>();
        }

        public List<Test> GetTestByTopic(string topic)
        {
            if (dictOfTests.ContainsKey(topic))
            {
                return dictOfTests[topic];
            }
            else
            {
                Console.WriteLine("no test found with this TOPIC");
            }

            return null;
        }
    }
}
