using System;

namespace Homework2
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
        }

        private static void Task1()
        {
            Marker markerGreen = new Marker();
            markerGreen.Color = "green";

            Marker markerOrange = new Marker();
            markerOrange.Color = "orange";

            markerGreen.PrintMarker();
            markerOrange.PrintMarker();

            Marker? markerBlue = Marker.InitMarker(null);
            markerBlue ??= new Marker("default");
            markerBlue?.PrintMarker();
        }

        private static void Task2()
        {
            Book bookBasic = new Book();
            bookBasic.Title = "BASIC";
            bookBasic.Author = "S.TROELSTRA";

            Book bookC = new Book();
            bookC.Title = "C+";
            bookC.Author = "G.RTRTG";

            bookBasic.PrintBookInfo();
            bookC.PrintBookInfo();
        }

        private static void Task3()
        {
            Console.WriteLine("Input the number of elements to store in the array :");
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"pls enter your {i + 1} number");
                numbers[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            Console.WriteLine("The values store into the array are :");

            foreach(int value in numbers)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();

            PrintReverseValues(numbers);
        }

        public static void PrintReverseValues(int[] inputArr)
        {
            Array.Reverse(inputArr);

            Console.WriteLine("The values store into the array in reverse are :");

            foreach (int value in inputArr)
            {
                Console.Write(value + " ");
            }
        }

        private static void Task4()
        {
            Console.WriteLine("Input the number of elements to store in the array :");
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"pls enter your {i + 1} number");
                numbers[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            FindDuplicateElements(numbers);
        }

        public static void FindDuplicateElements(int[] inputArr)
        {
            int count = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] == inputArr[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Total number of duplicate elements found in the array is : {count}");
        }

        private static void Task5()
        {
            Console.WriteLine("Input two integers :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            SwapInteger(num1, num2);

            Console.WriteLine($"Now the 1st number is : {num1} , and the 2nd number is : {num2}");
        }

        public static void SwapInteger(int num1, int num2)
        {
            int num3 = num1;
            num1 = num2;
            num2 = num3;
        }

        private static void Task6()
        {
            Point point = new Point();

            Console.WriteLine("Pls enter value for a Point in this format '2, 3' or '2,3'");
            string input = Console.ReadLine();

            point.TryParsePoint(input, out point);
        }
    }
}