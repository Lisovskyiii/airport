using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace аэропрт
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Admin_form newfrm = new Admin_form();
            newfrm.Show();
        }

        private void User_Click(object sender, EventArgs e)
        {
            User_Form newfrm2 = new User_Form();
            newfrm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
