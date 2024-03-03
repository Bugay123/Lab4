namespace Lab4_FindWork
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
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "веб-дизайнер", "веб-програміст", "модератор сайтів", "системний адміністратор" });
            listBox1.Location = new Point(20, 20);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(151, 94);
            listBox1.Sorted = true;
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10000", "15000", "5000", "7000" });
            comboBox1.Location = new Point(20, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 23);
            comboBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(177, 21);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(20, 160);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 93);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 201);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private TextBox textBox1;
    }
}
