using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Task2();

            Task3();

            Task4();

            Task5();

            Task6();

            Task7();

            Task8();

            Task9();

            Task10();

            Task11();

            Task12();

            Task13();
        }

        public static void Task1()
        {
            int number = 24;
            Console.WriteLine($"variable name is: {nameof(number)} and its value is: {number}");
        }

        private static void Task2()
        {
            Console.WriteLine("enter first num");
            double input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num");
            double input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third num");
            double input3 = int.Parse(Console.ReadLine());

            double multiplication = input1 * input2 * input3;

            Console.WriteLine($"The multiplication of your numbers is: {multiplication}");
        }

        private static void Task3()
        {
            Console.WriteLine("Enter your string");
            string input = Console.ReadLine();
            int length = input.Length;

            var result = input[length - 1] + input.Substring(1, length - 2) + input[0];

            Console.WriteLine($"Result of swaping first and last chars is: {result}");
        }

        private static void Task4()
        {
            Console.WriteLine("Pls enter first integer");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pls enter second integer");
            int num2 = int.Parse(Console.ReadLine());

            double result = 0;

            double sum = num1 + num2;
            Console.WriteLine($"Their sum: {sum}");

            if (num1 == num2)
            {
                result = (sum) * 3;
            }
            else
            {
                result = (sum) / 8;
            }

            Console.WriteLine($"result of exercise: {result}");
        }

        private static void Task5()
        {
            Console.WriteLine("enter first int");
            double number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second int");
            double number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third int");
            double number3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Largest value = {Math.Max(number1, Math.Max(number2, number3))}");
            Console.WriteLine($"Lowest value = {Math.Min(number1, Math.Min(number2, number3))}");
        }

        private static void Task6()
        {
            Console.WriteLine("plz input your string");
            string inputString = Console.ReadLine();
            Console.WriteLine($"Result of the ex: {StrToUpperCase(inputString)}");
        }

        public static string StrToUpperCase(string input)
        {
            int length = input.Length;
            int condition = 5;

            if (length == condition)
            {
                return input.ToUpper();
            }
            else if (length > condition)
            {
                return input.Substring(0, 4).ToUpper() + input.Substring(5, length - 5);
            }

            return input;
        }

        private static void Task7()
        {
            Console.WriteLine("enter your int to check if it is multiple of 3 or 7");
            int newInput = int.Parse(Console.ReadLine());
            Console.WriteLine(IsMultipleOf3Or7(newInput));
        }
        public static bool IsMultipleOf3Or7(int input)
        {
            return input % 3 == 0 || input % 7 == 0;
        }

        private static void Task8()
        {
            Console.WriteLine("enter your string to check if it starts with 'C#'");
            string str = Console.ReadLine();
            Console.WriteLine($"result: {CheckStartOfString(str)}");
        }

        public static bool CheckStartOfString(string input)
        {
            string condition = "C#";

            return input.StartsWith(condition);
        }

        private static void Task9()
        {
            Console.WriteLine("enter the circle radius");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"Perimeter = {2 * radius * Math.PI} \nArea = {2 * Math.PI * radius * radius}");
        }

        private static void Task10()
        {
            Console.WriteLine(SumAndAverageOf10Num());
        }

        public static string SumAndAverageOf10Num()
        {
            double sum = 0;
            double average;

            Console.WriteLine("Input your numbers");

            for (int i = 0; i < 10; i++)
            {
                double num = Double.Parse(Console.ReadLine());
                sum += num;
            }

            average = sum / 10;

            return $"Sum = {sum}\nAverage = {average}";
        }

        private static void Task11()
        {
            MultiplicationTable();
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("input number of how you want to see size of mult.table:");
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i * j < 10)
                    {
                        Console.Write($"{i}x{j}={i * j}  ");
                    }
                    else
                    {
                        Console.Write($"{i}x{j}={i * j} ");
                    }
                }

                Console.WriteLine();
            }
        }

        private static void Task12()
        {
            Console.WriteLine("enter first num");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(NumbersDivBy8BetweenInt(firstNum, secondNum));
        }
        public static string NumbersDivBy8BetweenInt(int input1, int input2)
        {
            int count = 0;
            int condition = 8;

            for (int i = input1; i <= input2; i++)
            {
                if (i % condition == 0)
                {
                    count++;
                    Console.WriteLine($"there is: {i}");
                }
            }

            return $"total count of numbers is: {count}";
        }

        private static void Task13()
        {
            ChanelAverageRating(TVChannels.Loliandia);
            ChanelAverageRating(TVChannels.Dota2Channel);
            ChanelAverageRating(TVChannels.CSharpCourses);
            ChanelAverageRating(TVChannels.AwesomeDudes);
            ChanelAverageRating(TVChannels.XXXForYou);
        }
        public enum TVChannels
        {
            Loliandia, Dota2Channel, CSharpCourses, AwesomeDudes, XXXForYou
        }

        public static void ChanelAverageRating(TVChannels chanel)
        {
            switch (chanel)
            {
                case TVChannels.Loliandia:
                    {
                        Console.WriteLine("12/10");
                        break;
                    }
                case TVChannels.Dota2Channel:
                    {
                        Console.WriteLine("1/10");
                        break;
                    }
                case TVChannels.CSharpCourses:
                    {
                        Console.WriteLine("10/10");
                        break;
                    }
                case TVChannels.AwesomeDudes:
                    {
                        Console.WriteLine("its too funny/10");
                        break;
                    }
                case TVChannels.XXXForYou:
                    {
                        Console.WriteLine("misogyny how can you look at the suffering of these women?? CANCEL HIM!!!");
                        break;
                    }
            }
        }
    }
}