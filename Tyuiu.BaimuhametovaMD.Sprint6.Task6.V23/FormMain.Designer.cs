namespace Tyuiu.BaimuhametovaMD.Sprint6.Task6.V23
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            buttonOpen = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            buttonHelp = new Button();
            buttonDone = new Button();
            labelTask = new Label();
            textBoxTask = new TextBox();
            labelInput = new Label();
            labelOutput = new Label();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(12, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(71, 55);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(713, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 55);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(89, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(78, 55);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(11, 70);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(56, 15);
            labelTask.TabIndex = 3;
            labelTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(14, 90);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(744, 22);
            textBoxTask.TabIndex = 4;
            textBoxTask.Text = "Дан файл. Загрузить файл в TextBoxIn через OpenFileDialog. Найти и вывести в результирующую строку все слова, содержащие s.";
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(14, 122);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(36, 15);
            labelInput.TabIndex = 5;
            labelInput.Text = "Ввод:";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(407, 122);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(45, 15);
            labelOutput.TabIndex = 6;
            labelOutput.Text = "Вывод:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(20, 147);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.Size = new Size(373, 247);
            textBoxInput.TabIndex = 7;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(407, 147);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(373, 247);
            textBoxOutput.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Controls.Add(labelOutput);
            Controls.Add(labelInput);
            Controls.Add(textBoxTask);
            Controls.Add(labelTask);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpen);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 23 | Баймухаметова М.Д.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private Button buttonHelp;
        private Button buttonDone;
        private Label labelTask;
        private TextBox textBoxTask;
        private Label labelInput;
        private Label labelOutput;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
    }
}
