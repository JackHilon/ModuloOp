using System;
using System.Collections.Generic;

namespace ModuloOp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modulo
            // https://open.kattis.com/problems/modulo
            // enter (10) numbers and get list of distinctive answers (operation is num mod 42)
            // print answers.count (number of distinctive answers)
            
            var Numbers = EnterList();

            var Ans = GetDistinctiveAnswers(Numbers);

            Console.WriteLine(Ans.Count);
        }
        private static List<int> GetDistinctiveAnswers(List<int> nums)
        {
            List<int> ans = new List<int>();
            ans.Add(nums[0] % 42);
            int result;

            for (int k = 1; k < nums.Count; k++)
            {
                result = (nums[k] % 42);
                if (ItemExist(ans, result) == false)
                    ans.Add(result);
            }
            return ans;
        }
        private static List<int> EnterList()
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                nums.Add(EnterNumber());
            }
            return nums;
        }

        private static bool ItemExist(List<int> list, int item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                    return true;
            }
            return false;
        }
        private static int EnterNumber()
        {
            int a = 0;
            string str = " ";
            str = Console.ReadLine();
            try
            {
                a = int.Parse(str);
                if (a < 0 || a > 1000)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
                return EnterNumber();
            }
            return a;
        }
    }
}
