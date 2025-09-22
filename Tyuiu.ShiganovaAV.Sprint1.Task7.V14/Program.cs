using Tyuiu.ShiganovaAV.Sprint1.Task7.V14.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task7.V14;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 |Выполнила: Шиганова А.В.| ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работа в С#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант 14                                                              *");
        Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("*                 2                                                       *");
        Console.WriteLine("*         -x    5x          2                                             *");
        Console.WriteLine("*   z = 2    + ----  - cos x  + sin (2xy)                                 *");
        Console.WriteLine("*                 2                                                       *");
        Console.WriteLine("*               3x                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");

        double x,y;
        Console.WriteLine("Введите значение x:");
        x=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        y= Convert.ToDouble(Console.ReadLine());
        


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x,y));
        Console.ReadKey();
    }
}


