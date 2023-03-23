using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace аэропрт
{
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
            
        }

        private void Search_race_Click(object sender, EventArgs e)
        { 
            Search_race.Visible = false;
            textBox1.Visible = true;
            Write_sentence.Visible = true;
            Poisk.Visible = true;
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            Write_sentence.Visible = false;
        }

        private void Poisk_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            Regex regex = new Regex(@"[1-9]{5}");
            if (regex.IsMatch(id))
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"C:\Users\KIRILL\source\repos\аэропрт\аэропрт\bin\Debug\net5.0-windows\Flights.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                XmlNode child = xRoot.SelectSingleNode($"descendant::Flight[ID={id}]");
                errorProvider1.Clear();
                if (child != null)
                {
                    MessageBox.Show($"{child.OuterXml}");
                }
                else 
                {
                    errorProvider1.SetError(textBox1, "Такго рейса нету");
                }
            }
            else 
            {
                errorProvider1.SetError(textBox1, "Неверный формат");

            }
            
        }
    }
}
