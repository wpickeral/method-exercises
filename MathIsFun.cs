using System;
namespace method_exercises
{
    public class MathIsFun
    {
        public static int Add(params int[] items)
        {
            int sum = 0;
            foreach (int item in items)
            {
                sum = sum + item;
            }
            return sum;
        }

        public static int Subtract(params int[] items)
        {
            int difference = 0;
            foreach (int item in items)
            {
                difference = difference - item;
            }
            return difference;
        }

        public static int Multiply(params int[] items)
        {
            int total = 1;
            foreach (int item in items)
            {
                total = item * 1;
            }
            return total;
        }

        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        public static bool Even(int num)
        {
            return num % 2 == 0;
        }
    }
}
