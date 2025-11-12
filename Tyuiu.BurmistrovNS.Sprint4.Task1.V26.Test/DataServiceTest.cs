using Tyuiu.BurmistrovNS.Sprint4.Task1.V26.Lib;
namespace Tyuiu.BurmistrovNS.Sprint4.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 };

            int wait = 24;

            int res = ds.Calculate(nums);

            Assert.AreEqual(wait, res);
        }
    }
}
