using System;

namespace simpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            float first_number = float.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float second_number = float.Parse(Console.ReadLine());

            Console.Write("Сумма двух чисел равна = ");
            Console.WriteLine(first_number + second_number);
            Console.Write("Разность двух чисел равна = ");
            Console.WriteLine(first_number - second_number);
            Console.Write("Произведение двух чисел равна = ");
            Console.WriteLine(first_number * second_number);
            Console.Write("Частное двух чисел равна = ");
            Console.WriteLine(first_number / second_number);
        }
    }
}
