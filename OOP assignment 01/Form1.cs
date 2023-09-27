using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.GotFocus += TextBox_GotFocus;
            textBox1.LostFocus += TextBox_LostFocus;

            textBox2.GotFocus += TextBox_GotFocus;
            textBox2.LostFocus += TextBox_LostFocus;

            textBox3.GotFocus += TextBox_GotFocus;
            textBox3.LostFocus += TextBox_LostFocus;

            textBox4.GotFocus += TextBox_GotFocus;
            textBox4.LostFocus += TextBox_LostFocus;

            textBox5.GotFocus += TextBox_GotFocus;
            textBox5.LostFocus += TextBox_LostFocus;

            textBox1.Text = "Please enter your name";
            textBox2.Text = "Operand 1";
            textBox3.Text = "Operand 2";
            textBox4.Text = "Please enter your date of birth";
            textBox5.Text = "Please enter a sentence";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.Trim();

            if (inputText.Equals("Please enter your name", StringComparison.OrdinalIgnoreCase))
            {
                label1.Text = "Hello";
            }
            else
            {
                label1.Text = "Hello " + inputText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputText1 = textBox2.Text;
            string inputText2 = textBox3.Text;

            float floatValue1;
            float floatValue2;

            if (float.TryParse(inputText1, out floatValue1) && float.TryParse(inputText2, out floatValue2))
            {
                float result = floatValue1 * floatValue2;

                label2.Text = result.ToString();
            }
            else
            {
                label2.Text = "Invalid input. Please enter valid float values.";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string inputText1 = textBox2.Text;
            string inputText2 = textBox3.Text;

            float floatValue1;
            float floatValue2;

            if (float.TryParse(inputText1, out floatValue1) && float.TryParse(inputText2, out floatValue2))
            {
                float result = floatValue1 + floatValue2;

                label2.Text = result.ToString();
            }
            else
            {
                label2.Text = "Invalid input. Please enter valid float values.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputText1 = textBox2.Text;
            string inputText2 = textBox3.Text;

            float floatValue1;
            float floatValue2;

            if (float.TryParse(inputText1, out floatValue1) && float.TryParse(inputText2, out floatValue2))
            {
                float result = floatValue1 - floatValue2;

                label2.Text = result.ToString();
            }
            else
            {
                label2.Text = "Invalid input. Please enter valid float values.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inputText1 = textBox2.Text;
            string inputText2 = textBox3.Text;

            float floatValue1;
            float floatValue2;

            if (float.TryParse(inputText1, out floatValue1) && float.TryParse(inputText2, out floatValue2))
            {
                float result = floatValue1 / floatValue2;

                label2.Text = result.ToString();
            }
            else
            {
                label2.Text = "Invalid input. Please enter valid float values.";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string inputText1 = textBox2.Text;
            string inputText2 = textBox3.Text;

            float floatValue1;
            float floatValue2;

            if (float.TryParse(inputText1, out floatValue1) && float.TryParse(inputText2, out floatValue2))
            {
                float result = floatValue1 % floatValue2;

                label2.Text = result.ToString();
            }
            else
            {
                label2.Text = "Invalid input. Please enter valid float values.";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string userInput = textBox4.Text;

            string inputFormat = "yyyy-MM-dd";

            DateTime parsedDate;
            if (DateTime.TryParse(userInput, out parsedDate))
            {
                Console.WriteLine($"Parsed Date: {parsedDate}");
            }
            else
            {
                Console.WriteLine("Invalid date input. Please enter a valid date.");
            }

            if (DateTime.TryParseExact(userInput, inputFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {

                DateTime currentDate = DateTime.Today;
                TimeSpan difference = currentDate - parsedDate;

                int differenceInDays = (int)difference.TotalDays;

                label3.Text = $"You are {differenceInDays} days old";
            }
            else
            {
                label3.Text = "Invalid date input. Please enter a valid date in the format yyyy-mm-dd.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string text = textBox5.Text;
            int characterCount = text.Length;
            label4.Text = "Your sentence has " + characterCount.ToString() + " characters";
        }

        private bool isGreen = false;

        private void button9_Click(object sender, EventArgs e)
        {
            if (isGreen)
            {
                // Change the color to Red
                panel1.BackColor = Color.Red;
                isGreen = false;
            }
            else
            {
                // Change the color to Green
                panel1.BackColor = Color.Green;
                isGreen = true;
            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            if (textBox.Text == "Please enter your name" || textBox.Text == "Operand 1" || textBox.Text == "Operand 2" || 
                textBox.Text == "Please enter your date of birth" || textBox.Text == "Please enter a sentence")
            {
                textBox.Text = string.Empty; 
                textBox.ForeColor = SystemColors.WindowText; 
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == textBox1)
                {
                    textBox.Text = "Please enter your name"; 
                }
                else if (textBox == textBox2)
                {
                    textBox.Text = "Operand 1";
                }
                else if (textBox == textBox3)
                {
                    textBox.Text = "Operand 2";
                }
                else if (textBox == textBox4)
                {
                    textBox.Text = "Please enter your date of birth";
                }
                else if (textBox == textBox5)
                {
                    textBox.Text = "Please enter a sentence";
                }

                textBox.ForeColor = SystemColors.GrayText;
            }
        }
    }
}