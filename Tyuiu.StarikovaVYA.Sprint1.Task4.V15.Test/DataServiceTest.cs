using Tyuiu.StarikovaVYA.Sprint1.Task4.V15.Lib;
namespace Tyuiu.StarikovaVYA.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 0.5;
            Assert.AreEqual(2.25, ds.Calculate(x, y));
        }
    }
}
