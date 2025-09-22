using Tyuiu.ShiganovaAV.Sprint1.Task6.V4.Lib;
namespace Tyuiu.ShiganovaAV.Sprint1.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Анна и Инна пошли в банну";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest );
            Assert.AreEqual("Анна Инна банну", res);
        }
    }
}
