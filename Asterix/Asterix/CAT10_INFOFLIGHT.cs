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
    public partial class CAT10_INFOFLIGHT : Form
    {
        public CAT10_INFOFLIGHT(CAT10 cat10,List<String> listaCoordenadas)
        {
            InitializeComponent();
            this.cat10 = cat10;
            this.listaCoordenadas = listaCoordenadas;
        }
        CAT10 cat10;
        List<String> listaCoordenadas;
        private void CAT10_INFOFLIGHT_Load(object sender, EventArgs e)
        {
            label_SAC.Text = "SAC = " + cat10.SAC.ToString();
            label_SIC.Text = "SIC = " + cat10.SIC.ToString();
            label_Message.Text = "Message: " + cat10.Message_type;
            label_Time.Text = "Time:" + cat10.myTime.ToString();
            label_X.Text = "Latitude = " + cat10.X.ToString();
            label_Y.Text = "Longitude = " + cat10.Y.ToString();
            label_coordinates.Text = "Coordinates = " + cat10.coordinates;
            label_VX.Text = "Vx = " + cat10.VX.ToString();
            label_VY.Text = "Vy = " + cat10.VY.ToString();
            label_TrackNumber.Text = "Track Number = " + cat10.TRACKNUMBER.ToString();
            label_3A.Text = "Mode 3A: " + cat10.MODE_3A;
            label_Address.Text = "Address: " + cat10.ADDRESS;
            label_ACID.Text = "ACID: " + cat10.ACID_palabra;
            label_FL.Text = "Flight Level = " + cat10.FLIGHTLEVEL.ToString();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
