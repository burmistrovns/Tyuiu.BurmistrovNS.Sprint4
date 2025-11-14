using Tyuiu.BurmistrovNS.Sprint4.Task5.V24.Lib;

namespace Tyuiu.BurmistrovNS.Sprint4.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -7, -6, -1, -5, 1 },
                                          { -1, 1, -1, -1, 6 },
                                          { -1, 2, 3, 1, -1 },
                                          { 1, -1, -1, -1, -1 },
                                          { 1, 0, -1, 1, -1} };
            int res = ds.Calculate(mas2);
            int wait = 9;

            Assert.AreEqual(wait, res);
        }
    }
}