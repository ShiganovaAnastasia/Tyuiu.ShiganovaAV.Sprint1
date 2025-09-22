using Tyuiu.ShiganovaAV.Sprint1.Task7.V14;
using Tyuiu.ShiganovaAV.Sprint1.Task7.V14.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds=new DataService();
            double x = 3;
            double y = 5;
            double z = 0.604;
            var res = ds.Calculate (x, y);
            Assert.AreEqual (z,res);
        }
    }
}
