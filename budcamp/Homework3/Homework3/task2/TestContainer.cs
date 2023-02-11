using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class TestContainer
    {
        private static Dictionary<string, List<Test>> testContainer = new Dictionary<string, List<Test>>();

        public static void AddTest(Test test)
        {
            if (!testContainer.ContainsKey(test.Topic))
            {
                testContainer.Add(test.Topic, new List<Test>());
            }

            testContainer[test.Topic].Add(test);
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
