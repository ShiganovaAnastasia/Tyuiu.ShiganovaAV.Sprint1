using Newtonsoft.Json.Serialization;
using Tyuiu.ShiganovaAV.Sprint1.Task5.V2.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 15;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(x);

            int result = Convert.ToInt32(res);
            Assert.AreEqual(-9, result);
            
        }
    }
}
