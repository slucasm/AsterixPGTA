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
    public partial class CAT21_FOM : Form
    {
        public CAT21_FOM(CAT21 cat21)
        {
            InitializeComponent();
            this.cat21 = cat21;
        }
        CAT21 cat21;
        private void CAT21_FOM_Load(object sender, EventArgs e)
        {
            Tuple<string, string, string, string> tuple = cat21.getFOM();

            label_AC.Text = "AC: " + tuple.Item1;
            label_MN.Text = "MN: " + tuple.Item2;
            label_DC.Text = "DC: " + tuple.Item3;
            label_PA.Text = "PA: " + tuple.Item4;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
