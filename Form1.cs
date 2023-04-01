using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        char calculates;
        bool screenclear;
        double firstnumber;
        double secondnumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
               txtShow.Text = "";
               screenclear = false;
               
            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (screenclear)
            {
                txtShow.Text = "";
                screenclear = false;

            }
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calculates = '+';
            screenclear = true;
            firstnumber = double.Parse(txtShow.Text);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculates = '-';
            screenclear = true;
            firstnumber = double.Parse(txtShow.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculates = 'x';
            screenclear = true;
            firstnumber = double.Parse(txtShow.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculates = '÷';
            screenclear = true;
            firstnumber = double.Parse(txtShow.Text);
        }
        
        
        private void button15_Click(object sender, EventArgs e)
        {
            double sonuç = 0;
            secondnumber = double.Parse(txtShow.Text);
            switch (calculates)
            {
                case '+':
                    sonuç = firstnumber + secondnumber;
                    break;
                case '-':
                    sonuç = firstnumber - secondnumber;
                    break;
                case 'x':
                    sonuç = secondnumber * firstnumber;
                    break;
                case '÷':
                    sonuç = firstnumber / secondnumber;
                    break;
            }
            txtShow.Text = sonuç.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Length >1)
            {
                txtShow.Text = txtShow.Text.Substring(0,txtShow.Text.Length -1); 
            }

            else
            {
                txtShow.Text = "0";

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.IndexOf(',')<1)
            {
                txtShow.Text += ",";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Çıkmak_İstiyormusun;
            Çıkmak_İstiyormusun = MessageBox.Show("Are you want to the application exit ?","Exit", MessageBoxButtons.YesNo , MessageBoxIcon.Question );
            
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 632;
            txtShow.Width = 588;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 313;
            txtShow.Width = 280;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 313;
            txtShow.Width = 280;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double negativenumber = double.Parse(txtShow.Text);
            txtShow.Text = Convert.ToString(-1*negativenumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            txtShow.Text = pi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double E = Math.E;
            txtShow.Text = E.ToString();
        }

        private void btnKarekök_Click(object sender, EventArgs e)
        {
            double SquareRoot = double.Parse(txtShow.Text);
            SquareRoot = Math.Sqrt(SquareRoot);
            txtShow.Text = SquareRoot.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double Sinüs = double.Parse(txtShow.Text);
            Sinüs = Math.Sin(Sinüs);
            txtShow.Text = Sinüs.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double Cosinüs = double.Parse(txtShow.Text);
            Cosinüs = Math.Cos(Cosinüs);
            txtShow.Text = Cosinüs.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double AbsoluteNumber = double.Parse(txtShow.Text);
            AbsoluteNumber = Math.Abs(AbsoluteNumber);
            txtShow.Text = AbsoluteNumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Tanjant = double.Parse(txtShow.Text);
            Tanjant = Math.Tan(Tanjant);
            txtShow.Text = Tanjant.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double Factoriel = double.Parse(txtShow.Text);
            double Fac = 1;
            for (int i = 1; i <= Factoriel; i++)
            {
                Fac *= i;
            }
            txtShow.Text = Fac.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double Cotanjant = double.Parse(txtShow.Text);
            Cotanjant = Math.Cosh(Cotanjant);
            txtShow.Text = Cotanjant.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double percentage = double.Parse(txtShow.Text);
            percentage = percentage / 100;
            txtShow.Text = percentage.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double Square = double.Parse(txtShow.Text);
            Square = Square * Square;
            txtShow.Text = Square.ToString();

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            double Cube = double.Parse(txtShow.Text);
            Cube = (Cube*Cube*Cube);
            txtShow.Text = Cube.ToString();
        }
    }
}
