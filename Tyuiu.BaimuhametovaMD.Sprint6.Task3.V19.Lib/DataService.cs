using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task3.V19.Lib
{
    public class DataService: ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int jlen = matrix.GetLength(1) - 1;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i, jlen] > matrix[i+1, jlen])
                {
                    int t = matrix[i, jlen];
                    matrix[i, jlen] = matrix[i+1, jlen];
                    matrix[i+1, jlen] = t;
                }
            }
            for (int i = matrix.GetLength(0) - 1; i > 0; i--)
            {
                if (matrix[i, jlen] < matrix[i - 1, jlen])
                {
                    int t = matrix[i, jlen];
                    matrix[i, jlen] = matrix[i - 1, jlen];
                    matrix[i - 1, jlen] = t;
                }
            }
            return matrix;
        }
    }
}
