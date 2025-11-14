using Tyuiu.BurmistrovNS.Sprint4.Task6.V11.Lib;

namespace Tyuiu.BurmistrovNS.Sprint4.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var week = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int res = ds.Calculate(week);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}