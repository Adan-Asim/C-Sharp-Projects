using System;
using System.Collections.Generic;
using MyMath;

namespace My_calculator_Project
{
    class Menu
    {
        static void Main(string[] args)
        {
            try
            {
                int option = 0;
                while (!(option == 6))
                {
                    Console.WriteLine("\n************WELCOME TO MY CALCULATOR************");
                    Console.Write("\n1: press 1 for Addition of two integers numbers\n2: Press 2 for Addition of as much numbers as you want\n3: press 3 for Subtraction of two or more integers numbers\n4: press 4 for Multiplication of two integers number\n5: press 5 for Division of two integers numbers\n6: Exit close your calculator\nEnter your Option: ");
                    option = Convert.ToInt32(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.Write("Enter First Integer: ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Second Integer: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        int sum = MyamathFunctions.Add(a, b);
                        Console.WriteLine($"{a} + {b} = {sum}");
                    }
                    else if (option == 2)
                    {
                        Console.Write("How many numbers do you want to sum? ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        double[] array = new double[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Enter a Number (int/double): ");
                            array[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        double sum = MyamathFunctions.Add(array);
                        Console.WriteLine("Sum of entered numbers is: " + sum);
                    }
                    else if (option == 3)
                    {
                        Console.Write("How many integers do you want to substract? ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        int[] array = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Enter an Integer: ");
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int substract = MyamathFunctions.Sub(array);
                        Console.WriteLine("Substraction of entered numbers is: " + substract);
                    }
                    else if (option == 4)
                    {
                        Console.Write("Enter First Integer: ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Second Integer: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        long mul = MyamathFunctions.Multiplication(a, b);
                        Console.WriteLine($"{a} * {b} = {mul}");

                    }
                    else if (option == 5)
                    {
                        Console.Write("Enter First Integer: ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Second Integer: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        (int, int) div = MyamathFunctions.Division(a, b);
                        Console.WriteLine($"{a} / {b}\nQuotient: = {div.Item1}\nRemainder: {div.Item2}");

                    }
                    else if (option == 6);
                    else
                    {
                        Console.WriteLine("WRONG OPTION, ENTER BETWEEN 1 TO 6");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR: AN EXCEPTION OCCURED; Recheck your input");
            }
        }
    }
}
