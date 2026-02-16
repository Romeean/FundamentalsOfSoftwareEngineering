using System;
using System.Diagnostics.Metrics;
using System.IO;            
using System.Linq;          
using System.Text.RegularExpressions; 
using System.Windows.Forms;





namespace thrid_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All files | *.*";
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string fullPathName = openFileDialog.FileName;
            FileInfo src = new FileInfo(fullPathName);
            filename.Text = src.FullName;

            textBox1.Text = File.ReadAllText(fullPathName);
            calculate(textBox1.Text);
        }

        private void filename_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void calculate(string fileValue)
        {
            string vowels = "аеєиіїоуюяАЕЄИІЇОУЮЯ";
            string punctuationMarks = " .,!?;:-()\"'\" ";

            int lengthBytes = System.Text.Encoding.UTF8.GetByteCount(fileValue);
            int chars = 0;
            int paragraphs = 0;
            int emptyLines = 0;
            int authorsPages = 0;     // 1 author page = more than 1800 chars
            int consonantLetters = 0; // cyrillic
            int vowelsLetters = 0;     // cyrillic
            int numbers = 0;
            int specSymbols = 0;
            int punctuations = 0;
            int cyrillycLetters = 0;
            int latinLetters = 0;

            for (int i = 0; i < fileValue.Length; i++)
            {

                char currentChar = fileValue[i];
                chars++;

                if (char.IsDigit(currentChar))
                {
                    numbers++;
                }
                else if (!char.IsWhiteSpace(currentChar))
                {
                    specSymbols++;
                }

                if (char.IsLetter(currentChar))
                {
                    if ((currentChar >= 'A' && currentChar <= 'Z') || (currentChar >= 'a' && currentChar <= 'z'))
                    {
                        latinLetters++;
                    }

                    else if (currentChar >= 'А' && currentChar <= 'я')
                    {
                        cyrillycLetters++;
                        if (vowels.Contains(currentChar))
                        {
                            vowelsLetters++;
                        }
                        else
                        {
                            consonantLetters++;
                        }
                    }

                }
                if (!char.IsWhiteSpace(currentChar))
                {
                    specSymbols++;
                }
                if (punctuationMarks.Contains(currentChar))
                {
                    punctuations++;
                }




            }
            authorsPages = chars / 1800;
            string[] lines = fileValue.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    emptyLines++;
                else
                    paragraphs++;
            }

            string stats = $"Размір файлу (в байтах): {lengthBytes}\r\n" +
                           $"Всього символів: {chars}\r\n" +
                           $"Абзаців: {paragraphs}\r\n" +
                           $"Пустих строк: {emptyLines}\r\n" +
                           $"Авторських сторінок: {authorsPages}\r\n" +
                           $"Цифр: {numbers}\r\n" +
                           $"Голосных (кірилиця): {vowelsLetters}\r\n" +
                           $"Приголосных (кірилиця): {consonantLetters}\r\n" +
                           $"Кірилиця всього: {cyrillycLetters}\r\n" +
                           $"Латиниця всього: {latinLetters}\r\n" +
                           $"Пунктуація: {punctuations}\r\n" +
                           $"Спецсимволів: {specSymbols}\r\n";

            textBox2.Text = stats;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
