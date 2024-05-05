using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroatmm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "6";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "6";
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "7";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "7";
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cuenta.Clear();
            nip.Clear();
        }
        
        private void cuenta_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "1";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "1";
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "2";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "2";
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "3";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "3";
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "4";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "4";
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "5";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "5";
                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "8";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "8";
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "9";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "9";
                }

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "0";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "0";
                }

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (cuenta.Text == "12345")
            {
                if (nip.Text == "1234")
                {
                    MessageBox.Show("Datos correctos");
                }
                else
                {
                    MessageBox.Show("NIP incorrecto");
                }
            }
            else MessageBox.Show("cuenta incorrecta");
        }
    }
}
