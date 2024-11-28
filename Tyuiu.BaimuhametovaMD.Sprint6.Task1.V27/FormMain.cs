using System.Windows.Forms.Design.Behavior;
using Tyuiu.BaimuhametovaMD.Sprint6.Task1.V27.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task1.V27
{
    public partial class FormMain: Form
    {
        private int start;
        private int stop;
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox_Task_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_InputStop_Click(object sender, EventArgs e)
        {

        }

        private void label_Result_Click(object sender, EventArgs e)
        {

        }

        private void textBox_InputStart_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox_InputStop_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, выполнила студентка группы ИБКСб-24-1 Баймухаметова Мадина Дамировна", "Сообщение", MessageBoxButtons.OK);
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            try
            {
                start = Convert.ToInt32(textBox_InputStart.Text);
                stop = Convert.ToInt32(textBox_InputStop.Text);
                
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(start, stop);
            string line;
            textBox_Result.AppendText("+----------+----------+" + Environment.NewLine);
            textBox_Result.AppendText("+     x    +    f(x)  +" + Environment.NewLine);
            textBox_Result.AppendText("+----------+----------+" + Environment.NewLine);
            for (int i = 0; i < res.Length; i++)
            {
                line = String.Format("|{0,17:d}|{1,17:f}|", i - 5, res[i]);
                textBox_Result.AppendText(line + Environment.NewLine);
            }
            textBox_Result.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
