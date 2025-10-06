using Tyuiu.KolganenkoRV.Sprint2.Task7.V9.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу которая запрашивает целые значения с клавиатуры и    *");
Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение X:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
double y = Convert.ToDouble(Console.ReadLine());

bool res = ds.CheckDotInShadedArea(x, y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (res)
{
    Console.WriteLine("Точка находиться в заштрихованной области");
}
else
{
    Console.WriteLine("Точка не находиться в заштрихованной области");
}

Console.ReadLine();

