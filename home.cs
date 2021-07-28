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
    public partial class home : UserControl
    {
        public home()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              

            //MessageBox.Show("s");
            customer c =  new customer();
            Dictionary<string, customer> cust=new Dictionary<string, customer>();
            //MessageBox.Show("s");
            if (File.Exists("customer.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("customer.xml");
                XmlNodeList list = doc.GetElementsByTagName("customer");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList ch_list = list[i].ChildNodes;
                    c.name = ch_list[0].InnerText;
                    c.phone = ch_list[1].InnerText;
                    c.address = ch_list[2].InnerText;
                    cust[ch_list[1].InnerText]=c;
                    c = new customer();
                    //MessageBox.Show(cust[ch_list[1].InnerText].name);
                }
            }


            if (cust.ContainsKey(textBox1.Text))
            {

                //c.name = cust[textBox1.Text].name;

                //second_menue sc = new second_menue();
                //sc.second_menue_Load(cust[textBox1.Text].name);

               // MessageBox.Show(cust[textBox1.Text].name);
                if (!Form1.inst.pnl.Controls.ContainsKey("second_menue"))
                {   
                    second_menue sc = new second_menue(cust[textBox1.Text].name);
                    sc.Dock = DockStyle.Fill;
                    Form1.inst.pnl.Controls.Add(sc);
                }
                Form1.inst.pnl.Controls["second_menue"].BringToFront();
                Form1.inst.back_button.Visible = true;

                bool ch = true;
                Form1 fh = new Form1(ch);
                

            }
            else
            {
                //

                //
                MessageBox.Show("user not exist please try again");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
