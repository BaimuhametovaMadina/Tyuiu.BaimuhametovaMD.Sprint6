using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task6.V23.Lib
{
    public class DataService: ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            string[] str = File.ReadAllText(path).Replace("\n", " ").Split(" ");
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Contains('s')) res += str[i] + " ";
            }
            return res;
        }
    }
}
