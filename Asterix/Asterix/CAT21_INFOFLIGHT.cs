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
    public partial class CAT21_INFOFLIGHT : Form
    {
        public CAT21_INFOFLIGHT(CAT21 cat21,List<String> listaCoordenadas)
        {
            InitializeComponent();
            this.cat21 = cat21;
            this.listaCoordenadas = listaCoordenadas;
        }
        CAT21 cat21;
        List<String> listaCoordenadas;
        private void CAT21_INFOFLIGHT_Load(object sender, EventArgs e)
        {
            label_SAC.Text = "SAC = " + cat21.SAC.ToString();
            label_SIC.Text = "SIC = " + cat21.SIC.ToString();
            label_Time.Text = "Time:" + cat21.myTime.ToString();
            label_X.Text = "Latitude = " + cat21.latitud.ToString();
            label_Y.Text = "Longitude = " + cat21.longitud.ToString();
            label_coordinates.Text = "Coordinates = " + cat21.coordinates;
            label_Address.Text = "Address: " + cat21.ADDRESS;
            label_ACID.Text = "ACID: " + cat21.ACID_palabra;
            label_Vr.Text = "Vr = " + cat21.VR;
            label_Level.Text = "Level = " + cat21.LEVEL;
            label_SPD.Text = "SPD = " + cat21.SPD;
            label_AGL.Text = "AGL = " + cat21.AGL;
            label_VA.Text = "VA = " + cat21.VA;

        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
