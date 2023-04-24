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
            // Виводимо вікно з запитом ввести текст
            // Перевіряємо, чи було введено текст
            if (inputText != "")
            {
                // Виконуємо видалення букви 'к' з рядка
                string outputText = "";
                foreach (char c in inputText)
                {
                    if (c != 'к')
                    {
                        outputText += c;
                    }
                }

                // Виводимо вхідний та вихідний текст 
                textBox2.Text = outputText;
            }
            else
            {
                MessageBox.Show("Текст не було введено!", "Помилка");
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