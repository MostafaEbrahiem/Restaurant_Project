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
    public partial class payment : UserControl
    {
      public string h;
        public int[] dish = new int[12];
        public  int count=0;
        customer c = new customer();
        Dictionary<string, customer> cust = new Dictionary<string, customer>();
        menue m = new menue();
        public payment()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            if (textBox1.Text == ""|| textBox2.Text == ""||comboBox1.Text=="")
            {
                MessageBox.Show("Please enter your information");
            }
            else
            {
               
              
                if (File.Exists("customer.xml"))
                {
                    
                    doc.Load("customer.xml");
                    XmlNodeList list = doc.GetElementsByTagName("customer");
                    for (int i = 0; i < list.Count; i++)
                    {
                        XmlNodeList ch_list = list[i].ChildNodes;
                        c.name = ch_list[0].InnerText;
                        c.phone = ch_list[1].InnerText;
                        c.num_of_order = ch_list[2].InnerText;
                        c.Total_purchased_amount = ch_list[3].InnerText;
                        c.discount = ch_list[4].InnerText;
                        cust[ch_list[1].InnerText] = c;
                        c = new customer();
                        //MessageBox.Show(cust[ch_list[1].InnerText].name);
                    }
                }

                //////////////////////////////////////update_value
                if (cust.ContainsKey(textBox2.Text))
                {
                    
                    cust[textBox2.Text].name = textBox1.Text;
                    cust[textBox2.Text].Total_purchased_amount = (Convert.ToInt32(cust[textBox2.Text].Total_purchased_amount) + Convert.ToInt32(label3.Text)).ToString();                  
                    cust[textBox2.Text].num_of_order = (Convert.ToInt32(cust[textBox2.Text].num_of_order) + 1).ToString(); 
                    

                    
                    doc.Load("customer.xml");
                    XmlNodeList L = doc.GetElementsByTagName("customer");


                    for (int i=0;i<cust.Count;i++)
                    {
                        XmlNodeList ch_L = L[i].ChildNodes;
                        if(ch_L[1].InnerText==textBox2.Text)
                        {
                            ch_L[0].InnerText = textBox1.Text;
                            ch_L[2].InnerText = cust[textBox2.Text].num_of_order;
                            ch_L[3].InnerText = cust[textBox2.Text].Total_purchased_amount;
                            if(Convert.ToInt32(cust[textBox2.Text].Total_purchased_amount) > 1500)
                            {
                                ch_L[4].InnerText = ".15";
                            }
                            else if(Convert.ToInt32(cust[textBox2.Text].Total_purchased_amount) > 1000)
                            {
                                ch_L[4].InnerText = ".1";
                            }
                            else if(Convert.ToInt32(cust[textBox2.Text].Total_purchased_amount)>500)
                            {
                                ch_L[4].InnerText = ".05";
                            }
                            break;
                        }

                    }
                    doc.Save("customer.xml");
                }

                //////////////////////////////////////////////////
                else
                {
                    if (!File.Exists("customer.xml"))
                    {

                        XmlWriter xm = XmlWriter.Create("customer.xml");
                        xm.WriteStartDocument();
                        xm.WriteStartElement("Table");
                        xm.WriteStartAttribute("Name", "Customers");
                        xm.WriteStartElement("customer");

                        xm.WriteStartElement("name");
                        xm.WriteString(textBox1.Text);
                        xm.WriteEndElement();
                        xm.WriteStartElement("phone");
                        xm.WriteString(textBox2.Text);
                        xm.WriteEndElement();
                        xm.WriteStartElement("Number_of_last_order");
                        xm.WriteString("1");
                        xm.WriteEndElement();

                        xm.WriteStartElement("Total_purchased_amount");
                        xm.WriteString(label3.Text);
                        xm.WriteEndElement();

                        xm.WriteStartElement("discount");
                        xm.WriteString("0");
                        xm.WriteEndElement();

                        xm.WriteEndElement();
                        xm.WriteEndElement();
                        xm.WriteEndDocument();
                        xm.Close();
                    }

                    else
                    {
                        XmlDocument xm = new XmlDocument();
                        XmlElement customer = xm.CreateElement("customer");
                       


                        XmlElement node = xm.CreateElement("name");
                        node.InnerText = textBox1.Text;
                        customer.AppendChild(node);

                        
                        node = xm.CreateElement("phone");
                        node.InnerText = textBox2.Text;
                        customer.AppendChild(node);

                        

                        node = xm.CreateElement("Number_of_last_order");
                        node.InnerText = "1";
                        customer.AppendChild(node);

                       
                        node = xm.CreateElement("Total_purchased_amount");
                        node.InnerText = label3.Text;
                        customer.AppendChild(node);

                        node = xm.CreateElement("discount");
                        node.InnerText = "0";
                        customer.AppendChild(node);

                        xm.Load("customer.xml");
                        XmlElement root = xm.DocumentElement;
                        root.AppendChild(customer);
                        xm.Save("customer.xml");
                    }


                }







                    if (!Form1.inst.pnl.Controls.ContainsKey("customer_info"))
                {
                    second_menue s = new second_menue();
                    s.Dock = DockStyle.Fill;
                    Form1.inst.pnl.Controls.Add(s);
                }
                Form1.inst.pnl.Controls["second_menue"].BringToFront();
                //Form1.inst.back_button.Visible = true;

                /////////////////////////////////////delivery
                XmlDocument Db_doc = new XmlDocument();
                XmlNodeList del_boy_L = Db_doc.GetElementsByTagName("delivery_boy");
                Db_doc.Load("delivery_boy.xml");

                doc.Load("delivery.xml");
                XmlNodeList del_L = doc.GetElementsByTagName("delivery");

                for (int i = 0; i < del_L.Count; i++)
                {
                    XmlNodeList del_ch_L = del_L[i].ChildNodes;

                    if (del_ch_L[0].InnerText == comboBox1.Text)
                    {
                        del_ch_L[2].InnerText = (Convert.ToInt32(del_ch_L[2].InnerText) + 1).ToString();

                        for (int j = 0; j < del_boy_L.Count; j++)
                        {

                            XmlNodeList del_boy_ch_L = del_boy_L[j].ChildNodes;
                            if (del_ch_L[1].InnerText == del_boy_ch_L[2].InnerText)
                            {

                                del_boy_ch_L[3].InnerText = (Convert.ToInt32(del_boy_ch_L[3].InnerText) + 1).ToString();
                            }
                        }
                        break;
                    }

                }
                doc.Save("delivery.xml");
                Db_doc.Save("delivery_boy.xml");
                //////////////////////////////////////////best dish





               
                XmlDocument d = new XmlDocument();
                d.Load("best_dish.xml");
                XmlNodeList l = d.GetElementsByTagName("dish");
                for (int i = 0; i < l.Count; i++)
                {  
                    XmlNodeList ch_l = l[i].ChildNodes;
                    ch_l[1].InnerText = (Convert.ToInt32(ch_l[1].InnerText)+dish[i]).ToString();
                }
                d.Save("best_dish.xml");

                /////////////////////////////////////////////////////






                /////////////////////////////////////////////////////
                


                ////////////////////////////////////////////////////

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                count = 0;

               

                MessageBox.Show("Your Order has been succesfully placed");
            }

            


           
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
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
                    c.num_of_order = ch_list[2].InnerText;
                    c.Total_purchased_amount = ch_list[3].InnerText;
                    c.discount= ch_list[4].InnerText;
                    cust[ch_list[1].InnerText] = c;
                    c = new customer();
                    //MessageBox.Show(cust[ch_list[1].InnerText].name);
                }
            }
            label3.Text = h;
            label10.Text = "0";
            if (cust.ContainsKey(textBox2.Text))
            {
                count = 0;
                if (count == 0)
                {

                    if (Convert.ToInt32(cust[textBox2.Text].Total_purchased_amount) > 1500)
                    {
                        label3.Text = Convert.ToInt32((Convert.ToInt32(label3.Text) * (0.85))).ToString();
                        label10.Text = "15";
                        count++;

                    }

                    else if (Convert.ToInt32(cust[textBox2.Text].Total_purchased_amount) > 1000)
                    {
                        label3.Text = Convert.ToInt32((Convert.ToInt32(label3.Text) * (0.90))).ToString();
                        label10.Text = "10";
                        count++;
                    }

                    else if (Convert.ToInt32(cust[textBox2.Text].Total_purchased_amount) > 500)
                    {
                        label3.Text = Convert.ToInt32((Convert.ToInt32(label3.Text) * (0.95))).ToString();
                        label10.Text = "5";
                        count++;
                    }
                    
                }
            }

        }
    }
}
