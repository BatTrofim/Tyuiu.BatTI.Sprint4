using Tyuiu.BatTI.Sprint4.Task7.V2.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #4                                                                *");
Console.WriteLine("* Тема: Итоговый проект к решению                                          *");
Console.WriteLine("* Задание #7                                                               *");
Console.WriteLine("* Вариант #2                                                               *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* посчитать сумму всех нечетных элементов                                  *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

int n = 3;
int m = 4;
string value = "597643158942";
int[,] matrix = new int[n, m];
int index = 0;

Console.WriteLine("\nМассив");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{value[index]}\t");
        index++;
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

int res = ds.Calculate(n, m, value);
Console.WriteLine(res);
Console.ReadLine();