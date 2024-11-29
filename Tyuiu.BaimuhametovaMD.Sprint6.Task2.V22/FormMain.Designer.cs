namespace Tyuiu.BaimuhametovaMD.Sprint6.Task2.V22
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
            dataGridView_Result = new DataGridView();
            DataGrudView_x = new DataGridViewTextBoxColumn();
            DataGridView_func = new DataGridViewTextBoxColumn();
            label_Task = new Label();
            label_Output = new Label();
            textBox_Task = new TextBox();
            label_Input = new Label();
            textBox_InputStart = new TextBox();
            textBox_InputStop = new TextBox();
            label_InputStart = new Label();
            label_InputStop = new Label();
            label_Result = new Label();
            button_Help = new Button();
            button_Done = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Result).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Result
            // 
            dataGridView_Result.AllowUserToAddRows = false;
            dataGridView_Result.AllowUserToDeleteRows = false;
            dataGridView_Result.AllowUserToResizeColumns = false;
            dataGridView_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Result.Columns.AddRange(new DataGridViewColumn[] { DataGrudView_x, DataGridView_func });
            dataGridView_Result.Location = new Point(414, 82);
            dataGridView_Result.Name = "dataGridView_Result";
            dataGridView_Result.ReadOnly = true;
            dataGridView_Result.RowHeadersVisible = false;
            dataGridView_Result.Size = new Size(131, 270);
            dataGridView_Result.TabIndex = 0;
            // 
            // DataGrudView_x
            // 
            DataGrudView_x.HeaderText = "x";
            DataGrudView_x.Name = "DataGrudView_x";
            DataGrudView_x.ReadOnly = true;
            // 
            // DataGridView_func
            // 
            DataGridView_func.HeaderText = "f(x)";
            DataGridView_func.Name = "DataGridView_func";
            DataGridView_func.ReadOnly = true;
            // 
            // label_Task
            // 
            label_Task.AutoSize = true;
            label_Task.Location = new Point(28, 31);
            label_Task.Name = "label_Task";
            label_Task.Size = new Size(53, 15);
            label_Task.TabIndex = 1;
            label_Task.Text = "Условие";
            // 
            // label_Output
            // 
            label_Output.AutoSize = true;
            label_Output.Location = new Point(414, 31);
            label_Output.Name = "label_Output";
            label_Output.Size = new Size(86, 15);
            label_Output.TabIndex = 2;
            label_Output.Text = "Вывод данных";
            // 
            // textBox_Task
            // 
            textBox_Task.Location = new Point(28, 58);
            textBox_Task.Multiline = true;
            textBox_Task.Name = "textBox_Task";
            textBox_Task.ReadOnly = true;
            textBox_Task.Size = new Size(310, 54);
            textBox_Task.TabIndex = 3;
            textBox_Task.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // label_Input
            // 
            label_Input.AutoSize = true;
            label_Input.Location = new Point(28, 283);
            label_Input.Name = "label_Input";
            label_Input.Size = new Size(77, 15);
            label_Input.TabIndex = 4;
            label_Input.Text = "Ввод данных";
            // 
            // textBox_InputStart
            // 
            textBox_InputStart.Location = new Point(28, 329);
            textBox_InputStart.Name = "textBox_InputStart";
            textBox_InputStart.Size = new Size(100, 23);
            textBox_InputStart.TabIndex = 5;
            // 
            // textBox_InputStop
            // 
            textBox_InputStop.Location = new Point(143, 329);
            textBox_InputStop.Name = "textBox_InputStop";
            textBox_InputStop.Size = new Size(100, 23);
            textBox_InputStop.TabIndex = 6;
            // 
            // label_InputStart
            // 
            label_InputStart.AutoSize = true;
            label_InputStart.Location = new Point(28, 311);
            label_InputStart.Name = "label_InputStart";
            label_InputStart.Size = new Size(72, 15);
            label_InputStart.TabIndex = 7;
            label_InputStart.Text = "Старт шага:";
            // 
            // label_InputStop
            // 
            label_InputStop.AutoSize = true;
            label_InputStop.Location = new Point(143, 311);
            label_InputStop.Name = "label_InputStop";
            label_InputStop.Size = new Size(75, 15);
            label_InputStop.TabIndex = 8;
            label_InputStop.Text = "Конец шага:";
            // 
            // label_Result
            // 
            label_Result.AutoSize = true;
            label_Result.Location = new Point(424, 52);
            label_Result.Name = "label_Result";
            label_Result.Size = new Size(63, 15);
            label_Result.TabIndex = 9;
            label_Result.Text = "Результат:";
            // 
            // button_Help
            // 
            button_Help.Location = new Point(270, 329);
            button_Help.Name = "button_Help";
            button_Help.Size = new Size(22, 23);
            button_Help.TabIndex = 10;
            button_Help.Text = "?";
            button_Help.UseVisualStyleBackColor = true;
            button_Help.Click += button_Help_Click;
            // 
            // button_Done
            // 
            button_Done.Location = new Point(298, 274);
            button_Done.Name = "button_Done";
            button_Done.Size = new Size(90, 78);
            button_Done.TabIndex = 11;
            button_Done.Text = "Выполнить";
            button_Done.UseVisualStyleBackColor = true;
            button_Done.Click += button_Done_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 368);
            Controls.Add(button_Done);
            Controls.Add(button_Help);
            Controls.Add(label_Result);
            Controls.Add(label_InputStop);
            Controls.Add(label_InputStart);
            Controls.Add(textBox_InputStop);
            Controls.Add(textBox_InputStart);
            Controls.Add(label_Input);
            Controls.Add(textBox_Task);
            Controls.Add(label_Output);
            Controls.Add(label_Task);
            Controls.Add(dataGridView_Result);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 22 | Баймухаметова М.Д.";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Result).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Result;
        private DataGridViewTextBoxColumn DataGrudView_x;
        private DataGridViewTextBoxColumn DataGridView_func;
        private Label label_Task;
        private Label label_Output;
        private TextBox textBox_Task;
        private Label label_Input;
        private TextBox textBox_InputStart;
        private TextBox textBox_InputStop;
        private Label label_InputStart;
        private Label label_InputStop;
        private Label label_Result;
        private Button button_Help;
        private Button button_Done;
    }
}
