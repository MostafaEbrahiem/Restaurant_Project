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
    public partial class recommand : UserControl
    {
        int[] dish = new int[12];
        string[] dish_names = new string[12];
        public recommand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void recommand_Load(object sender, EventArgs e)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load("best_dish.xml");
            XmlNodeList list = doc.GetElementsByTagName("dish");
            for (int i = 0; i < list.Count; i++)
            {
                
                XmlNodeList ch_list = list[i].ChildNodes;
                dish_names[i] = ch_list[0].InnerText;
                dish[i] =Convert.ToInt32(ch_list[1].InnerText);
                if(dish[i]>10)
                {
                    MessageBox.Show("ss");
                    label1.Text += "\n" + dish_names[i];
                }
                
            }
            




           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1.inst.pnl.Controls["menue"].BringToFront();

        }
    }
}
