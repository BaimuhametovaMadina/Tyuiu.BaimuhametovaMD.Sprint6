using Tyuiu.BaimuhametovaMD.Sprint6.Task7.V1.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask7V1.csv");
            int[,] res = ds.GetMatrix(path);
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}