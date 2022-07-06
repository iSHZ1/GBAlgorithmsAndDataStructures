using System;

namespace Lesson1
{
    class Program
    {
        static void Main()
        {

            Primenumber();

            int n = 12;
            Console.WriteLine(FindSummFiboo(n)); 

        }

        public static void Primenumber()
        {
            int Number;

            Console.WriteLine("Введите число для проверки");
            Number = Convert.ToInt32(Console.ReadLine());
            int D = 0;
            int I = 2;

            while (I<Number)
            {
                if (Number % I == 0)
                {
                    D++;
                }
                I++;
            }
            if (D == 0)
                Console.WriteLine("Число простое");
            else
                Console.WriteLine("Число не простое");
        }



        public static int StrangeSum(int[] inputArray) // O(n^3)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) // O(n)
            {
                for (int j = 0; j < inputArray.Length; j++) // O(n)
                {
                    for (int k = 0; k < inputArray.Length; k++) // O(n)
                    {
                        int y = 0; // O(1)
                        if (j != 0) // O(1)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y; // O(1)
                    }
                }
            }
            return sum;
        }

        public static int FindSummFiboo(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;


            return FindSummFiboo(n - 2) + FindSummFiboo(n - 1);
        }

    }
}