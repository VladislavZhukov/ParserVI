using System;
using ParserVolgInfo.Core;

namespace ParserVolgInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Парсер запущен, ожидайте окончания выполнения работы...");
            ParserVI.StartParser();           
            Console.WriteLine("Работа завершена.");
        }
    }
}
