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
    public partial class CAT20_TRACKSTATUS : Form
    {
        public CAT20_TRACKSTATUS(CAT20 cat20)
        {
            InitializeComponent();
            this.cat20 = cat20;
        }
        CAT20 cat20;
        private void CAT20_TRACKSTATUS_Load(object sender, EventArgs e)
        {
            Tuple<string, string, string, string, string, string, string> tuple = cat20.getTrackstatus();
            label_CNF.Text = "CNF: " + tuple.Item1;
            label_TRE.Text = "TRE: " + tuple.Item2;
            label_CST.Text = "CST: " + tuple.Item3;
            label_CDM.Text = "CDM: " + tuple.Item4;
            label_MAH.Text = "MAH: " + tuple.Item5;
            label_STH.Text = "STH: " + tuple.Item6;
            label_GHO.Text = "GHO: " + tuple.Item7;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
