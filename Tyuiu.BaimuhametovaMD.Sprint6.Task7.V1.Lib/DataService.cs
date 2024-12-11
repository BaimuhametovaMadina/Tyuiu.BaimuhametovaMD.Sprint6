using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task7.V1.Lib
{
    public class DataService: ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {
            string[] input = File.ReadAllText(path).Trim().Split("\n");
            string[] nums;
            int count = input[0].Split(";").Length;
            int[,] res = new int[input.Length, count];
            for (int i = 0; i < res.GetLength(0); i++)
            {
                nums = input[i].Split(";");
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = Convert.ToInt32(nums[j]);
                }
                if (res[i, 1] < 0) res[i, 1] = 1;
            }
            return res;
        }
    }
}
