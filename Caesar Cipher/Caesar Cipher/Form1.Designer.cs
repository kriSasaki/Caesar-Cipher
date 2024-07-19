namespace Caesar_Cipher
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
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            richTextBox2 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(307, 284);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(12, 343);
            button2.Name = "button2";
            button2.Size = new Size(242, 23);
            button2.TabIndex = 4;
            button2.Text = "Зашифровать/дешифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Encrypt;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(325, 53);
            numericUpDown1.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 21);
            numericUpDown1.TabIndex = 6;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(451, 52);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(307, 284);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 19);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(120, 21);
            textBox1.TabIndex = 8;
            textBox1.Text = "Число сдвига";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 19);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(307, 21);
            textBox2.TabIndex = 9;
            textBox2.Text = "Напишите текст для шифрования/дешифрования";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private RichTextBox richTextBox2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
