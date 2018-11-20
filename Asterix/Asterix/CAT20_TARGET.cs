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
    public partial class CAT20_TARGET : Form
    {
        public CAT20_TARGET(CAT20 cat20)
        {
            InitializeComponent();
            this.cat20 = cat20;
        }
        CAT20 cat20;
        private void CAT20_TARGET_Load(object sender, EventArgs e)
        {
            Tuple<string, string, string, string, string, string, string> tuple1 = cat20.getTarget1();
            Tuple<string, string, string, string, string, string, string> tuple2 = cat20.getTarget2();
            label_SSR.Text = "SSR: " +tuple1.Item1;
            label_MS.Text = "MS: " + tuple1.Item2;
            label_HF.Text = "HF: " + tuple1.Item3;
            label_VDL4.Text = "VDL4: " + tuple1.Item4;
            label_UAT.Text = "UAT: " + tuple1.Item5;
            label_DME.Text = "DME: " + tuple1.Item6;
            label_OT.Text = "OT: " + tuple1.Item7;
            label_RAB.Text = "RAB: " + tuple2.Item1;
            label_SPI.Text = "SPI: " + tuple2.Item2;
            label_CHN.Text = "CHN: " + tuple2.Item3;
            label_GBS.Text = "GBS: " + tuple2.Item4;
            label_CRT.Text = "CRT: " + tuple2.Item5;
            label_SIM.Text = "SIM: " + tuple2.Item6;
            label_TST.Text = "TST: " + tuple2.Item7;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
