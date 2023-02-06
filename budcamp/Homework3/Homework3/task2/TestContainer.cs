using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class TestContainer
    {
        private Dictionary<string, List<Test>> testContainer = new Dictionary<string, List<Test>>();

        public TestContainer()
        {
            
        }

        public IEnumerable<Test> AddTest(Test test) //void
        {
            if (!testContainer.ContainsKey(test.Topic))
            {
                testContainer[test.Topic] = new List<Test>();
            }
            testContainer[test.Topic].Add(test);

            return Enumerable.Empty<Test>();
        }

        public IEnumerable<Test> GetTestByTopic(string topic)
        {
            if (testContainer.ContainsKey(topic))
            {
                return testContainer[topic];
            }

            return Enumerable.Empty<Test>();
        }
    }
}
