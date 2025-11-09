using Tyuiu.BatTI.Sprint4.Task3.V29.Lib;

Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #4                                                                *");
Console.WriteLine("* Тема: Двумерные  массивы                                                 *");
Console.WriteLine("* Задание #2                                                               *");
Console.WriteLine("* Вариант #29                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* подсчитать произведение первого стобца массива                           *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Массив:                                                                  *");

int[,] array = new int[5, 5] { { 9, 9, 8, 6, 9 },

                                           { 5, 8, 8, 8, 7 },

                                           { 6, 5, 9, 7, 9 },

                                           { 7, 7, 9, 7, 8 },

                                           { 8, 5, 8, 5, 5 } };
int rows = array.GetUpperBound(0) + 1;
double collumns = array.Length * (Math.Pow(rows, -1));

for (int i = 0; i < rows; i++)
{
    for(int j = 0; j < collumns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

int res = ds.Calculate(array);
Console.WriteLine(res);
Console.ReadKey();
