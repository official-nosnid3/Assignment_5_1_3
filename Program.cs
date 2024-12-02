namespace Assignment_5_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 5.1.3
             * 
             * Given an integer array nums, return true if any value appears 
             * at least twice in the array, and return false if every element is distinct.
             * 
             * Example 1:
             * Input: nums = [1,2,3,1]
             * Output: true
             * 
             * Example 2:
             * Input: nums = [1,2,3,4]
             * Output: false
             * 
             * Example 3:
             * Input: nums = [1,1,1,3,3,4,3,2,4,2]
             * Output: true
             */

            int[] nums = { 1, 2, 2, 4, 5, 6 };

            Console.WriteLine( HasDuplicateValue(nums).ToString() );
        }

        static bool HasDuplicateValue(int[] Nums_)
        {
            for (int i = 0; i < Nums_.Length - 1; i++)
                for (int j = i + 1; j < Nums_.Length; j++)
                    if (Nums_[i] == Nums_[j])
                        return true;
            return false;
        }
    }
}
