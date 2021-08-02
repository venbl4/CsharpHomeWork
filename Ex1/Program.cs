using System;

namespace Ex1
{
    class Program
    {
        
        //Lebedev Maksim
        //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        //а) используя склеивание;
        //б) используя форматированный вывод;
	    //в) используя вывод со знаком $.
        
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте! Давайте создадим ваш профиль.\nВведите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Укажите Ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш рост (в сантиметрах): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("И введите свой вес (в килограммах): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ваши данные: " + surname + " " + name + "; возраст:" + age + "; ваш рост: " + height + "см" + "; вес: " weight + "кг");// склеивание
            //Console.WriteLine(String.Format("Ваши данные, имя: {0} {1}; возраст: {2}; рост: {3}; вес: {4}", surname, name, age, height, weight));// форматированный вывод
            Console.WriteLine($"Ваше имя: {surname} {name};  возраст: {age};  рост: {height}см;  вес: {weight}кг");// интерполяция
        }
    }
}
