using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal interface IPhone
    {
        public int BatteryLevel { get; set; }
        public string PhoneName { get; set; }

        public void CallAmbulance()
        {
            if (BatteryLevel >= 5)
            {
                BatteryLevel -= 5;
                Console.WriteLine($"calling an ambulance from {PhoneName}, remaining charge: {BatteryLevel}%");
            }
            else
            {
                BatteryLevel = 0;
                throw new BatteryIsDeadException(this);
            }
        }

        public void Charge()
        {
            BatteryLevel = 100;
            Console.WriteLine($"Charging {PhoneName} to 100%");
        }

        public void ChargeABit()
        {
            BatteryLevel += 1;
            Console.WriteLine($"Charging {PhoneName} by 1%");
        }

        public virtual void TestEmergency(PhoneEmergencyTestHolder phoneEmergencyTestHolder)
        {
            foreach (IPhone phone in phoneEmergencyTestHolder)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException ex)
                {
                    Console.WriteLine($"Phone failed to call an ambulance: {ex.Phone}");
                    throw;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
