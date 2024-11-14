using Tyuiu.BaimuhametovaMD.Sprint6.Task0.V17.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = Math.Pow(Math.E, 3) / 3;
            int x = 3;
            Assert.AreEqual(ds.Calculate(x), Math.Round(wait, 3));
        }
    }
}