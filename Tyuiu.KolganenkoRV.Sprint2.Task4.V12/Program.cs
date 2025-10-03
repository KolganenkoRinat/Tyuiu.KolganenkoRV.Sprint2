using Tyuiu.KolganenkoRV.Sprint2.Task4.V12.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Z с    *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значения   *");
Console.WriteLine("* переменной X и Y с клавиатуры. Округлить полученное значение до 3       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение X:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
double y = Convert.ToDouble(Console.ReadLine());


double res = ds.Calculate(x, y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции = " + res);
Console.ReadLine();
