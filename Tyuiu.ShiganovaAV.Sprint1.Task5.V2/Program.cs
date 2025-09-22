using Tyuiu.ShiganovaAV.Sprint1.Task5.V2.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task4.V24;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 |Выполнила: Шиганова А.В.| ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работа в С#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая  которая решает следующую задачу:           *");
        Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.                        *");
        Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия.             *");
        Console.WriteLine("* Вычисляет результат по формуле (x - 32) * 5 / 9                         *");
        Console.WriteLine("* и печатает результат на экране.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;
        Console.WriteLine("Введите значение х:");
        x = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Температура по Фаренгейту :" + x);
        int res = Convert.ToInt32(ds.FahrenheitToСelsius(x));
        Console.WriteLine(" Температура по Цельсию :" + res);
        Console.ReadKey();
    }
}


