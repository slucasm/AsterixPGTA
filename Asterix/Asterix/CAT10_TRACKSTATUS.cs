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
    public partial class CAT10_TRACKSTATUS : Form
    {
        public CAT10_TRACKSTATUS(CAT10 cat10)
        {
            InitializeComponent();
            this.cat10 = cat10;
        }
        CAT10 cat10;
        private void CAT10_TRACKSTATUS_Load(object sender, EventArgs e)
        {
            Tuple<string, string, string, string, string, string, string> tuple1 = cat10.getTrackstatus1();
            Tuple<string, string, string> tuple2 = cat10.getTrackstatus2();
            label_CNF.Text = "CNF: " + tuple1.Item1;
            label_TRE.Text = "TRE: " + tuple1.Item2;
            label_CST.Text = "CST: " + tuple1.Item3;
            label_MAH.Text = "MAH: " + tuple1.Item4;
            label_TCC.Text = "TCC: " + tuple1.Item5;
            label_STH.Text = "STH: " + tuple1.Item6;
            label_TOM.Text = "TOM: " + tuple1.Item7;
            label_DOU.Text = "DOU: " + tuple2.Item1;
            label_MRS.Text = "MRS: " + tuple2.Item2;
            label_GHO.Text = "GHO: " + tuple2.Item3;


        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
