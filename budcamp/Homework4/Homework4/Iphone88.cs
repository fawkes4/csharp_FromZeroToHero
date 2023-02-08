using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Iphone88: IPhone
    {
        public int BatteryLevel { get; set; }
        public string PhoneName { get; set; }

        public Iphone88(int batteryLevel, string phoneName)
        {
            this.BatteryLevel = batteryLevel;
            this.PhoneName = phoneName;

            if (batteryLevel < 0 && batteryLevel > 100)
            {
                throw new BatteryLevelException(batteryLevel);
            }
        }

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

        public void TestEmergency(PhoneEmergencyTestHolder phoneEmergencyTestHolder)
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
                finally
                {
                    if (phone is Nokia3310)
                    {
                        ChargeABit();
                    }
                }
            }
        }
    }
}
