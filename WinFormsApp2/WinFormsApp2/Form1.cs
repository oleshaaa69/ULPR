namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            while (a != -1)
            {
                a = richTextBox1.Find(textBox1.Text, a, RichTextBoxFinds.None);
                if (a != -1)
                {
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectionStart = a;
                    richTextBox1.SelectionLength = textBox1.Text.Length;
                    a++;
                    break;
                }
                else
                {
                    richTextBox1.SelectionColor = Color.Black;
                    MessageBox.Show("Совпадений не найдено!");
                    break;
                    
                }
            }            
            richTextBox1.Select(1, 0);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;  
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
