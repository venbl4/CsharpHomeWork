using System;

namespace Ex2
{
    class Program
    {
        //Lebedev Maksim
        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

        static void Main(string[] args)
        {
            Console.Write("Привет, давай расчитаем твой индекс массы тела\nВведите свой рост в метрах: ");
            double heigh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double indexbw = weight / (heigh * heigh);
            Console.WriteLine($"Индекс массы вашего тела составил {indexbw}");
        }
    }
}
