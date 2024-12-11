using Tyuiu.BaimuhametovaMD.Sprint6.Task7.V1.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task7.V1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        private int[,] getData(string path)
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
            }
            return res;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            buttonDone.Enabled = true;
            int[,] ints = getData(openFilePath);
            rows = ints.GetLength(0);
            columns = ints.GetLength(1);
            dataGridViewInput.ColumnCount = columns;
            dataGridViewInput.RowCount = rows;
            dataGridViewOutput.ColumnCount = columns;
            dataGridViewOutput.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
                dataGridViewOutput.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput.Rows[i].Cells[j].Value = ints[i, j];
                }
            }
            ints = ds.GetMatrix(openFilePath);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutputFileTask7V1.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();

            string path = saveFileDialogTask.FileName;
            int rows = dataGridViewOutput.Rows.Count;
            int columns = dataGridViewOutput.Columns.Count;
            string str = "";
            File.WriteAllText(path, str);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1) str += dataGridViewOutput.Rows[i].Cells[j].Value + ";";
                    else str += dataGridViewOutput.Rows[i].Cells[j].Value;
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] ints = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = ints[i, j];
                }
            }
            buttonSave.Enabled = true;
        }
    }
}
