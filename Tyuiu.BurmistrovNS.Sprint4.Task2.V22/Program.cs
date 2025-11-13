using Tyuiu.BurmistrovNS.Sprint4.Task2.V22.Lib;
namespace Tyuiu.BurmistrovNS.Sprint4.Task1.V26
{
    class Programm
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];


            for (int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(1, 7);
            }
            Console.WriteLine();
            Console.WriteLine("Получившийся массив:");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение нечетных элементов массива = " + ds.Calculate(array));
            Console.ReadKey();

        }



    }




}