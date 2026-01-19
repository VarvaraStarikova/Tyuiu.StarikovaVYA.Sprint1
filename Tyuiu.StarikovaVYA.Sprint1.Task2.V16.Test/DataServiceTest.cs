using Tyuiu.StarikovaVYA.Sprint1.Task2.V16.Lib;
namespace Tyuiu.StarikovaVYA.Sprint1.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 5;
            Double res = (Double)Math.Round(ds.CalculatePerimetrCircle(a), 3);
            Assert.AreEqual(31,416, res);
        }
    }
}
