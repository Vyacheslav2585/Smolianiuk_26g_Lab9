namespace lab9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Якщо користувач натиснув "Cancel", вихід з функції
            if (input == "") return;

            // Змінна для збереження результату перетворення рядка
            string output = "";

            // Проходимося по кожному символу вхідного рядка
            for (int i = 0; i < input.Length; i++)
            {
                // Якщо символ не дорівнює "?", повторюємо його двічі
                if (input[i] != '?')
                {
                    output += input[i];
                    output += input[i];
                }
                // Якщо символ дорівнює "?", додаємо його без змін
                else
                {
                    output += input[i];
                }
            }

            // Виводимо вхідний та вихідний рядки в MessageBox
            textBox2.Text = output;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(413, 0);
        }
    }
}