using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {

            if (nums?.Length < 2)
            {
                return null;
            }

            var checkedValue = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var currentValue = nums[i];
                var searchValue = target - currentValue;

                if (checkedValue.ContainsKey(searchValue))
                {
                    return new int[2]
                    {
                        checkedValue[searchValue],
                        i
                    };
                }

                if (checkedValue.ContainsKey(currentValue) == false)
                {
                    checkedValue.Add(currentValue, i);
                }
            }

            return null;
        }
    }
}
