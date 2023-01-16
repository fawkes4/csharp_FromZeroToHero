using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 24;
            //Console.WriteLine($"variable name is: {nameof(number)} and its value is: {number}");

            //Console.WriteLine("enter first num");
            //double input1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second num");
            //double input2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter third num");
            //double input3 = int.Parse(Console.ReadLine());

            //double multiplication = input1 * input2 * input3;

            //Console.WriteLine($"The multiplication of your numbers is: {multiplication}");

            //Console.WriteLine("Enter your string");
            //string input = Console.ReadLine();

            //Console.WriteLine($"Result of swaping first and last chars is: {SwapFirstAndLastChar(input)}");

            //Console.WriteLine("Pls enter first integer");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pls enter second integer");
            //int num2 = int.Parse(Console.ReadLine());

            //double sum = num1 + num2;
            //Console.WriteLine($"Their sum: {sum}");

            //Console.WriteLine($"result of exercise: {TripleSumOfDivBy8(num1, num2, sum)}");

            //Console.WriteLine("enter first int");
            //double number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second int");
            //double number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter third int");
            //double number3 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Largest value = {LargestValue(number1, number2, number3)}");
            //Console.WriteLine($"Lowest value = {LowestValue(number1, number2, number3)}");

            //Console.WriteLine("plz input your string");
            //string inputString = Console.ReadLine();
            //Console.WriteLine($"Result of the ex: {StrToUpperCase(inputString)}");

            //Console.WriteLine("enter your int to check if it is multiple of 3 or 7");
            //int newInput = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsMultipleOf3Or7(newInput));

            //Console.WriteLine("enter your string to check if it starts with 'C#'");
            //string str = Console.ReadLine();
            //Console.WriteLine($"result: {CheckStartOfString(str)}");

            //Console.WriteLine("enter the circle radius");
            //int radius = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Perimeter = {2*radius*3.14} \nArea = {2*3.14*radius*radius}");

            //Console.WriteLine(SumAndAverageOf10Num()); 

            //MultiplicationTable();

            //Console.WriteLine("enter first num");
            //int firstNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second num");
            //int secondNum = int.Parse(Console.ReadLine());
            //Console.WriteLine(NumbersDivBy8BetweenInt(firstNum, secondNum));

            ChanelAverageRating(TVChannels.Loliandia);
            ChanelAverageRating(TVChannels.Dota2Channel);
            ChanelAverageRating(TVChannels.CSharpCourses);
            ChanelAverageRating(TVChannels.AwesomeDudes);
            ChanelAverageRating(TVChannels.XXXForYou);

        }

        public static string SwapFirstAndLastChar(string input)
        {
            int length = input.Length;

            return input[length - 1] + input.Substring(1, length - 2) + input[0];
        }

        public static double TripleSumOfDivBy8(int input1, int input2, double sum)
        {
            if (input1 == input2)
            {
                return (sum) * 3;
            }

            return (sum) / 8;
        }

        public static double LargestValue(double num1, double num2, double num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }

        public static double LowestValue(double num1, double num2, double num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
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

        public static bool IsMultipleOf3Or7(int input)
        {
            if (input % 3 == 0 || input % 7 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool CheckStartOfString(string input)
        {
            string condition = "C#";

            if (input.Substring(0, 2) == condition)
            {
                return true;
            }

            return false;
        }

        public static string SumAndAverageOf10Num()
        {
            double num;
            double sum = 0;
            double average;

            Console.WriteLine("Input your numbers");

            for (int i = 0; i < 10; i++)
            {
                num = Double.Parse(Console.ReadLine());
                sum += num;
            }

            average = sum / 10;

            return $"Sum = {sum}\nAverage = {average}";
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
                Console.Write("\n");
            }
        }

        public static string NumbersDivBy8BetweenInt(int input1, int input2)
        {
            int count = 0;
            int condition = 8;

            for (int i = input1 + 1; i < input2; i++)
            {
                if (i % condition == 0)
                {
                    count++;
                    Console.WriteLine($"there is: {i}");
                }
            }

            return $"total count of numbers is: {count.ToString()}";
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