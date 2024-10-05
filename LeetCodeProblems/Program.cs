using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Program
    {
        //TwoSum
        public static int[] nums = {3,3};
        public static int target = 6;

        //IsPalindrome
        static int x = 121;

        //LargestCommonPrefix
        public static string[] strs = { "flower", "flow", "flight" };


        static void Main(string[] args)
        {
            //TwoSum
            new Solutions().TwoSum(nums, target);

            //Palindrome
            new Solutions().IsPalindrome(x);

            //LargestCommonPrefix
            new Solutions().LongestCommonPrefix(strs);
        }
    }
}



