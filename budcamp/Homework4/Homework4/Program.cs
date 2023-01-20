using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PhoneEmergencyTestHolder phones = new PhoneEmergencyTestHolder(new List<IPhone>());

            Nokia3310 nokia1 = new Nokia3310(4, "fathersPhone");
            Nokia3310 nokia2 = new Nokia3310(8, "mothersPhone");
            Nokia3310 nokia3 = new Nokia3310(25, "brothersPhone");
            Iphone88 iphone1 = new Iphone88(4, "sistersPhone");
            Iphone88 iphone2 = new Iphone88(8, "michaelsPhone");
            Iphone88 iphone3 = new Iphone88(25, "olegsPhone");

            phones.AddPhone(nokia1);
            phones.AddPhone(nokia2);
            phones.AddPhone(nokia3);
            phones.AddPhone(iphone1);
            phones.AddPhone(iphone2);
            phones.AddPhone(iphone3);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    nokia1.TestEmergency(phones);
                }
                catch (BatteryIsDeadException ex)
                {
                    Console.WriteLine($"Battery is low {ex}");
                }
                finally
                {
                    nokia1.Charge();
                }
                
            }
            
        }


        
    }
}