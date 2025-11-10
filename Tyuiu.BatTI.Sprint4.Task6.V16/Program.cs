using Tyuiu.BatTI.Sprint4.Task6.V16.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #4                                                                *");
Console.WriteLine("* Тема: Класс Array                                                        *");
Console.WriteLine("* Задание #6                                                               *");
Console.WriteLine("* Вариант #16                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* вывести все элементы, длина которых равна 7                              *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

var car = new string[] { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Исходный массив");
for (int i = 0; i < car.Length - 1; i++)
{
    Console.Write(car[i] + " ");
   
}
var res = ds.Calculate(car);
string result = string.Join(", ", res);
Console.Write("Элементы, длина которых 7:\n " + result);

Console.ReadLine();