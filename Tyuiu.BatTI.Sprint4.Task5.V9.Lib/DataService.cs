using System.ComponentModel.DataAnnotations.Schema;
using tyuiu.cources.programming.interfaces.Sprint4;
    
namespace Tyuiu.BatTI.Sprint4.Task5.V9.Lib
{
    public class DataService : ISprint4Task5V9
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            double collumns = matrix.Length * (Math.Pow(rows, -1));
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < collumns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
