using System;

namespace MessageCenter
{
    class Program
    {
        static void Print (string msg, int x, int y)
        {
            //позиция курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            //цвет символа
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }
            

        //Создаем прегрузку функции, в которой будет указана позиция и цвет

        static void Main(string[] args)
        {
            Print("Привет!\n", 50, 50);
            Print("Привет еще раз!", ConsoleColor.Red);
            Console.ReadLine();
        }
    }
}
