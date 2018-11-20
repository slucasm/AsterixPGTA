using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibreriaClases;

namespace Asterix
{
    public partial class CAT21_LINK : Form
    {
        public CAT21_LINK(CAT21 cat21)
        {
            InitializeComponent();
            this.cat21 = cat21;
        }
        CAT21 cat21;

        private void CAT21_LINK_Load(object sender, EventArgs e)
        {
            Tuple<string, string, string, string, string> tuple = cat21.getLINK();
            label_DTI.Text = "DTI: " + tuple.Item1;
            label_MDS.Text = "MDS: " + tuple.Item2;
            label_UAT.Text = "UAT: " + tuple.Item3;
            label_VDL.Text = "VDL: " + tuple.Item4;
            label_OTR.Text = "OTR: " + tuple.Item5;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
