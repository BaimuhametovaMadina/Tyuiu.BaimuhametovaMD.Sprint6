using Tyuiu.BaimuhametovaMD.Sprint6.Task0.V17.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task0.V17
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
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVar.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, выполнила студентка группы ИБКСб-24-1 Баймухаметова Мадина Дамировна", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar!= 8))
            {
                e.Handled = true;
            }
        }
    }
}
