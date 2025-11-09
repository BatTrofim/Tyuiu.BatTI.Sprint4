using Tyuiu.BatTI.Sprint4.Task2.V22.Lib;

Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #4                                                                *");
Console.WriteLine("* Тема: Одномерные массивы                                                 *");
Console.WriteLine("* Задание #2                                                               *");
Console.WriteLine("* Вариант #22                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* подсчитать произведение нечетных элементов массива                       *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());
int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива: ");
    numsArray[i] = rnd.Next(1, 6);
}
Console.WriteLine();
Console.WriteLine("Массив: ");

for (int i = 0; i <= len - 1; i++)
{
    Console.Write(numsArray[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

int res = ds.Calculate(numsArray);
Console.WriteLine(res);
Console.ReadKey();
