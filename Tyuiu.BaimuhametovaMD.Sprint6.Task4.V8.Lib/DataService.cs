using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task4.V8.Lib
{
    public class DataService: ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 - i == 0) res[i + 5] = 0;
                else res[i + 5] = Math.Round(Math.Sin(i) + (Math.Cos(i) + 1) / (2 - i) + 2 * i, 2);
            }
            return res;
        }
    }
}
