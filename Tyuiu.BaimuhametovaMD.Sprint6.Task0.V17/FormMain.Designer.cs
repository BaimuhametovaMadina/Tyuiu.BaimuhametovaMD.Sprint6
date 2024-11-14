namespace Tyuiu.BaimuhametovaMD.Sprint6.Task0.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone = new Button();
            textBoxVar = new TextBox();
            Условие = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBoxResult = new TextBox();
            label3 = new Label();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(286, 168);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(117, 43);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxVar
            // 
            textBoxVar.Location = new Point(38, 188);
            textBoxVar.Name = "textBoxVar";
            textBoxVar.Size = new Size(96, 23);
            textBoxVar.TabIndex = 1;
            textBoxVar.TextChanged += textBox1_TextChanged;
            textBoxVar.KeyPress += textBoxVar_KeyPress;
            // 
            // Условие
            // 
            Условие.BackColor = SystemColors.Menu;
            Условие.BorderStyle = BorderStyle.None;
            Условие.Location = new Point(38, 59);
            Условие.Multiline = true;
            Условие.Name = "Условие";
            Условие.ReadOnly = true;
            Условие.Size = new Size(232, 97);
            Условие.TabIndex = 4;
            Условие.TabStop = false;
            Условие.Text = "Вычислить выражение по формуле";
            Условие.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Условие";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 159);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Переменная X:";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(269, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(164, 188);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(96, 23);
            textBoxResult.TabIndex = 8;
            textBoxResult.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 159);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(381, 133);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(22, 23);
            buttonHelp.TabIndex = 10;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 251);
            Controls.Add(buttonHelp);
            Controls.Add(label3);
            Controls.Add(textBoxResult);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Условие);
            Controls.Add(textBoxVar);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 17 | Баймухаметова М.Д.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private TextBox textBoxVar;
        private TextBox Условие;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBoxResult;
        private Label label3;
        private Button buttonHelp;
    }
}
