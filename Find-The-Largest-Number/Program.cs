using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Largest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int maxNum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter an integer: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
                if (nums[i] > maxNum)
                {
                    maxNum = nums[i];
                }
            }

            Console.WriteLine("The largest number that you entered is: " + maxNum);
            Console.WriteLine("Press 'enter' to close the program.");
            Console.ReadLine();
        }
    }
}
