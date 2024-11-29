using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task2.V22.Lib
{
    public class DataService: ISprint6Task2V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Cos(i) + i == 0) res[i + 5] = 0;
                else res[i + 5] = Math.Round((2 * i - 3) / (Math.Cos(i) + i) + 5, 2);
            }
            return res;
        }
    }
}
