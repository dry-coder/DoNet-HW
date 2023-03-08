using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int leftNum, rightNum, result;
        string op;

        private void Num2_TextChanged(object sender, EventArgs e)
        {
            rightNum = Convert.ToInt32(Num2.Text);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    result = leftNum + rightNum;
                    break;
                case "-":
                    result = leftNum - rightNum;
                    break;
                case "*":
                    result = leftNum * rightNum;
                    break;
                case "/":
                    result = leftNum / rightNum;
                    break;
                default:
                    result = 0;
                    break;
            }
            Result.Text = result.ToString();

        }

        private void Operator_TextChanged(object sender, EventArgs e)
        {
            op = Operator.Text;
        }


        private void Num1_TextChanged(object sender, EventArgs e)
        {
            leftNum = Convert.ToInt32(Num1.Text);
        }
    }
}
