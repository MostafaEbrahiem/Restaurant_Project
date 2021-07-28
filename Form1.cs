using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace resturant_project_final
{
    public partial class Form1 : Form
    {
        payment pay = new payment();
        public static menue men = new menue();
        public static bool check = false;
        public static string l1;
        static  menue m1;
        static Form1 obj;
        public static Form1 inst
        {
            get
            {
                if(obj==null)
                {
                    obj = new Form1();
                }
                return obj;
            }
        }
        public Panel pnl
        {
            get{ return panel5; }
            set { panel5 = value; }
        }

        public Button back_button
        {
            get { return button11; }
            set { button11 = value; }


        }
        public Form1()
        {
            InitializeComponent();
            // home1.BringToFront();
            
            //customer cust = new customer() ;
            
            
        }

        public Form1( bool c)
        {
            
            check = c;
            
          //  MessageBox.Show("sss");
            
        }
        public Form1(menue m)
        {
            m1 = m;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
           
                if (!Form1.inst.pnl.Controls.ContainsKey("second_menue"))
                {
                    second_menue sc = new second_menue();
                    sc.Dock = DockStyle.Fill;
                    Form1.inst.pnl.Controls.Add(sc);
                }
                Form1.inst.pnl.Controls["second_menue"].BringToFront();
               
            
        }
        
        

        private void button6_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //button11.Visible = false;     
            obj = this;
            second_menue s = new second_menue();
            s.Dock = DockStyle.Fill;
            panel5.Controls.Add(s);  

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
  
                if (!Form1.inst.pnl.Controls.ContainsKey("menue"))
                {
                    
                   
                    men.Dock = DockStyle.Fill;
                    Form1.inst.pnl.Controls.Add(men);
                    Form1 d = new Form1(men);
                }
                Form1.inst.pnl.Controls["menue"].BringToFront();
            //   menue1.BringToFront();
            //////////////////////////////////////////////////create best_dish file
            if (!File.Exists("best_dish.xml"))
            {

                XmlWriter xm = XmlWriter.Create("best_dish.xml");
                xm.WriteStartDocument();
                xm.WriteStartElement("Table");
                xm.WriteStartAttribute("Name", "best_dish");

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Crap_Soup");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Octopus");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Fish_Soup");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Fine_Fish");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Shrimp");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Shrimp_soup");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Sea_Pasta");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Lamp_Fish");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Crab_legs");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Crab");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Sea_shells");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("name");
                xm.WriteString("Fish");
                xm.WriteEndElement();
                xm.WriteStartElement("num_of_order");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteEndElement();


                xm.WriteEndElement();
                xm.WriteEndDocument();
                xm.Close();
                /////////////////////////////////////////////////////////////////


            }
            ///////////////////////////////////////menue file
            if (!File.Exists("menue.xml"))
            {
                XmlWriter xm = XmlWriter.Create("menue.xml");
                xm.WriteStartDocument();
                xm.WriteStartElement("Table");
                xm.WriteStartAttribute("Name", "menue");


                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("0");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("16");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("1");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("22");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("2");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("8");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("3");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("25");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("4");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("12");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("5");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("6");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("6");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("10");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("7");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("17");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("8");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("14");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("9");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("20");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("10");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("15");
                xm.WriteEndElement();
                xm.WriteEndElement();

                xm.WriteStartElement("dish");
                xm.WriteStartElement("Id");
                xm.WriteString("11");
                xm.WriteEndElement();
                xm.WriteStartElement("price");
                xm.WriteString("10");
                xm.WriteEndElement();
                xm.WriteEndElement();


                xm.WriteEndElement();
                xm.WriteEndDocument();
                xm.Close();

            }


        }


        


        public void button11_Click(object sender, EventArgs e)
        {
            
            if (!Form1.inst.pnl.Controls.ContainsKey("delivery"))
            {
                delivery d = new delivery();
                d.count = 0;
                d.Dock = DockStyle.Fill;
                Form1.inst.pnl.Controls.Add(d);
                d.chart1.Hide();
            }
            Form1.inst.pnl.Controls["delivery"].BringToFront();
                 

        }

        private void button4_Click(object sender, EventArgs e)
        {
               
            
                if(!Form1.inst.pnl.Controls.ContainsKey("call"))
                {
                    call sc = new call();
                    sc.Dock = DockStyle.Fill;
                    Form1.inst.pnl.Controls.Add(sc);
                }
                Form1.inst.pnl.Controls["call"].BringToFront();
                // call1.BringToFront();
           

        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            pay.count = 0;
            pay.textBox1.Text = "";
            pay.textBox2.Text = "";
            pay.comboBox1.Text = "";

                if (Convert.ToInt32(men.label1.Text) > 0|| Convert.ToInt32(men.label28.Text)>0|| Convert.ToInt32(men.label29.Text) > 0|| Convert.ToInt32(men.label18.Text) > 0 || Convert.ToInt32(men.label32.Text) > 0 || Convert.ToInt32(men.label31.Text) > 0 || Convert.ToInt32(men.label30.Text) > 0 || Convert.ToInt32(men.label27.Text) > 0 || Convert.ToInt32(men.label28.Text) > 0 || Convert.ToInt32(men.label6.Text) > 0 || Convert.ToInt32(men.label9.Text) > 0 || Convert.ToInt32(men.label12.Text) > 0 || Convert.ToInt32(men.label35.Text) > 0 )
                {
                    /////////////////////////////////////////////////
                    if (!Form1.inst.pnl.Controls.ContainsKey("payment"))
                    {

                        pay.Dock = DockStyle.Fill;
                        Form1.inst.pnl.Controls.Add(pay);
                    }
                    Form1.inst.pnl.Controls["payment"].BringToFront();
                    /////////////////////////////////////////////////
                    pay.label2.Text = "";
                    pay.label3.Text = "0";
                    if (Convert.ToInt32(men.label1.Text) > 0)
                    {
                        pay.label2.Text += men.label1.Text+ men.label2.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label3.Text)* Convert.ToInt32(men.label1.Text))).ToString();

                    }
                    if (Convert.ToInt32(men.label28.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label28.Text + men.label5.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label4.Text)*Convert.ToInt32(men.label28.Text))).ToString();
                    }
                    if (Convert.ToInt32(men.label29.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label29.Text + men.label8.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label7.Text) * Convert.ToInt32(men.label29.Text)) ).ToString();
                    }
                    if (Convert.ToInt32(men.label18.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label18.Text + men.label21.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) +(Convert.ToInt32(men.label15.Text) * Convert.ToInt32(men.label18.Text))).ToString();
                    }
                    if (Convert.ToInt32(men.label32.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label32.Text + men.label11.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) +(Convert.ToInt32(men.label10.Text) * Convert.ToInt32(men.label32.Text))).ToString();
                    }
                    if (Convert.ToInt32(men.label31.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label31.Text + men.label14.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label13.Text) * Convert.ToInt32(men.label31.Text))).ToString();
                    }
                    if (Convert.ToInt32(men.label30.Text) > 0)
                    {
                    pay.label2.Text += "\n " + men.label30.Text + "Octopus"; //men.label7.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label16.Text) * Convert.ToInt32(men.label30.Text))).ToString();
                    }
                    if (Convert.ToInt32(men.label27.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label27.Text + men.label33.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label24.Text) * Convert.ToInt32(men.label27.Text))).ToString();
                    }

                    if (Convert.ToInt32(men.label6.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label6.Text + men.label20.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label19.Text) * Convert.ToInt32(men.label6.Text))).ToString();
                    }
                    if (Convert.ToInt32(men.label9.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label9.Text + men.label23.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label22.Text) * Convert.ToInt32(men.label9.Text))).ToString();
                    }

                    if (Convert.ToInt32(men.label12.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label12.Text + men.label26.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) +( Convert.ToInt32(men.label25.Text) * Convert.ToInt32(men.label12.Text))).ToString();
                    }
                    if (Convert.ToInt32(men.label35.Text) > 0)
                    {
                        pay.label2.Text += "\n " + men.label35.Text + men.label36.Text;
                        pay.label3.Text = (Convert.ToInt32(pay.label3.Text) + (Convert.ToInt32(men.label34.Text) * Convert.ToInt32(men.label35.Text))).ToString();
                    }

                }
                   else
                {
                    pay.label2.Text = "";
                    MessageBox.Show("please Order somthing First");

                }









            pay.h = pay.label3.Text;
            ////////////////////////////////////////////////////////////////////
            pay.dish[0] = Convert.ToInt32(men.label27.Text);

            pay.dish[1] = Convert.ToInt32(men.label30.Text);

            pay.dish[2] = Convert.ToInt32(men.label18.Text);

            pay.dish[3] = Convert.ToInt32(men.label35.Text);

            pay.dish[4] = Convert.ToInt32(men.label1.Text);

            pay.dish[5] = Convert.ToInt32(men.label6.Text);

            pay.dish[6] = Convert.ToInt32(men.label12.Text);

            pay.dish[7] = Convert.ToInt32(men.label9.Text);

            pay.dish[8] = Convert.ToInt32(men.label31.Text);

            pay.dish[9] = Convert.ToInt32(men.label32.Text);

            pay.dish[10] = Convert.ToInt32(men.label28.Text);

            pay.dish[11] = Convert.ToInt32(men.label29.Text);
           
            ///////////////////////////////////////////////////////////////////

        }

        
    }
}
