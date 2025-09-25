using Tyuiu.MolokanovNK.Sprint1.V3.Lib;

namespace Tyuiu.MolokanovNK.Sprint1.V3
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 9;
            double y = 7.5;
            double z = 5;
            Console.WriteLine("Длина (см) Параллелепипида = " + x);
            Console.WriteLine("Ширина (см) Параллелепипида = " + y);
            Console.WriteLine("Высота (см) Параллелепипида = " + z);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объем Параллелепипида = " + ds.ParallelepipedVolume(x, y, z));

            Console.ReadKey();
        }
    }
}
   