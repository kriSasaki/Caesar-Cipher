namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        int ASCII;

        public Form1()
        {
            InitializeComponent();
        }

        private void Encrypt(object sender, EventArgs e)
        {
            richTextBox2.Text = null;

            for(int i = 0; i < richTextBox1.Text.Length; i++)
            {
                ASCII = (int)richTextBox1.Text[i];
                richTextBox2.Text += (char)(ASCII + numericUpDown1.Value);
            }
        }
    }
}
