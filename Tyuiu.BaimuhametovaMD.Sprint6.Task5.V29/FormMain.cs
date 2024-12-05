using Tyuiu.BaimuhametovaMD.Sprint6.Task5.V29.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task5.V29
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V29.txt");

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";
            double[] nums = ds.LoadFromDataFile(path);

            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartResult.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5, выполнила студентка группы ИБКСб-24-1 Баймухаметова Мадина Дамировна", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
