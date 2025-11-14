using Tyuiu.BurmistrovNS.Sprint4.Task6.V11.Lib;
namespace Tyuiu.BurmistrovNS.Sprint4.Task6.V11
{
    class Programm
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Random rnd = new Random();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var week = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };


            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < week.Length - 1; i++)
            {
                Console.WriteLine(week[i]);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество элементов длинна которых = 5: ");
            int nums = ds.Calculate(week);



            Console.WriteLine(nums);
            Console.ReadKey();

        }



    }




}