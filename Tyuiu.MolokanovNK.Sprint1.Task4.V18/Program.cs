using Tyuiu.MolokanovNK.Sprint1.Task4.V18.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task4.V18
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                       *");
            Console.WriteLine("* Задание #4                                                                                             *");
            Console.WriteLine("* Вариант #18                                                                                            *");
            Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                                 *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать  программу , которая запрашиваету пользователя исходные данные                                *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране                                             *");
            Console.WriteLine("*                                                                                                        *");  
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите переменную X:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную Y:");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Ответ формулы равен = " + ds.Calculate(x, y));
            Console.ReadLine(); 
        }
    }
}