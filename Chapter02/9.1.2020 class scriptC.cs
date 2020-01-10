using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag;
            decimal Operand1;
            decimal Operand2;
            decimal answer;
            flag = decimal.TryParse(txtOperand1.Text, out Operand1);
            if (flag == false)

            {
                MessageBox.Show("Enter a whole number", "Input error");
                txtOperand1.Focus();
                return;
            }


            flag = decimal.TryParse(txtOperand2.Text, out Operand2);
            if (flag == false)

            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }

            answer = Operand1 / Operand1;
            answer = Operand1 / Operand2;
            txtResult.Text = Operand1.ToString() + "divided by" + Operand2.ToString() + "equals" + answer.ToString();
            txtResult.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

