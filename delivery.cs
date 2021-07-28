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
    public partial class delivery : UserControl
    {
        public int count;
        public delivery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            






            if (!File.Exists("delivery.xml"))
            {
                
                XmlWriter xm = XmlWriter.Create("delivery.xml");
                xm.WriteStartDocument();
                xm.WriteStartElement("Table");
                xm.WriteStartAttribute("Name", "delivery");


                xm.WriteStartElement("delivery");

                xm.WriteStartElement("Area");
                xm.WriteString("Ain_shams");
                xm.WriteEndElement();


                xm.WriteStartElement("Code");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery");

                xm.WriteStartElement("Area");
                xm.WriteString("El_Shrouq");
                xm.WriteEndElement();


                xm.WriteStartElement("Code");
                xm.WriteString("1");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery");

                xm.WriteStartElement("Area");
                xm.WriteString("El_Abaseya");
                xm.WriteEndElement();


                xm.WriteStartElement("Code");
                xm.WriteString("2");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery");

                xm.WriteStartElement("Area");
                xm.WriteString("Zaqazeq");
                xm.WriteEndElement();
                
                xm.WriteStartElement("Code");
                xm.WriteString("3");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery");

                xm.WriteStartElement("Area");
                xm.WriteString("Makram");
                xm.WriteEndElement();


                xm.WriteStartElement("Code");
                xm.WriteString("4");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery");

                xm.WriteStartElement("Area");
                xm.WriteString("El_Moqatam");
                xm.WriteEndElement();

                xm.WriteStartElement("Code");
                xm.WriteString("5");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                ///////////////////////////////////////////////////
                xm.WriteEndElement();
                xm.WriteEndDocument();





                xm.Close();
            }

            List<deliveries> delv = new List<deliveries>();
            deliveries D = new deliveries();
            if (File.Exists("delivery.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("delivery.xml");
                XmlNodeList list = doc.GetElementsByTagName("delivery");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList ch_list = list[i].ChildNodes;
                    D.Area = ch_list[0].InnerText;
                    D.code = ch_list[1].InnerText;
                    D.num_of_orders = ch_list[2].InnerText;  
                    delv.Add(D);
                    D = new deliveries();
                   
                }
            }


            
            if (count ==0)
            {
                count++;
                chart1.Show();
                //delv[0].num_of_orders = (Convert.ToInt32(delv[0].num_of_orders) + 1).ToString();
                chart1.Series["Num of Orders"].Points.AddXY("Ain shams", Convert.ToInt32(delv[0].num_of_orders));
                chart1.Series["Num of Orders"].Points.AddXY("El Shrouq", Convert.ToInt32(delv[1].num_of_orders));
                chart1.Series["Num of Orders"].Points.AddXY("El Abaseya", Convert.ToInt32(delv[2].num_of_orders));
                chart1.Series["Num of Orders"].Points.AddXY("Zaqazeq", Convert.ToInt32(delv[3].num_of_orders));
                chart1.Series["Num of Orders"].Points.AddXY("Makram", Convert.ToInt32(delv[4].num_of_orders));
                chart1.Series["Num of Orders"].Points.AddXY("El Moqatam", Convert.ToInt32(delv[5].num_of_orders));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string best_db=" ";
            if (!File.Exists("delivery_boy.xml"))
            {
                XmlWriter xm = XmlWriter.Create("delivery_boy.xml");
                xm.WriteStartDocument();
                xm.WriteStartElement("Table");
                xm.WriteStartAttribute("Name", "delivery_boy");


                xm.WriteStartElement("delivery_boy");

                xm.WriteStartElement("name");
                xm.WriteString("Ahmed");
                xm.WriteEndElement();

                xm.WriteStartElement("phone");
                xm.WriteString("01118302972");
                xm.WriteEndElement();

                xm.WriteStartElement("Area_Code");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery_boy");

                xm.WriteStartElement("name");
                xm.WriteString("Mohamed");
                xm.WriteEndElement();

                xm.WriteStartElement("phone");
                xm.WriteString("01034861690");
                xm.WriteEndElement();

                xm.WriteStartElement("Area_Code");
                xm.WriteString("1");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery_boy");

                xm.WriteStartElement("name");
                xm.WriteString("Hesham");
                xm.WriteEndElement();

                xm.WriteStartElement("phone");
                xm.WriteString("01116430682");
                xm.WriteEndElement();

                xm.WriteStartElement("Area_Code");
                xm.WriteString("2");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery_boy");

                xm.WriteStartElement("name");
                xm.WriteString("Samy");
                xm.WriteEndElement();

                xm.WriteStartElement("phone");
                xm.WriteString("01268563087");
                xm.WriteEndElement();

                xm.WriteStartElement("Area_Code");
                xm.WriteString("3");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery_boy");

                xm.WriteStartElement("name");
                xm.WriteString("Ayman");
                xm.WriteEndElement();

                xm.WriteStartElement("phone");
                xm.WriteString("01003449722");
                xm.WriteEndElement();

                xm.WriteStartElement("Area_Code");
                xm.WriteString("4");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                xm.WriteStartElement("delivery_boy");

                xm.WriteStartElement("name");
                xm.WriteString("Ehab");
                xm.WriteEndElement();

                xm.WriteStartElement("phone");
                xm.WriteString("01116305822");
                xm.WriteEndElement();

                xm.WriteStartElement("Area_Code");
                xm.WriteString("5");
                xm.WriteEndElement();

                xm.WriteStartElement("Number_of_orders");
                xm.WriteString("0");
                xm.WriteEndElement();

                xm.WriteEndElement();


                ///////////////////////////////////////////////////
                xm.WriteEndElement();
                xm.WriteEndDocument();
                




                xm.Close();
            }






            List<delivery_boy> delv_boy = new List<delivery_boy>();
            delivery_boy Db = new delivery_boy();
            if (File.Exists("delivery_boy.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("delivery_boy.xml");
                XmlNodeList list = doc.GetElementsByTagName("delivery_boy");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList ch_list = list[i].ChildNodes;
                    Db.name = ch_list[0].InnerText;
                    Db.phone = ch_list[1].InnerText;
                    Db.area_code = ch_list[2].InnerText;
                    Db.num_order = ch_list[3].InnerText;
                    delv_boy.Add(Db);
                    Db = new delivery_boy();
                    //MessageBox.Show(cust[ch_list[1].InnerText].name);
                }
            }
            int num = 0;
            for (int i = 0; i < delv_boy.Count; i++)
            {
                if (Convert.ToInt32(delv_boy[i].num_order)>num)
                {
                    num = Convert.ToInt32(delv_boy[i].num_order);
                    best_db = delv_boy[i].name;
                }
            }
            MessageBox.Show("best delivery boy is "+best_db);
        }
    }
}
