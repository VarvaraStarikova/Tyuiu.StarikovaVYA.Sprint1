using Tyuiu.StarikovaVYA.Sprint1.Task1.V24.Lib;

namespace Tyuiu.StarikovaVYA.Sprint1.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
