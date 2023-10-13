using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace labs_nau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            button1.Visible = checkBox4.Checked;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter a message here.";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button2.Visible = checkBox3.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = !button1.Enabled;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = !button2.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("notepad.exe");
            comboBox1.Items.Add("calc.exe");
            comboBox1.Items.Add("cmd.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Process.Start(comboBox1.SelectedItem.ToString());
            }
            else { Process.Start(comboBox1.Text); }

           
            
                   
                   
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedText = comboBox1.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedText))
            {
                MessageBox.Show("Поточне значення поля із списком: " + selectedText);
            }
            else
            {
                MessageBox.Show("Поле із списком порожнє.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
          Application.Exit();
        }
    }
}
