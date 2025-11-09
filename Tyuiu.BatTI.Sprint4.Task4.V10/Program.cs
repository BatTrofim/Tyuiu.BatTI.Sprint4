using Tyuiu.BatTI.Sprint4.Task4.V10.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #4                                                                *");
Console.WriteLine("* Тема: Двумерные  массивы                                                 *");
Console.WriteLine("* Задание #4                                                               *");
Console.WriteLine("* Вариант #10                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Заменить нечетные элементы на 0                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

int[,] matrix = {{6, 6, 5, 3, 3,

                              5, 7, 4, 6, 4,

                              1, 2, 4, 1, 5,

                              1, 7, 2, 5, 7,

                              4, 2, 6, 5, 6} };

int rows = matrix.GetUpperBound(0) + 1;
double collumns = matrix.Length * (Math.Pow(rows, -1));

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

int[,] res = ds.Calculate(matrix);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < collumns; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
    Console.ReadKey();
    Console.WriteLine(ds.Calculate(matrix));
    Console.ReadKey();
}
