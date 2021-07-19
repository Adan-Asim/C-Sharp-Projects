using System;

namespace MyMath
{
    public class MyamathFunctions
    {
        public static double Add(double a, double b)
        {
            return a+b;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static long Add(params int []aray)
        {
            long sum = 0;
            foreach(var x in aray)
            {
                sum += x;
            }
            return sum;
        }

        public static double Add(params Double [] aray)
        {
            double sum = 0.0;
            foreach(var x in aray)
            {
                sum += x;
            }
            return sum;
        }

        public static int Sub(params int [] aray)
        {
            int sum = aray[0]*2;
            foreach (var x in aray)
                sum -= x;
            return sum;
        }

        public static long Multiplication(int a, int b)
        {
            return a * b;
        }

        public static (int,int) Division(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;

            return (quotient,remainder);
        }
    }
}
