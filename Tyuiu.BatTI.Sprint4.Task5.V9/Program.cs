using Tyuiu.BatTI.Sprint4.Task5.V9.Lib;

DataService ds = new DataService();
Random rnd = new Random();

Console.Title = "Спринт #4 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #4                                                                *");
Console.WriteLine("* Тема: Двумерные  массивы                                                 *");
Console.WriteLine("* Задание #5                                                               *");
Console.WriteLine("* Вариант #9                                                               *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* подсчитать количество положительных элементов массива                    *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Массив: ");

int[,] matrix = new int[5, 5];
int rows = matrix.GetUpperBound(0) + 1;
double collumns = matrix.Length * (Math.Pow(rows, -1));
int count = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < collumns; j++)
    {
        matrix[i, j] = rnd.Next(-4, 4);
    }
}
Console.WriteLine();
Console.WriteLine("Массив: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < collumns; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

int res = ds.Calculate(matrix);
Console.WriteLine(res);
Console.ReadKey();