using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.StarikovaVYA.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double celsius = (temp - 32) * 5 / 9;
            int celsiusInt = Convert.ToInt32(celsius);
            return celsiusInt;
        }
    }
}
