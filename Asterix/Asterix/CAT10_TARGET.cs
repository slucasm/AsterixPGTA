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
    public partial class CAT10_TARGET : Form
    {
        public CAT10_TARGET(CAT10 cat10)
        {
            InitializeComponent();
            this.cat10 = cat10;
        }
        CAT10 cat10;

        private void CAT10_TARGET_Load(object sender, EventArgs e)
        {
            Tuple<string, string, string, string, string, string, string> tuple1 = cat10.getTarget1();
            Tuple<string, string, string, string> tuple2 = cat10.getTarget2();
            label_TYP.Text = "TYP: " + tuple1.Item1;
            label_DCR.Text = "DCR: " + tuple1.Item2;
            label_CHN.Text = "CHN: " + tuple1.Item3;
            label_GBS.Text = "GSB: " + tuple1.Item4;
            label_CRT.Text = "CRT: " + tuple1.Item5;
            label_SIM.Text = "SIM: " + tuple1.Item6;
            label_TST.Text = "TST: " + tuple1.Item7;
            label_RAB.Text = "RAB: " + tuple2.Item1;
            label_LOB.Text = "LOB: " + tuple2.Item2;
            label_TOT.Text = "TOT: " + tuple2.Item3;
            label_SPI.Text = "SPI: " + tuple2.Item4;

        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
