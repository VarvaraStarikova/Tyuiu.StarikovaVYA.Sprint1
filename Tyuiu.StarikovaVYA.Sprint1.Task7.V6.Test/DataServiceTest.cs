using Tyuiu.StarikovaVYA.Sprint1.Task7.V6.Lib;

namespace Tyuiu.StarikovaVYA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            Assert.AreEqual(-34, ds.Calculate(x, y));
        }
    }
}
