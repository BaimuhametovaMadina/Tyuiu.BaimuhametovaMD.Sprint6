using Tyuiu.BaimuhametovaMD.Sprint6.Task3.V19.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                {4, 32, -20, 27, 21 },
                {17, 15, -1, -2, -1 },
                {-3, 18, 12, -10, 29 },
                {7, -5, 2, -8, 12 },
                {-10, 25, 5, 27, 21 }
            };
            int[,] res = ds.Calculate(matrix);
            for (int i = 0;  i < res.GetLength(0); i++)
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