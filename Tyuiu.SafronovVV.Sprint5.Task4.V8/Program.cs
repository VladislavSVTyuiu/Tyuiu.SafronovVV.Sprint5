﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.SafronovVV.Sprint5.Task4.V8.Lib;

namespace Tyuiu.SafronovVV.Sprint5.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Сафронов В. В. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнилa: Сафронов Владислав Валерьевич | АСОиУб-23-1                  *");
            Console.WriteLine("* Дан файл С:DataSprint5 InPutDataFileTask4V0.txt                         *");
            Console.WriteLine("* в котором есть вещественное значение. Прочитать значение из файла и     *");
            Console.WriteLine("* подставить вместо Х в формуле y = x^2/ sin(x) + 3, Вычислить значение   *");
            Console.WriteLine("* по формуле и вернуть полученный результат на консоль.                   *");
            Console.WriteLine("* Округлить до трех знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V8.txt";
            Console.WriteLine("Данные находятся в файле:" + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double ress = ds.LoadFromDataFile(path);
            Console.WriteLine(ress);
            Console.ReadKey();
        }
    }
}
