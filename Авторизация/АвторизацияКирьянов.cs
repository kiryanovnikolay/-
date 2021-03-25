using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtorizaciya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user1" && textBox2.Text == "12345")
            {
                Form2 s = new Form2();
                s.Show();
                this.Hide();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
