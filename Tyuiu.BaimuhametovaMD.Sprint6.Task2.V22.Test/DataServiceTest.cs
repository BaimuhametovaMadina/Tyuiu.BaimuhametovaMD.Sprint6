using Tyuiu.BaimuhametovaMD.Sprint6.Task2.V22.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            Assert.AreEqual(2, res[5]);
        }
    }
}