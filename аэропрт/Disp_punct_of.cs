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
using System.Xml.Serialization;

namespace аэропрт
{
    public partial class Disp_punct_of : Form
    {
        public Disp_punct_of()
        {
            InitializeComponent();
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
        private void Add(Flight flight)
        {
            ListViewItem LVI = new ListViewItem(Convert.ToString(flight.ID));
            LVI.Tag = flight;
            listView1.Items.Add(LVI);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
