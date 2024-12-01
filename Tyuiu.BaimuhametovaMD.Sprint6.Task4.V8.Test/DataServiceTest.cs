using Tyuiu.BaimuhametovaMD.Sprint6.Task4.V8.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            Assert.AreEqual(1, res[5]);
        }
    }
}