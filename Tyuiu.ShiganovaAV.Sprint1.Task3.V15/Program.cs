using Tyuiu.ShiganovaAV.Sprint1.Task3.V15.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работа в С#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, решающую следующую задачу: два автомобиля имеют     *");
            Console.WriteLine("* скорости V1 км/ч и V2 км/ч соответственно, находятся на расстоянии S км *");
            Console.WriteLine("* друг от друга и движутся в противоположные стороны.                     *");
            Console.WriteLine("* Определить расстояние между ними через T часов.                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1=60;
            double v2 = 80;
            double S = 100;
            double T = 2;
            Console.WriteLine("Скорость первого автомобиля = " + v1);
            Console.WriteLine("Скорость второго автомобиля = " + v2);
            Console.WriteLine("Начально расстояние = " + S);
            Console.WriteLine("Время = " + T);
           


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Расстояние между ними через T часов = " + ds.DistanceOverTime(v1,v2,S,T));
            Console.ReadLine();
        }
    }
}
