using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace аэропрт
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
            ClearInput();
            try
            {
                Flights flights = XmlDeseriaLze();
                foreach (Flight flight in flights.Flights_List)
                {
                    Add(flight);
                }
            }
            catch 
            {
                MessageBox.Show("В базе данных нету рейсов :(\nВнесите рейс");
            }
        }

        private void list_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_status.SelectedItems.Count == 1)
            {
                Flight flight = (Flight)list_status.SelectedItems[0].Tag;

                if (flight != null)
                {
                   textBox1.Text = flight.Status;
                }
            }
            else if (list_status.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }
        private void ClearInput()
        {
            textBox1.Text = string.Empty;
        }
        private Flights XmlDeseriaLze()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Flights));
            using (FileStream fs = new FileStream("Flights.xml", FileMode.Open))
            {
                Flights flights = (Flights)xml.Deserialize(fs);
                return flights;
            }
        }
        private void Add(Flight flight)
        {
            ListViewItem LVI = new ListViewItem(Convert.ToString(flight.ID));
            LVI.Tag = flight;
            list_status.Items.Add(LVI);
        }

        private void loading_Click(object sender, EventArgs e)
        {
            string name = "В ожидании";
            Method(name);
            
        }

        private void Air_Click(object sender, EventArgs e)
        {
            string name = "В воздухе";
            Method(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Закончен";
            Method(name);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            string name = "отмена";
            Method(name);

        }
        private void Method(string name) 
        {
            int count = 0;
            do
                if (list_status.SelectedItems.Count == 1)
                {
                    Flight flight = (Flight)list_status.SelectedItems[0].Tag;

                    if (flight != null)
                    {
                        textBox1.Text = flight.Status;
                    }

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(@"C:\Users\KIRILL\source\repos\аэропрт\аэропрт\bin\Debug\net5.0-windows\Flights.xml");
                    XmlElement xRoot = xDoc.DocumentElement;
                    XmlNode child = xRoot.SelectSingleNode($"descendant::Flight[ID={Convert.ToString(flight.ID)}]");
                    child.Attributes["Status"].Value = name;
                    count++;
                    xDoc.Save(@"C:\Users\KIRILL\source\repos\аэропрт\аэропрт\bin\Debug\net5.0-windows\Flights.xml");
                } while (count == 1);
        }
    }
}
