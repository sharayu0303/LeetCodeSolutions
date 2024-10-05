using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    class Solutions
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();
            for (int i = 0; i< nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            result.Add(i);
                            result.Add(j);
                        }
                    } 
                   
                }
            }
            return result.ToArray();
        }

        public bool IsPalindrome(int x)
        {
            int original = x;
            int reverse = 0;
            if(x < 0)
            {
                return false;
            }
            while (x > 0)
            {
                int remainder = x % 10;
                reverse = reverse * 10 + remainder;
                x = x / 10;
            }

                if (original == reverse)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        public string LongestCommonPrefix(string[] strs)
        {
           int minstrLength = strs.Min(str => str.Length);
            string a = "";
            for (int i = 0;i < minstrLength;i++)
            {
                char firstString = strs[0][i];
                bool allMatch = true;

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != firstString)
                    {
                        allMatch = false;
                        break;
                    }
                }
                if (allMatch)
                {
                    a += firstString.ToString();
                }
                else
                {
                    break;
                }
            }
            return a;
        }
    }
}
