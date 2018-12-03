using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibreriaClases;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Asterix
{
    public partial class CAT21_INFOFLIGHT : Form
    {
        public CAT21_INFOFLIGHT(CAT21 cat21, List<PointLatLng> listaCoordenadas)
        {
            InitializeComponent();
            this.cat21 = cat21;
            this.listaCoordenadas = listaCoordenadas;
        }
        CAT21 cat21;
        List<PointLatLng> listaCoordenadas;
        

        private void CAT21_INFOFLIGHT_Load(object sender, EventArgs e)
        {
            gMap_mapa.MapProvider = GMapProviders.GoogleMap;
            GMapOverlay markers = new GMapOverlay("markers");
            for (int i = 0; i < listaCoordenadas.Count; i+=20)
            {
                Bitmap bmpMarker = (Bitmap)Image.FromFile("avion-negro.png");
                GMapMarker marker = new GMarkerGoogle(listaCoordenadas[i], bmpMarker);
                markers.Markers.Add(marker);
                gMap_mapa.Overlays.Add(markers);
            }
            gMap_mapa.DragButton = MouseButtons.Left;
            gMap_mapa.Position = new PointLatLng(listaCoordenadas[0].Lat, listaCoordenadas[0].Lng);
            gMap_mapa.MinZoom = 1;
            gMap_mapa.MaxZoom = 20;
            gMap_mapa.Zoom = 8;
            gMap_mapa.ShowCenter = false;

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
