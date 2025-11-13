using Tyuiu.BurmistrovNS.Sprint4.Task3.V10.Lib;
namespace Tyuiu.BurmistrovNS.Sprint4.Task3.V10
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();

            int[,] a = {
                            { 5, 7, 6, 6, 5 },
                            { 5, 5, 5, 4, 6 },
                            { 8, 5, 7, 4, 7 },
                            { 7, 6, 7, 4, 7 },
                            { 5, 8, 7, 8, 8 } };

            int str = a.GetUpperBound(0) + 1;
            int stb = a.Length / str;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    Console.Write($"{a[i, j]} \t");
                }
                Console.WriteLine();

            }


            Console.WriteLine();
            Console.WriteLine();

            int res = ds.Calculate(a);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);


            Console.ReadKey();

        }



    }




}