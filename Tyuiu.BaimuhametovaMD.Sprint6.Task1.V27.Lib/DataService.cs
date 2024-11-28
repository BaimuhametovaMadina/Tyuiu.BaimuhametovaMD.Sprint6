using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task1.V27.Lib
{
    public class DataService: ISprint6Task1V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[11];
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 * i - 2 == 0) res[i+5] = 0;
                else res[i + 5] = Math.Round((4 - 2 * i + ((2 + Math.Cos(i)) / (2 * (double)i - 2))), 2);
            }
            Console.WriteLine(res[1]);
            return res;
        }
    }
}
