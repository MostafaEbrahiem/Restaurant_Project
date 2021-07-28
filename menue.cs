using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace resturant_project_final
{
   
    public partial class menue : UserControl
    { 
        //public int []dish=new int[12] ;
        // public string[] dish_names = new string[12];
        public string best_dish="";
        
        public menue()
        {
            InitializeComponent();
        }
        public menue( string x)
        {

            
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label32.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label32.Text);
                num++;
                label32.Text = num.ToString();
            }
        }

        public  void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label1.Text);
                num++;
                label1.Text = num.ToString();   
            }
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label28.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label28.Text);
                num++;
                label28.Text = num.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label29.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label29.Text);
                num++;
                label29.Text = num.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label31.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label31.Text);
                num++;
                label31.Text = num.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label30.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label30.Text);
                num++;
                label30.Text = num.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label6.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label6.Text);
                num++;
                label6.Text = num.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label9.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label9.Text);
                num++;
                label9.Text = num.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label12.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label12.Text);
                num++;
                label12.Text = num.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text=="0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label1.Text);
                num--;
                label1.Text = num.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label28.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label28.Text);
                num--;
                label28.Text = num.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label29.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label29.Text);
                num--;
                label29.Text = num.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label32.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label32.Text);
                num--;
                label32.Text = num.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label31.Text == "0")
            {
                
            }
            else
            {
                int num;
                num = Convert.ToInt32(label31.Text);
                num--;
                label31.Text = num.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void circular_button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label18.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label18.Text);
                num++;
                label18.Text = num.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label27.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label27.Text);
                num++;
                label27.Text = num.ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (label35.Text == "9")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label35.Text);
                num++;
                label35.Text = num.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label18.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label18.Text);
                num--;
                label18.Text = num.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label30.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label30.Text);
                num--;
                label30.Text = num.ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (label27.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label27.Text);
                num--;
                label27.Text = num.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label6.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label6.Text);
                num--;
                label6.Text = num.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label9.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label9.Text);
                num--;
                label9.Text = num.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label12.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label12.Text);
                num--;
                label12.Text = num.ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (label35.Text == "0")
            {

            }
            else
            {
                int num;
                num = Convert.ToInt32(label35.Text);
                num--;
                label35.Text = num.ToString();
            }
        }

        private void menue_Load(object sender, EventArgs e)
        {

        }

        private void circular_button2_Click(object sender, EventArgs e)
        {

            if (!Form1.inst.pnl.Controls.ContainsKey("recommand"))
            {
                recommand sc = new recommand();
                sc.Dock = DockStyle.Fill;
                Form1.inst.pnl.Controls.Add(sc);
            }
            Form1.inst.pnl.Controls["recommand"].BringToFront();

        }
    }
}
