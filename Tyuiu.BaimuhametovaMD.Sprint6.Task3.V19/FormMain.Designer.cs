namespace Tyuiu.BaimuhametovaMD.Sprint6.Task3.V19
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
            labelTask = new Label();
            textBox1 = new TextBox();
            labelMatrix = new Label();
            textBox2 = new TextBox();
            dataGridViewResult = new DataGridView();
            first = new DataGridViewTextBoxColumn();
            second = new DataGridViewTextBoxColumn();
            third = new DataGridViewTextBoxColumn();
            fourth = new DataGridViewTextBoxColumn();
            fifth = new DataGridViewTextBoxColumn();
            buttonHelp = new Button();
            buttonDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(38, 36);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(56, 15);
            labelTask.TabIndex = 0;
            labelTask.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 54);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(419, 38);
            textBox1.TabIndex = 1;
            textBox1.Text = "Дана матрица 5 на 5 элементов. Выполнить сортировку по возрастанию в пятом столбце.";
            // 
            // labelMatrix
            // 
            labelMatrix.AutoSize = true;
            labelMatrix.Location = new Point(38, 107);
            labelMatrix.Name = "labelMatrix";
            labelMatrix.Size = new Size(59, 15);
            labelMatrix.TabIndex = 2;
            labelMatrix.Text = "Матрица:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(38, 135);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(89, 85);
            textBox2.TabIndex = 3;
            textBox2.Text = "4 32 -20 27 21 17 15 -1 -2 -1 -3 18 12 -10 29 7 -15 2 -8 12 -10 25 5 27 21";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { first, second, third, fourth, fifth });
            dataGridViewResult.Location = new Point(524, 37);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(241, 209);
            dataGridViewResult.TabIndex = 4;
            // 
            // first
            // 
            first.HeaderText = "Column1";
            first.Name = "first";
            first.ReadOnly = true;
            // 
            // second
            // 
            second.HeaderText = "Column2";
            second.Name = "second";
            second.ReadOnly = true;
            // 
            // third
            // 
            third.HeaderText = "Column3";
            third.Name = "third";
            third.ReadOnly = true;
            // 
            // fourth
            // 
            fourth.HeaderText = "Column4";
            fourth.Name = "fourth";
            fourth.ReadOnly = true;
            // 
            // fifth
            // 
            fifth.HeaderText = "Column5";
            fifth.Name = "fifth";
            fifth.ReadOnly = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(362, 197);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(26, 23);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(394, 152);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(95, 68);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 286);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(dataGridViewResult);
            Controls.Add(textBox2);
            Controls.Add(labelMatrix);
            Controls.Add(textBox1);
            Controls.Add(labelTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Баймухаметова М.Д.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTask;
        private TextBox textBox1;
        private Label labelMatrix;
        private TextBox textBox2;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn first;
        private DataGridViewTextBoxColumn second;
        private DataGridViewTextBoxColumn third;
        private DataGridViewTextBoxColumn fourth;
        private DataGridViewTextBoxColumn fifth;
        private Button buttonHelp;
        private Button buttonDone;
    }
}
