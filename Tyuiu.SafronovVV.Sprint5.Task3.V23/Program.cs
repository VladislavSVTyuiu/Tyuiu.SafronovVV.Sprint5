﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Tyuiu.SafronovVV.Sprint5.Task3.V23.Lib;

namespace Tyuiu.SafronovVV.Sprint5.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Сафронов В.В. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема:  Потоковый метод записи данных в бинарный файл                       *");
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #22                                                                *");
            Console.WriteLine("* Выполнила: Сафронов Владислав Валерьевич | АСОиУб 23-1                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в     *");
            Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх  *");
            Console.WriteLine("* знаков после запятой.         3                                            *");
            Console.WriteLine("*                        (1 - x)                                             *");
            Console.WriteLine("*                y(x) = ---------                                            *");
            Console.WriteLine("*                            2                                               *");
            Console.WriteLine("*                           x                                                *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
