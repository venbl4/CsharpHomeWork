using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 12;
            Console.WriteLine($"Было:\nПеременная а = {a}\nПеременная b = {b}");
            //int c = a;// Используем третью переменную
            //a = b;
            //b = c;
            a = b + a;// Без использования третьей переменной
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine($"Cтало:\nПеременная а = {a}\nПеременная b = {b}");
        }
    }
}
