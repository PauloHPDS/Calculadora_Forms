using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Forms
{
    public partial class Form1 : Form
    {
        decimal n1;
        decimal n2;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_Result.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_Result.Text += "8";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label_Result.Text +="0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label_Result.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label_Result.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label_Result.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label_Result.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_Result.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label_Result.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label_Result.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            n1=decimal.Parse(label_Result.Text, CultureInfo.InvariantCulture);
            op="Soma";
            label_Op.Text = "+"+label_Result.Text;
            label_Result.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            n1 = decimal.Parse(label_Result.Text, CultureInfo.InvariantCulture);
            op = "Sub";
            label_Op.Text = "-" + label_Result.Text;
            label_Result.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n2 = decimal.Parse(label_Result.Text, CultureInfo.InvariantCulture);
            switch (op)
            {
                case "Soma":
                    label_Op.Text = n2+label_Op.Text;
                    label_Result.Text=Convert.ToString(n1+n2);
                    break;
                case "Sub":
                    //Subtracao();
                    break;
                case "Multiplicacao":
                    //Mult();
                    break;
                case "Divisao":
                    //Divisao();
                    break;
                case "Poten":
                    //Potencia();
                    break;
                case "Raiz":
                    //Raiz();
                    break;
            }
        }
        
    }
}
