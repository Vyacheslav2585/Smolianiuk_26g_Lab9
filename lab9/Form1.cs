namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Location = new Point(10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            // �������� ���� � ������� ������ �����
            // ����������, �� ���� ������� �����
            if (inputText != "")
            {
                // �������� ��������� ����� '�' � �����
                string outputText = "";
                foreach (char c in inputText)
                {
                    if (c != '�')
                    {
                        outputText += c;
                    }
                }

                // �������� ������� �� �������� ����� 
                textBox2.Text = outputText;
            }
            else
            {
                MessageBox.Show("����� �� ���� �������!", "�������");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}