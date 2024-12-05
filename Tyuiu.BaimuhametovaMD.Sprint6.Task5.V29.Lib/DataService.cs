using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task5.V29.Lib
{
    public class DataService: ISprint6Task5V29
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] numsstr = File.ReadAllText(path).Trim().Split("\n");
            double[] nums = new double[numsstr.Length];
            int count = 0;
            for (int i = 0; i < numsstr.Length; i++)
            {  
                nums[i] = Convert.ToDouble(numsstr[i]);
                if (nums[i] > 9) count++;
            }
            double[] res = new double[count];
            count = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > 9)
                {
                    res[count] = nums[i];
                    count++;
                }
            }
            return res;
        }
    }
}
