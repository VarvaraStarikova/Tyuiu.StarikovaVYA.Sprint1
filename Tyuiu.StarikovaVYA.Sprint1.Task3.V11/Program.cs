using System.ComponentModel;
using Tyuiu.StarikovaVYA.Sprint1.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Старикова В. Я. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Старикова Варвара Яковлевна | СМАРТб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая вычисляет площадь треугольника, если        *");
        Console.WriteLine("* известны координаты его углов.                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x1 = -2;

        double y1 = 5;

        double x2 = 1;

        double y2 = 7;

        double x3 = 5;

        double y3 = -3;

        Console.WriteLine("Введите координаты углов (числа разделяйте пробелом):");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Площадь треугольника: " + ds.TriangleArea(x1, y1, x2, y2, x3, y3) + " кв.см");

        Console.ReadKey();
    }
}