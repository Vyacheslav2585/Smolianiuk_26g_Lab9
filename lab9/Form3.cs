using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] words = RozdilZnak(input);
            string maxVowelWord = "";
            int maxVowelsCount = 0;

            foreach (string word in words)
            {
                int vowelsCount = CountVowels(word);
                if (vowelsCount > maxVowelsCount)
                {
                    maxVowelsCount = vowelsCount;
                    maxVowelWord = word;
                }
            }

            textBox2.Text = $"{maxVowelWord}";
        }

        private string[] RozdilZnak(string input)
        {
            char[] separators = { ' ', ',', '.', ';', ':', '-', '!', '?', '(', ')', '\r', '\n' };
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        private int CountVowels(string word)
        {
            string vowels = "УЕАОЄЯИЮЇІ уеаоєяиюїі";
            int count = 0;
            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 220);
        }
    }
}
