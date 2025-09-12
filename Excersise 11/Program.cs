using System;

namespace CountClumpsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountClumps(new int[] { 1, 2, 2, 3, 4, 4 })); // → 2
            Console.WriteLine(CountClumps(new int[] { 1, 1, 2, 1, 1 }));    // → 2
            Console.WriteLine(CountClumps(new int[] { 1, 1, 1, 1, 1 }));    // → 1
            Console.WriteLine(CountClumps(new int[] { 1, 2, 3, 4 }));       // → 0
        }

        static int CountClumps(int[] nums)
        {
            int count = 0;
            bool inClump = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    if (!inClump)
                    {
                        count++;
                        inClump = true;
                    }
                }
                else
                {
                    inClump = false;
                }
            }

            return count;
        }
    }
}