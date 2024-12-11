using Tyuiu.BaimuhametovaMD.Sprint6.Task6.V23.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task6.V23
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5, ��������� ��������� ������ �����-24-1 ������������� ������ ���������", "���������", MessageBoxButtons.OK);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
