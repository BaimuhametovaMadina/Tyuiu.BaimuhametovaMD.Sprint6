namespace Tyuiu.BaimuhametovaMD.Sprint6.Task4.V8
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
            labelTask = new Label();
            textBoxTask = new TextBox();
            labelInput = new Label();
            labelInputStart = new Label();
            labelInputStop = new Label();
            textBoxInputStart = new TextBox();
            textBoxInputStop = new TextBox();
            textBoxResult = new TextBox();
            labelOutput = new Label();
            labelResult = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            SuspendLayout();
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(24, 21);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(56, 15);
            labelTask.TabIndex = 0;
            labelTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(24, 39);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(324, 45);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в TextBox и построить график.";
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(24, 130);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(77, 15);
            labelInput.TabIndex = 2;
            labelInput.Text = "Ввод данных";
            // 
            // labelInputStart
            // 
            labelInputStart.AutoSize = true;
            labelInputStart.Location = new Point(24, 161);
            labelInputStart.Name = "labelInputStart";
            labelInputStart.Size = new Size(72, 15);
            labelInputStart.TabIndex = 3;
            labelInputStart.Text = "Старт шага:";
            // 
            // labelInputStop
            // 
            labelInputStop.AutoSize = true;
            labelInputStop.Location = new Point(147, 161);
            labelInputStop.Name = "labelInputStop";
            labelInputStop.Size = new Size(75, 15);
            labelInputStop.TabIndex = 4;
            labelInputStop.Text = "Конец шага:";
            // 
            // textBoxInputStart
            // 
            textBoxInputStart.Location = new Point(24, 179);
            textBoxInputStart.Name = "textBoxInputStart";
            textBoxInputStart.Size = new Size(100, 23);
            textBoxInputStart.TabIndex = 5;
            // 
            // textBoxInputStop
            // 
            textBoxInputStop.Location = new Point(147, 179);
            textBoxInputStop.Name = "textBoxInputStop";
            textBoxInputStop.Size = new Size(100, 23);
            textBoxInputStop.TabIndex = 6;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(387, 61);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(159, 251);
            textBoxResult.TabIndex = 7;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(387, 21);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(86, 15);
            labelOutput.TabIndex = 8;
            labelOutput.Text = "Вывод данных";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(387, 42);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 9;
            labelResult.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(238, 289);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(26, 23);
            buttonHelp.TabIndex = 10;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(286, 289);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(83, 23);
            buttonDone.TabIndex = 11;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            chartResult.Location = new Point(552, 12);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(300, 300);
            chartResult.TabIndex = 12;
            chartResult.Text = "chart1";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(429, 318);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(117, 23);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Сохранить в файл";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 355);
            Controls.Add(buttonSave);
            Controls.Add(chartResult);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(labelResult);
            Controls.Add(labelOutput);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxInputStop);
            Controls.Add(textBoxInputStart);
            Controls.Add(labelInputStop);
            Controls.Add(labelInputStart);
            Controls.Add(labelInput);
            Controls.Add(textBoxTask);
            Controls.Add(labelTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 8 | Баймухаметова М.Д.";
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTask;
        private TextBox textBoxTask;
        private Label labelInput;
        private Label labelInputStart;
        private Label labelInputStop;
        private TextBox textBoxInputStart;
        private TextBox textBoxInputStop;
        private TextBox textBoxResult;
        private Label labelOutput;
        private Label labelResult;
        private Button buttonHelp;
        private Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private Button buttonSave;
    }
}
