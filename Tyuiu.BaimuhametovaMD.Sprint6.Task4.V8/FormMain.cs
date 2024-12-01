using Tyuiu.BaimuhametovaMD.Sprint6.Task4.V8.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task4.V8
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxInputStart.Text);
                int stop = Convert.ToInt32(textBoxInputStop.Text);
                this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                DataService ds = new DataService();
                double[] res = ds.GetMassFunction(start, stop);
                string line;
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("+     x    +    f(x)  +" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < res.Length; i++)
                {
                    this.chartResult.Series[0].Points.AddXY(i - 5, res[i]);
                    Console.WriteLine(res[i]);
                    line = String.Format("|{0,5:d}   |{1, 5:f2}   |", i - 5, res[i]);
                    textBoxResult.AppendText(line + Environment.NewLine);
                }
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4, выполнила студентка группы ИБКСб-24-1 Баймухаметова Мадина Дамировна", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4.txt");
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dres = MessageBox.Show("Данные сохранены в файл " + path + ".\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dres == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
