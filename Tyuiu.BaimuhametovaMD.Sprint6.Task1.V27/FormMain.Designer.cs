namespace Tyuiu.BaimuhametovaMD.Sprint6.Task1.V27
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
            label_Task = new Label();
            textBox_Task = new TextBox();
            label_Input = new Label();
            textBox_InputStart = new TextBox();
            label_InputStart = new Label();
            label_InputStop = new Label();
            textBox_InputStop = new TextBox();
            button_Help = new Button();
            button_Done = new Button();
            textBox_Result = new TextBox();
            label_Output = new Label();
            label_Result = new Label();
            SuspendLayout();
            // 
            // label_Task
            // 
            label_Task.AutoSize = true;
            label_Task.Location = new Point(39, 35);
            label_Task.Name = "label_Task";
            label_Task.Size = new Size(53, 15);
            label_Task.TabIndex = 0;
            label_Task.Text = "Условие";
            // 
            // textBox_Task
            // 
            textBox_Task.Location = new Point(39, 53);
            textBox_Task.Multiline = true;
            textBox_Task.Name = "textBox_Task";
            textBox_Task.ReadOnly = true;
            textBox_Task.Size = new Size(310, 44);
            textBox_Task.TabIndex = 1;
            textBox_Task.TabStop = false;
            textBox_Task.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в виде таблицы.";
            textBox_Task.TextChanged += textBox_Task_TextChanged;
            // 
            // label_Input
            // 
            label_Input.AutoSize = true;
            label_Input.Location = new Point(42, 304);
            label_Input.Name = "label_Input";
            label_Input.Size = new Size(77, 15);
            label_Input.TabIndex = 2;
            label_Input.Text = "Ввод данных";
            // 
            // textBox_InputStart
            // 
            textBox_InputStart.Location = new Point(42, 343);
            textBox_InputStart.Name = "textBox_InputStart";
            textBox_InputStart.Size = new Size(100, 23);
            textBox_InputStart.TabIndex = 3;
            textBox_InputStart.TextChanged += textBox_InputStart_TextChanged;
            // 
            // label_InputStart
            // 
            label_InputStart.AutoSize = true;
            label_InputStart.Location = new Point(42, 325);
            label_InputStart.Name = "label_InputStart";
            label_InputStart.Size = new Size(72, 15);
            label_InputStart.TabIndex = 4;
            label_InputStart.Text = "Старт шага:";
            // 
            // label_InputStop
            // 
            label_InputStop.AutoSize = true;
            label_InputStop.Location = new Point(182, 325);
            label_InputStop.Name = "label_InputStop";
            label_InputStop.Size = new Size(75, 15);
            label_InputStop.TabIndex = 5;
            label_InputStop.Text = "Конец шага:";
            label_InputStop.Click += label_InputStop_Click;
            // 
            // textBox_InputStop
            // 
            textBox_InputStop.Location = new Point(182, 343);
            textBox_InputStop.Name = "textBox_InputStop";
            textBox_InputStop.Size = new Size(100, 23);
            textBox_InputStop.TabIndex = 6;
            textBox_InputStop.TextChanged += textBox_InputStop_TextChanged;
            // 
            // button_Help
            // 
            button_Help.Location = new Point(330, 319);
            button_Help.Name = "button_Help";
            button_Help.Size = new Size(45, 47);
            button_Help.TabIndex = 7;
            button_Help.Text = "?";
            button_Help.UseVisualStyleBackColor = true;
            button_Help.Click += button_Help_Click;
            // 
            // button_Done
            // 
            button_Done.Location = new Point(381, 287);
            button_Done.Name = "button_Done";
            button_Done.Size = new Size(103, 79);
            button_Done.TabIndex = 8;
            button_Done.Text = "Выполнить";
            button_Done.UseVisualStyleBackColor = true;
            button_Done.Click += button_Done_Click;
            // 
            // textBox_Result
            // 
            textBox_Result.Location = new Point(543, 83);
            textBox_Result.Multiline = true;
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.Size = new Size(198, 283);
            textBox_Result.TabIndex = 9;
            // 
            // label_Output
            // 
            label_Output.AutoSize = true;
            label_Output.Location = new Point(543, 35);
            label_Output.Name = "label_Output";
            label_Output.Size = new Size(86, 15);
            label_Output.TabIndex = 10;
            label_Output.Text = "Вывод данных";
            // 
            // label_Result
            // 
            label_Result.AutoSize = true;
            label_Result.Location = new Point(543, 65);
            label_Result.Name = "label_Result";
            label_Result.Size = new Size(63, 15);
            label_Result.TabIndex = 11;
            label_Result.Text = "Результат:";
            label_Result.Click += label_Result_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Result);
            Controls.Add(label_Output);
            Controls.Add(textBox_Result);
            Controls.Add(button_Done);
            Controls.Add(button_Help);
            Controls.Add(textBox_InputStop);
            Controls.Add(label_InputStop);
            Controls.Add(label_InputStart);
            Controls.Add(textBox_InputStart);
            Controls.Add(label_Input);
            Controls.Add(textBox_Task);
            Controls.Add(label_Task);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 27 | Баймухаметова М.Д.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Task;
        private TextBox textBox_Task;
        private Label label_Input;
        private TextBox textBox_InputStart;
        private Label label_InputStart;
        private Label label_InputStop;
        private TextBox textBox_InputStop;
        private Button button_Help;
        private Button button_Done;
        private TextBox textBox_Result;
        private Label label_Output;
        private Label label_Result;
    }
}
