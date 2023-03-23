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
    public partial class All_race : Form
    {
        public All_race()
        {
            InitializeComponent();
            ClearInput();
        }
        private void ClearInput() 
        {
            textBox_Kapitan.Text = string.Empty;
            status_race.Text = string.Empty;
            textBox_Ostanovka.Text = string.Empty;
            textBox_Passengers.Text = string.Empty;
            textBox_Pilot1.Text = string.Empty;
            textBox_Pilot2.Text = string.Empty;
            textBox_Plane.Text = string.Empty;
            textBox_Punct.Text = string.Empty;
            textBox_Range.Text = string.Empty;
            textBox_Stuardesa.Text = string.Empty;
            textBox_Weight.Text = string.Empty;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void All_race_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Add_obj_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                string status = "В ожидании";
                Flight flight = new Flight(textBox_Punct.Text, textBox_Ostanovka.Text, Convert.ToDouble(textBox_Range.Text), Convert.ToUInt32(textBox_Weight.Text), Convert.ToUInt32(textBox_Passengers.Text), textBox_Plane.Text, textBox_Pilot1.Text, textBox_Pilot2.Text, textBox_Kapitan.Text, textBox_Stuardesa.Text, id, status);
                Add(flight);
                ClearInput();
            }
            catch (Exception)
            {
                MessageBox.Show("Упс! Неверный ввод данных");
                ClearInput();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1) 
            {
                Flight flight = (Flight)listView1.SelectedItems[0].Tag;
               
                if(flight != null ) 
                {
                    status_race.Text = flight.Status;
                    textBox_Ostanovka.Text = flight.Stop_point;
                    textBox_Passengers.Text = Convert.ToString(flight.Passengers);
                    textBox_Plane.Text = flight.Name_plane;
                    textBox_Punct.Text = flight.Destination_Point;
                    textBox_Range.Text = Convert.ToString(flight.Flight_range);
                    textBox_Weight.Text = Convert.ToString(flight.Weight);
                    textBox_Kapitan.Text = flight.kapitan ;
                    textBox_Pilot1.Text = flight.pilot1;
                    textBox_Pilot2.Text = flight.pilot2;
                    textBox_Stuardesa.Text = flight.stuardesa;
                }
            }
            else if (listView1.SelectedItems.Count == 0) 
            {
                ClearInput();
            }
        }

        private void Seriliazation_Click(object sender, EventArgs e)
        {

            Flights flights = new Flights();
            foreach(ListViewItem item in listView1.Items)
            {
                if (item.Tag != null) 
                {
                    flights.Flights_List.Add((Flight)item.Tag);
                }
            }
            XmlSerialize(flights);
            listView1.Items.Clear();
        }
        private void XmlSerialize(Flights flights) 
        {
            XmlSerializer xml = new XmlSerializer(typeof(Flights));
            using(FileStream fs = new FileStream("Flights.xml", FileMode.OpenOrCreate)) 
            {
                xml.Serialize(fs, flights);
            }
        }
        private Flights XmlDeseriaLze() 
        {
            XmlSerializer xml = new XmlSerializer(typeof(Flights));
            using (FileStream fs = new FileStream("Flights.xml", FileMode.OpenOrCreate))
            {
                Flights flights = (Flights)xml.Deserialize(fs);
                return flights;
            }
        }

        private void Open_File_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ClearInput();
            Flights flights = XmlDeseriaLze();
            foreach(Flight flight in flights.Flights_List) 
            {
                Add(flight);
            }
        }
        private void Add(Flight flight) 
        {
            ListViewItem LVI = new ListViewItem(Convert.ToString(flight.ID));
            LVI.Tag = flight;
            listView1.Items.Add(LVI);
        }
    }
}
