﻿
using Tyuiu.ShiganovaAV.Sprint1.Task0.V11.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #1                                                              *");
            Console.WriteLine("*  Тема: Базовые навыки работа в С#                                       *");
            Console.WriteLine("*  Задание #0                                                             *");
            Console.WriteLine("*  Вариант #11                                                            *");
            Console.WriteLine("*  Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая вычисляет выражение 4 * 5 / 2 - 18 / 2 / 3 *");
            Console.WriteLine("*  и печатает результат на экране.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  4 * 5 / 2 - 18 / 2 / 3                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.WriteLine();

        }
    }
}

