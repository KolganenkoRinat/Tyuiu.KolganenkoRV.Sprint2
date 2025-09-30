using Tyuiu.KolganenkoRV.Sprint2.Task0.V26.Lib;
DataService ds = new DataService();

int x = 1045;
int y = 975;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.Title = "Спринт #2 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений                                *");
Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*"); 
Console.WriteLine("* и арифметических выражений, которая вернет логическую                   *");
Console.WriteLine("* последовательность(массив): (False, False, False, True, True, True),    *");
Console.WriteLine("* при x = 1045, y = 975                                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();

     
