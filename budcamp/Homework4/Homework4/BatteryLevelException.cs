using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    [Serializable]
    internal class BatteryLevelException: Exception
    {
        public int BatteryLevel { get; set; }

        public BatteryLevelException() { }

        public BatteryLevelException(int batteryLevel)
        {
            BatteryLevel = batteryLevel;

            Console.WriteLine($"battery could not exist at that level {batteryLevel}");
        }
    }
}
