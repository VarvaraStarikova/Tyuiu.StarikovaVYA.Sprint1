using Tyuiu.StarikovaVYA.Sprint1.Task5.V2.Lib;
namespace Tyuiu.StarikovaVYA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 15.5;
            Assert.AreEqual(-9, ds.FahrenheitToСelsius(temp));
        }
    }
}
