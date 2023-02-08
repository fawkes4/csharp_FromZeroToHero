using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    [Serializable]
    internal class BatteryIsDeadException: Exception
    {
        public IPhone Phone { get; }

        public BatteryIsDeadException(IPhone phone)
        {
            Phone = phone;
        }
    }
}
