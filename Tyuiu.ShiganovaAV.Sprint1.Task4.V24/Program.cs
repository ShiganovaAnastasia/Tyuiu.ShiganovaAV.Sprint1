using Tyuiu.ShiganovaAV.Sprint1.Task4.V24.Lib;
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
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #24                                                            *");
        Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле ( ln * x * y / x + sqrt(2 * (y ^ 2 ))    *");
        Console.WriteLine("* и печатает его на экране.                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;
        Console.WriteLine("Введите значение х:");
        x = Convert.ToDouble(Console.ReadLine());
        double y;
        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" ( ln * x * y / x + sqrt(2 * (y ^ 2 )) = " + Math.Round(ds.Calculate(x,y),3));
        Console.ReadKey();
    }
}


