using Tyuiu.BaimuhametovaMD.Sprint6.Task5.V29.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V29.txt"));
            for (int i = 0; i < res.Length; i++) {
                Console.WriteLine(res[i]);
            }
        }
    }
}