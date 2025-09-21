using Tyuiu.ShiganovaAV.Sprint1.Task1.V13.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2,res);
        }
    }
}
