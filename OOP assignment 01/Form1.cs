using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Subscribe to events for each TextBox
            textBox1.GotFocus += TextBox_GotFocus;
            textBox1.LostFocus += TextBox_LostFocus;

            textBox2.GotFocus += TextBox_GotFocus;
            textBox2.LostFocus += TextBox_LostFocus;

            textBox3.GotFocus += TextBox_GotFocus;
            textBox3.LostFocus += TextBox_LostFocus;

            // Set the initial text for each TextBox
            textBox1.Text = "Please enter your name";
            textBox2.Text = "Operand 1";
            textBox3.Text = "Operand 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;

            label1.Text = "Hello " + inputText;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "Please enter your name")
            {
                textBox.Text = string.Empty; // Clear the description text
                textBox.ForeColor = SystemColors.WindowText; // Restore the default text color
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Please enter your name"; // Restore the description text
                textBox.ForeColor = SystemColors.GrayText; // Change text color to gray
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
