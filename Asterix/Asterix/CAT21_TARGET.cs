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
    public partial class CAT21_TARGET : Form
    {
        public CAT21_TARGET(CAT21 cat21)
        {
            InitializeComponent();
            this.cat21 = cat21;
        }
        CAT21 cat21;
        private void CAT21_TARGET_Load(object sender, EventArgs e)
        {
            Tuple<string, string, string, string, string, string, string> tuple1 = cat21.getTarget1();
            Tuple<string, string> tuple2 = cat21.getTarget2();

            label_DCR.Text = "DCR: " + tuple1.Item1;
            label_GBS.Text = "GBS: " + tuple1.Item2;
            label_SIM.Text = "SIM: " + tuple1.Item3;
            label_TST.Text = "TST: " + tuple1.Item4;
            label_RAB.Text = "RAB: " + tuple1.Item5;
            label_SAA.Text = "SAA: " + tuple1.Item6;
            label_SPI.Text = "SPI: " + tuple1.Item7;
            label_ATP.Text = "ATP: " + tuple2.Item1;
            label_ARC.Text = "ARC: " + tuple2.Item2;





        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
