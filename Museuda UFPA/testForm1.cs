using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UFPA
{
    public partial class testForm1 : Form
    {
        public testForm1()
        {
            InitializeComponent();
            metroPanel2.Visible = true;
            metroPanel1.Visible = false;
        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {
            metroPanel2.Visible = false;

        }

        private void MetroLabel4_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            metroPanel2.Visible = true;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            
            metroPanel2.Visible = false;
            metroPanel1.Visible = true;
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            metroPanel2.Visible = true;
        }
    }
}
