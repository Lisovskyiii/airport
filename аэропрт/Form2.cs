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
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            All_race frm_race= new All_race();
            frm_race.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Disp_punkt_Click(object sender, EventArgs e)
        {
            Disp_punct_of frm_punct = new Disp_punct_of();
            frm_punct.Show();
        }

        private void Status_race_Click(object sender, EventArgs e)
        {
            Status frm_status = new Status();
            frm_status.Show();
        }
    }
}
