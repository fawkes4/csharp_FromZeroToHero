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

        public static void Task1()
        {
            Ukraine ukraine = new Ukraine(45000000, "Ще не вмерли України", "blue and yellow", "not enough");
        }

        public static void Task2()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.PrintMenu();
        }
    }
}