using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BatTI.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            double collumns = array.Length * (Math.Pow(rows, -1));

            int count = 1;

            for (int i = 0; i < rows; i++)
                {
                    count = count * array[i, 0];
                }
            return count;
        }
    }
}
