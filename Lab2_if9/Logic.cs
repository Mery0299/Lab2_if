using System;

namespace Lab2_if9
{
    public class Logic
    {
        //метод решения задания
        public static string Solution(float[] nums)
        {
            Array.Sort(nums);
            return $"Ответ: {nums[0]} * {nums[1]} = {nums[0] * nums[1]}";
        }

        //метод проверки на различные числа
        public static bool Check(float[] nums)
        {
            if (nums[0] == nums[1])
                return false;
            else if (nums[0] == nums[2])
                return false;
            else if (nums[1] == nums[2])
                return false;

            return true;
        }
    }
}
