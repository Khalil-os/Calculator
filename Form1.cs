using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string Evaluate(string expression)
        {
            DataTable table = new DataTable();
            return (table.Compute(expression, string.Empty)).ToString();
        }

        static string RemoveLastCharacter(string input)
        {
            if (input.Length > 0)
            {
                return input.Substring(0, input.Length - 1);
            }
            return input;  // Ila kan string khawi
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt1.Tag;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt2.Tag;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt3.Tag;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt4.Tag;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt5.Tag;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt6.Tag;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt7.Tag;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt8.Tag;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt9.Tag;
        }

        private void btAddition_Click(object sender, EventArgs e)
        {
            tbOperation.Text += btAddition.Tag;
        }

        private void btSubtraction_Click(object sender, EventArgs e)
        {
            tbOperation.Text += btSubtraction.Tag;
        }

        private void btMultiplication_Click(object sender, EventArgs e)
        {
            tbOperation.Text += btMultiplication.Tag;
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            tbOperation.Text += btDivision.Tag;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbOperation.Text += bt0.Tag;
        }

        private void btFLexEn_Click(object sender, EventArgs e)
        {
            tbOperation.Text += btFLexEn.Tag;
        }

        private void btFlexFr_Click(object sender, EventArgs e)
        {
            tbOperation.Text += btFlexFr.Tag;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbOperation.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbOperation.Text = RemoveLastCharacter(tbOperation.Text);
        }

        private void btAnswer_Click(object sender, EventArgs e)
        {
            tbOperation.Text = Evaluate(tbOperation.Text);
        }
    }
}
