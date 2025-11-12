using Tyuiu.BurmistrovNS.Sprint4.Task0.V1.Lib;
namespace Tyuiu.BurmistrovNS.Sprint4.Task0.V1
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("{6 ,4 ,3 ,2 ,1 ,0 ,9 ,8 ,7 ,5}");

            int[] Array = new int[] { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };

            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumEvenArrEl(Array);
            Console.WriteLine(res);

            Console.ReadKey();

        }



    }




}