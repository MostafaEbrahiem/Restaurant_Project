using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resturant_project_final
{
    public partial class second_menue : UserControl
    {
        string name;
        public second_menue()
        {        
            InitializeComponent();
        }
        public second_menue(string x)
        {
            InitializeComponent();
            name = x;
        }



        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {

           // label2.Text = name;


        }

        private void second_menue_Load(object sender, EventArgs e)
        {

        }

        private void second_menue_Load_1(object sender, EventArgs e)
        {
            label2.Text = name;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Form1.inst.pnl.Controls.ContainsKey("menue"))
            {
                menue men = new menue();
                men.Dock = DockStyle.Fill;
                Form1.inst.pnl.Controls.Add(men);
            }
            Form1.inst.pnl.Controls["menue"].BringToFront();
        }
    }
}
