using Tyuiu.ShiganovaAV.Sprint1.Task3.V15.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 60;
            double v2 = 80;
            double S = 100;
            double T = 2;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(380,res);
        }
    }
}
