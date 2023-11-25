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

        // Minimize and close buttons
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Number Buttons
        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "";
            }

            string issue = label2.Text;

            issue = issue + "1";

            label2.Text = issue;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "";
            }

            string issue = label2.Text;

            issue = issue + "2";

            label2.Text = issue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "";
            }

            string issue = label2.Text;

            issue = issue + "3";

            label2.Text = issue;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string issue = label2.Text;

            issue = issue + "4";

            label2.Text = issue;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string issue = label2.Text;

            issue = issue + "5";

            label2.Text = issue;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string issue = label2.Text;

            issue = issue + "6";

            label2.Text = issue;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string issue = label2.Text;

            issue = issue + "7";

            label2.Text = issue;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }
            string issue = label2.Text;

            issue = issue + "8";

            label2.Text = issue;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (label2.Text == "0")
            {
                label2.Text = "";
            }

            string issue = label2.Text;

            issue = issue + "9";

            label2.Text = issue;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            string issue = label2.Text;

            issue = issue + "0";

            label2.Text = issue;
        }

        // Operation Buttons
        private void button13_Click(object sender, EventArgs e)
        {
            
            int firstissue=0;

 
            label4.Text = "+";


            firstissue = Convert.ToInt32(label2.Text);
            label3.Text = Convert.ToString(firstissue);
            label2.Text = "0";
            
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int firstissue = 0;


            label4.Text = "/";


            firstissue = Convert.ToInt32(label2.Text);
            label3.Text = Convert.ToString(firstissue);
            label2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int firstissue = 0;


            label4.Text = "-";


            firstissue = Convert.ToInt32(label2.Text);
            label3.Text = Convert.ToString(firstissue);
            label2.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int firstissue = 0;


            label4.Text = "*";


            firstissue = Convert.ToInt32(label2.Text);
            label3.Text = Convert.ToString(firstissue);
            label2.Text = "";
        }
        
        // Clear button
        private void button18_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label2.Text = "0";
        }

        // Equal button
        private void button17_Click(object sender, EventArgs e)
        {
            int secondissue = Convert.ToInt32(label2.Text);
            int firstissue = Convert.ToInt32(label3.Text);
            
            if (label4.Text == "+")
            {
                label2.Text = Convert.ToString(firstissue+secondissue);
            }

            else if (label4.Text == "-")
            {
                label2.Text = Convert.ToString(firstissue-secondissue);
            }

            else if (label4.Text == "*")
            {
                label2.Text = Convert.ToString(firstissue*secondissue);
            }

            else if (label4.Text == "/")
            {
                label2.Text = Convert.ToString(firstissue/secondissue);
            }
            

        }
    }
}
