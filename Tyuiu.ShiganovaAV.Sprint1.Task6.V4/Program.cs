using Tyuiu.ShiganovaAV.Sprint1.Task6.V4.Lib;
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
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант 4                                                              *");
        Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
        Console.WriteLine("* Напечатать все слова, содержащие удвоенное н (\"нн\").                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine();


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.CheckDoubleN(str));
        Console.ReadKey();
    }
}


