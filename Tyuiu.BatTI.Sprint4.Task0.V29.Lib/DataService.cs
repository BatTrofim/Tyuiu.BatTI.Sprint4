using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint4;
    
namespace Tyuiu.BatTI.Sprint4.Task0.V29.Lib
{
    public class DataService : ISprint4Task0V29
    {
        public int GetSumOddArrEl(int[] array)
        {
            int nums = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    nums = nums + array[i];
                }
            }

            return nums;
        }
    }
}
