namespace Tyuiu.BaimuhametovaMD.Sprint6.Task5.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHelp = new Button();
            buttonOpen = new Button();
            buttonDone = new Button();
            labelTask = new Label();
            textBoxTask = new TextBox();
            dataGridViewResult = new DataGridView();
            index = new DataGridViewTextBoxColumn();
            number = new DataGridViewTextBoxColumn();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            chartResult.Location = new Point(149, 96);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(639, 342);
            chartResult.TabIndex = 0;
            chartResult.Text = "chart1";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(714, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(74, 66);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(633, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 66);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(542, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(85, 66);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(31, 7);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(53, 15);
            labelTask.TabIndex = 4;
            labelTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(31, 25);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(477, 43);
            textBoxTask.TabIndex = 5;
            textBoxTask.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView и построить диаграмму по этим значениям.";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToDeleteRows = false;
            dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { index, number });
            dataGridViewResult.Location = new Point(0, 106);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(143, 318);
            dataGridViewResult.TabIndex = 6;
            // 
            // index
            // 
            index.HeaderText = "1";
            index.Name = "index";
            index.ReadOnly = true;
            // 
            // number
            // 
            number.HeaderText = "2";
            number.Name = "number";
            number.ReadOnly = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(31, 88);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(89, 15);
            labelResult.TabIndex = 7;
            labelResult.Text = "Вывод данных:";
            labelResult.Click += labelResult_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(dataGridViewResult);
            Controls.Add(textBoxTask);
            Controls.Add(labelTask);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpen);
            Controls.Add(buttonHelp);
            Controls.Add(chartResult);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант  29 | Баймухаметова М.Д.";
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private Button buttonHelp;
        private Button buttonOpen;
        private Button buttonDone;
        private Label labelTask;
        private TextBox textBoxTask;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn number;
        private Label labelResult;
    }
}
