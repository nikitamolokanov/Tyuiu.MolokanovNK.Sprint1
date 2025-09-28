using Tyuiu.MolokanovNK.Sprint1.Task6.V5.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task6.V5
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
            Console.WriteLine("* Задание #6                                                                                             *");
            Console.WriteLine("* Вариант #5                                                                                             *");
            Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                                 *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                                                         *");
            Console.WriteLine("* Напечатать те слова, которые являются симметричными                                                    *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Введите слово");
            string x = Console.ReadLine();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Ответ: " + ds.CheckSymmetricalWords(x));
            Console.ReadLine();
        }
    }
}