using System;

namespace LeetCode.Easy
{
    public class ReverseInteger
    {
        public static int Reverse(int? value)
        {
            if (value == null)
                throw new ArgumentException("Value can not be null");

            var left = value;
            var reversedValue = 0;
            while(Math.Abs(left.Value) > 0)
            {
                var right = left % 10;
                if (WillMultiplicationOverflow(reversedValue, 10))
                    return 0;

                var multipliedNumber = reversedValue * 10;
                if (WillAddingOverflow(multipliedNumber, right.Value))
                    return 0;

                reversedValue = reversedValue * 10 + right.Value;
                left /= 10;
            }
            return reversedValue;
        }

        private static bool WillMultiplicationOverflow(int x, int y)
        {
            if (x == 0)
                return false;
            return int.MaxValue / Math.Abs(x) < y;
        }

        private static bool WillAddingOverflow(int x, int y) => x > 0 && y > int.MaxValue - x;
    }
}
