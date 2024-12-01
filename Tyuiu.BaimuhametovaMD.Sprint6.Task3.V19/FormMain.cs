using Tyuiu.BaimuhametovaMD.Sprint6.Task3.V19.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task3.V19
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
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
            dataGridViewResult.ColumnCount = res.GetLength(1);
            dataGridViewResult.RowCount = res.GetLength(0);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, выполнила студентка группы ИБКСб-24-1 Баймухаметова Мадина Дамировна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
