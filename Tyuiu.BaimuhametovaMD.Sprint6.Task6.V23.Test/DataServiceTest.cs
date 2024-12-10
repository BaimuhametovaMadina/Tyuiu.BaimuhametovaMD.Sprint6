using Tyuiu.BaimuhametovaMD.Sprint6.Task6.V23.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask6V23.txt");
            string res = ds.CollectTextFromFile(path);
            Console.WriteLine(res);
        }
    }
}