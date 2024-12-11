namespace Tyuiu.BaimuhametovaMD.Sprint6.Task7.V1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOpen = new Button();
            buttonDone = new Button();
            buttonSave = new Button();
            ButtonHelp = new Button();
            labelTask = new Label();
            textBoxTask = new TextBox();
            dataGridViewInput = new DataGridView();
            labelInput = new Label();
            dataGridViewOutput = new DataGridView();
            labelOutput = new Label();
            saveFileDialogTask = new SaveFileDialog();
            openFileDialogTask = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(14, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 55);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(105, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(78, 55);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(624, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(92, 55);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить результат";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // ButtonHelp
            // 
            ButtonHelp.Location = new Point(722, 12);
            ButtonHelp.Name = "ButtonHelp";
            ButtonHelp.Size = new Size(66, 55);
            ButtonHelp.TabIndex = 3;
            ButtonHelp.Text = "?";
            ButtonHelp.UseVisualStyleBackColor = true;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(14, 73);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(56, 15);
            labelTask.TabIndex = 4;
            labelTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(14, 94);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(761, 34);
            textBoxTask.TabIndex = 5;
            textBoxTask.Text = "Дан файл. Загрузить афйл через openFileDialog в объект DataGridViewIn. Изменить во втором столбце отрицательные значения на 1. Результат вывести в объект DataGridViewOut.";
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.ColumnHeadersVisible = false;
            dataGridViewInput.Location = new Point(14, 143);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.RowHeadersVisible = false;
            dataGridViewInput.Size = new Size(364, 295);
            dataGridViewInput.TabIndex = 6;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(14, 125);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(36, 15);
            labelInput.TabIndex = 7;
            labelInput.Text = "Ввод:";
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.ColumnHeadersVisible = false;
            dataGridViewOutput.Location = new Point(384, 143);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.Size = new Size(404, 295);
            dataGridViewOutput.TabIndex = 8;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(384, 125);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(45, 15);
            labelOutput.TabIndex = 9;
            labelOutput.Text = "Вывод:";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOutput);
            Controls.Add(dataGridViewOutput);
            Controls.Add(labelInput);
            Controls.Add(dataGridViewInput);
            Controls.Add(textBoxTask);
            Controls.Add(labelTask);
            Controls.Add(ButtonHelp);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen;
        private Button buttonDone;
        private Button buttonSave;
        private Button ButtonHelp;
        private Label labelTask;
        private TextBox textBoxTask;
        private DataGridView dataGridViewInput;
        private Label labelInput;
        private DataGridView dataGridViewOutput;
        private Label labelOutput;
        private SaveFileDialog saveFileDialogTask;
        private OpenFileDialog openFileDialogTask;
    }
}
