using Tyuiu.StarikovaVYA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.StarikovaVYA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var x = "всем привет";
            var res = ds.MoveLetterToStart(x);
            var wait = "мвсе тприве";

            Assert.AreEqual(wait, res);
        }
    }
}
