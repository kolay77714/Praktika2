/*using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите римское число: ");
        string nums = Console.ReadLine()!;
        Console.WriteLine(RomanToDecimal(nums));
    }

    static int RomanToDecimal(string nums)
    {
        char[] romanChars = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        int[] decimalNums = { 1, 5, 10, 50, 100, 500, 1000 };
        int result = 0;
        int prev = 0;
        int len = nums.Length;
        for (int i = len - 1; i >= 0; i--)
        {
            char current = nums[i];
            int value = 0;
            for (int j = 0; j < 7; j++)
            {
                if (romanChars[j] == current)
                {
                    value = decimalNums[j];
                    break;
                }
            }
         if(value < prev)
            {
                result -= value;
            }
         else
            {
                result += value;
            }
         prev = value;
        }
        return result;
    }
}
*/