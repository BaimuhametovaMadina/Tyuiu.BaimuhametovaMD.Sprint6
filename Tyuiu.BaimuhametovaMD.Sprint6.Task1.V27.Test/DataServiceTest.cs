using Tyuiu.BaimuhametovaMD.Sprint6.Task1.V27.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
        }
    }
}