﻿using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find min and max number");


            int[] nums = new int[] { 1, 3, 5, 8, 13 };
            var max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max) max = nums[i];
            }
            Console.WriteLine("Maximum number is " + max.ToString());

            var min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min) min = nums[i];
            }
            Console.WriteLine("Minimum number is " + min.ToString());
            Console.ReadLine();
        }
    }
}
