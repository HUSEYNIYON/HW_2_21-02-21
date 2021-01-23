using System;

namespace HW_2_21_01_21
{
    class Program
    {
        static void Main(string[] args)
        {

            llll:
            //Task 2
            //var purchase = Double.Parse(Console.ReadLine());
            //var discount = 0.0;
            //if (purchase >= 500 & purchase < 1000)
            //{
            //    discount = purchase - (purchase * 3 / 100); 
            //    Console.WriteLine($"You remainder with 3% discount: {discount}$");
            //}
            //else if (purchase >= 1000)
            //{
            //    discount = purchase - (purchase * 5 / 100);
            //    Console.WriteLine($"You remainder with 5% discount: {discount}$");
            //}
            //else
            //{
            //    System.Console.WriteLine("No discount!");
            //}

            //Task 3

            //var A = Convert.ToDouble(Console.ReadLine());
            //var B = Convert.ToDouble(Console.ReadLine());
            //var C = Convert.ToDouble(Console.ReadLine());
            //var D = Convert.ToDouble(Console.ReadLine());
            //var minAB = 0.0;
            //var minCD = 0.0;
            //var min = 0.0;
            //if (A < B && B < C && C < D)
            //{
            //    Console.WriteLine("Numbers Increasing!");
            //}
            //else
            //{
            //    if (A == B && B == C && C == D)
            //    {
            //        Console.WriteLine(A * B * C * D);
            //    }
            //    else
            //    {
            //        minAB = Math.Min(A, B);
            //        minCD = Math.Min(C, D);
            //        min = Math.Min(minAB, minCD);
            //        Console.WriteLine(min);
            //    }
            //}

            //Task 4
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            int max = 0, mid = 0, min = 0;
            if (a > b & b > c)
            {
                max = a;
                mid = b;
                min = c;
                Console.WriteLine($"A = {a = max}");
                Console.WriteLine($"B = {b = mid}");
                Console.WriteLine($"C ={c = min}");
            }
            else if (b > a & a > c)
            {
                max = b;
                mid = a;
                min = c;
                Console.WriteLine($"A = {a = max}");
                Console.WriteLine($"B = {b = mid}");
                Console.WriteLine($"C = {c = min}");
            }
            else if (c > b & b > a)
            {
                max = c;
                mid = b;
                min = a;
                Console.WriteLine($"A = {a = max}");
                Console.WriteLine($"B = {b = mid}");
                Console.WriteLine($"C = {c = min}");
            }
            else if (a > b & a > c & b < c)
            {
                max = a;
                mid = c;
                min = b;
                Console.WriteLine($"A = {a = max}");
                Console.WriteLine($"B = {b = mid}");
                Console.WriteLine($"C = {c = min}");
            }
            else if (a < b & b > c)
            {
                max = b;
                mid = c;
                min = a;
                Console.WriteLine($"A = {a = max}");
                Console.WriteLine($"B = {b = mid}");
                Console.WriteLine($"C ={c = min}");
            }
            else if (a > b & b < c & a < c)
            {
                max = c;
                mid = a;
                min = b;
                Console.WriteLine($"A = {a = max}");
                Console.WriteLine($"B = {b = mid}");
                Console.WriteLine($"C ={c = min}");
            }
            goto llll;
        }
    }
    }

