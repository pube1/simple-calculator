using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            


        }

        // Kapatma ve küçültme tuşları
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Rakam tuşları
        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "";
            }

            string sayi = label2.Text;

            sayi = sayi + "1";

            label2.Text = sayi;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "";
            }

            string sayi = label2.Text;

            sayi = sayi + "2";

            label2.Text = sayi;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "";
            }

            string sayi = label2.Text;

            sayi = sayi + "3";

            label2.Text = sayi;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string sayi = label2.Text;

            sayi = sayi + "4";

            label2.Text = sayi;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string sayi = label2.Text;

            sayi = sayi + "5";

            label2.Text = sayi;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string sayi = label2.Text;

            sayi = sayi + "6";

            label2.Text = sayi;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string sayi = label2.Text;

            sayi = sayi + "7";

            label2.Text = sayi;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string sayi = label2.Text;

            sayi = sayi + "8";

            label2.Text = sayi;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }

            string sayi = label2.Text;

            sayi = sayi + "9";

            label2.Text = sayi;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            string sayi = label2.Text;

            sayi = sayi + "0";

            label2.Text = sayi;
        }

        // İşlem tuşları
        private void button13_Click(object sender, EventArgs e)
        {
            
            int ilksayi=0;

 
            label4.Text = "+";


            ilksayi = Convert.ToInt32(label2.Text);
            label3.Text = Convert.ToString(ilksayi);
            label2.Text = "0";
            
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ilksayi = 0;


            label4.Text = "/";


            ilksayi = Convert.ToInt32(label2.Text);
            label3.Text = Convert.ToString(ilksayi);
            label2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int ilksayi = 0;


            label4.Text = "-";


            ilksayi = Convert.ToInt32(label2.Text);
            label3.Text = Convert.ToString(ilksayi);
            label2.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int ilksayi = 0;


            label4.Text = "-";


            ilksayi = Convert.ToInt32(label2.Text);
            label3.Text = Convert.ToString(ilksayi);
            label2.Text = "";
        }
        
        // Temizleme tuşu
        private void button18_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label2.Text = "0";
        }

        // İşlem sonucu
        private void button17_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(label2.Text);
            int ilksayi = Convert.ToInt32(label3.Text);
            
            if (label4.Text == "+")
            {
                label2.Text = Convert.ToString(ilksayi+ikincisayi);
            }

            else if (label4.Text == "-")
            {
                label2.Text = Convert.ToString(ilksayi-ikincisayi);
            }

            else if (label4.Text == "*")
            {
                label2.Text = Convert.ToString(ilksayi*ikincisayi);
            }

            else if (label4.Text == "/")
            {
                label2.Text = Convert.ToString(ilksayi/ikincisayi);
            }
            

        }
    }
}
