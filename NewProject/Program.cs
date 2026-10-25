using System;
using System.Buffers;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;
using System.Xml.XPath;








var solution = new Solution();
Console.WriteLine(string.Join(", ", solution.TwoSum([2, 7, 11, 15], 9)));
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        for(var i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(dict.ContainsKey(complement))
            {
                return new int[] {dict[complement], i };
            }
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        
        throw new ArgumentException("No solution");
    }
}





