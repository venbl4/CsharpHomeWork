using System;

namespace Ex3
{
    class Program
    {
        static void Main()
        {
            string[] str = { "Имя: Вася", "Возраст: 18", "Средний балл по математике: 4" };
            int width = Console.WindowWidth, height = Console.WindowHeight;
            Print();

            while (true)
            {
                if (width != Console.WindowWidth || height != Console.WindowHeight)
                {
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    Print();
                }
            }

            void Print()
            {
                Console.Clear();
                int top = Console.WindowHeight / 2 - str.Length / 2;
                for (int i = 0; i < str.Length; i++, top++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - str[i].Length / 2, top);
                    Console.Write(str[i]);
                }
            }
        }
    }
}
