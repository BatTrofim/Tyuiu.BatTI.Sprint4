using System.Net.Security;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BatTI.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length == 7);
            return mas;
        }
    }
}
