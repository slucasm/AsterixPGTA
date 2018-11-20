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
    public partial class CAT20_INFOFLIGHT : Form
    {
        public CAT20_INFOFLIGHT(CAT20 cat20)
        {
            InitializeComponent();
            this.cat20 = cat20;
        }
        CAT20 cat20;
        private void CAT20_INFOFLIGHT_Load(object sender, EventArgs e)
        {
            label_SAC.Text = "SAC = " + cat20.SAC.ToString();
            label_SIC.Text = "SIC = " + cat20.SIC.ToString();
            label_Time.Text = "Time:" + cat20.myTime.ToString();
            label_X.Text = "Latitude = " + cat20.X.ToString();
            label_Y.Text = "Longitude = " + cat20.Y.ToString();
            label_coordinates.Text = "Coordinates = " + cat20.coordinates;
            label_VX.Text = "Vx = " + cat20.VX.ToString();
            label_VY.Text = "Vy = " + cat20.VY.ToString();
            label_TrackNumber.Text = "Track Number = " + cat20.TRACK_NUM;
            label_3A.Text = "Mode 3A: " + cat20.MODE_3A;
            label_c.Text = "Mode C: " + cat20.MODE_C.ToString();
            label_Address.Text = "Address: " + cat20.ADDRESS;
            label_ACID.Text = "ACID: " + cat20.ACID_palabra;
            label_receivers.Text = "Nº receivers = " + cat20.RECEIVERS.ToString();
        }
    }
}
