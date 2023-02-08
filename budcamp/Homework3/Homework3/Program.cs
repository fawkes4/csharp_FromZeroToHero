using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            Task2();
        }

        //public static void Task1()
        //{
        //    Ukraine ukraine = new Ukraine(45000000, "Ще не вмерли України", "blue and yellow", "not enough");
        //}

        public static void Task2()
        {
            /*test 1*/
            string[] options = { "1356", "1265", "12 century", "1256" };
            CaseTest caseTest = new CaseTest(0001, "history", "when was Lviv founded?", "1256", options);
            TestContainer.AddTest(caseTest);

            /*test 2*/
            string[] options2 = { "1814-1861", "1816-1861", "1861-1917", "20century" };
            CaseTest caseTest2 = new CaseTest(0001, "history", "What are years of living T.Shevchenko", "1814-1861", options);
            TestContainer.AddTest(caseTest);

            MainMenu.PrintMenu();
        }
    }
}