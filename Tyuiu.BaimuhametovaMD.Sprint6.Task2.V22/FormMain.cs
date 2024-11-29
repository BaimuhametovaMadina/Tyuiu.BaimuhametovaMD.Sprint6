using Tyuiu.BaimuhametovaMD.Sprint6.Task2.V22.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task2.V22
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBox_InputStart.Text);
                int stop = Convert.ToInt32(textBox_InputStop.Text);

                DataService ds = new DataService();
                double[] res = ds.GetMassFunction(start, stop);

                for (int i = 0; i < res.Length; i++)
                {
                    this.dataGridView_Result.Rows.Add(Convert.ToString(i - 5), Convert.ToString(res[i]));
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, выполнила студентка группы ИБКСб-24-1 Баймухаметова Мадина Дамировна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
