using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /*
     #########################-Task-Description-#########################

    Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1]

    */

    public class TwoSum
    {
        public int[] GetNumbersSum(int[] nums, int target)
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
