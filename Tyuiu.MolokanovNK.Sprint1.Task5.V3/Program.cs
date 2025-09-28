using Tyuiu.MolokanovNK.Sprint1.Task5.V3.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.Task5.V3
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            int k;

            Console.WriteLine("Введите значение K:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Переменная h = " + ds.Calculate(k));
            Console.ReadLine();

            int res = Convert.ToInt32(ds.Calculate(k));
            Console.WriteLine(res);

            Console.ReadKey();


        }
    }
}