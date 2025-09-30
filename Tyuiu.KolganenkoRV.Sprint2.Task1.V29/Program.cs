using Tyuiu.KolganenkoRV.Sprint2.Task1.V29.Lib;

DataService ds = new DataService();

int a = 657;
int b = 654;
int c = 657;
int d = 657;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.Title = "Спринт #2 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений                                *");
Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать,             *");
Console.WriteLine("* но использовать один раз в выражении) и логических операций             *");
Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)  *");
Console.WriteLine("* последовательность(массив): (True, True, True, False, True, True),      *");
Console.WriteLine("* при a = 657, b = 654, c = 657, int d = 657                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("A = " + a);
Console.WriteLine("B = " + b);
Console.WriteLine("C = " + c);
Console.WriteLine("D = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();


