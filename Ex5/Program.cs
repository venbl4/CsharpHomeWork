using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет! Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Место вашего проживания: ");
            string home = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Фамилия: {surname} \nИмя: { name} \nМесто проживания: { home}");
            Console.ReadKey();



        }
    }
}
