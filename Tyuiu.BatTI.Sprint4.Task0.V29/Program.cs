using Tyuiu.BatTI.Sprint4.Task0.V29.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #4                                                                *");
Console.WriteLine("* Тема: Одномерные массивы                                                 *");
Console.WriteLine("* Задание #0                                                               *");
Console.WriteLine("* Вариант #29                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* подсчитать сумму нечетных элементов массива                              *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");


int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
int res = ds.GetSumOddArrEl(numsArray);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + ds.GetSumOddArrEl(numsArray));
Console.ReadKey();
