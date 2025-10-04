using Tyuiu.KolganenkoRV.Sprint2.Task5.V3.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите день недели:");
int numDay = Convert.ToInt32(Console.ReadLine());

string res;

if ((numDay > 7) || (numDay < 1))
{
    res = ("Нет такого дня недели");
}
else
{
    res = ("Это " + ds.FindDayName(numDay));
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);

Console.ReadLine();
