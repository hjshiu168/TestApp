using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 8, 13 };
            var max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max) max = nums[i];
            }
            Console.WriteLine("Maximum number is " + max.ToString());
        }
    }
}
