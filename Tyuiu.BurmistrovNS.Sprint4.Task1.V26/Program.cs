using Tyuiu.BurmistrovNS.Sprint4.Task1.V26.Lib;
namespace Tyuiu.BurmistrovNS.Sprint4.Task1.V26
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение" + i + "элемента массива:");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(nums[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(nums);
            Console.WriteLine(res);

            Console.ReadKey();

        }



    }




}