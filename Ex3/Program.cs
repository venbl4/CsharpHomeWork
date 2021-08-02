using System;

namespace Ex3
{
    class Program
    {
        // Maksim Lebedev
        //Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
        //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
        //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        static void Main()
        {
            Console.WriteLine("Найдем расстояние между двумя точками с координатами x и y\nВведите координаты первой точки: ");
            Console.Write("Введите x1 ");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1 ");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координаты второй точки: ");
            Console.Write("Введите x2 ");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2 ");
            Double y2 = Convert.ToDouble(Console.ReadLine());
            Double dist = 0;
            dist = (Double) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между двумя точками = {dist:f2} ");
        }
    }
}
