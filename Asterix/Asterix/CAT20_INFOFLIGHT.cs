﻿using System;
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
    public partial class CAT20_INFOFLIGHT : Form
    {
        public CAT20_INFOFLIGHT(CAT20 cat20, List<PointLatLng> listaCoordenadas)
        {
            InitializeComponent();
            this.cat20 = cat20;
            this.listaCoordenadas = listaCoordenadas;
        }
        CAT20 cat20;
        List<PointLatLng> listaCoordenadas;
        GMapOverlay markers = new GMapOverlay("markers");

        private void CAT20_INFOFLIGHT_Load(object sender, EventArgs e)
        {
            gMap_mapa.MapProvider = GMapProviders.GoogleMap;
            gMap_mapa.DragButton = MouseButtons.Left;
            gMap_mapa.Position = new PointLatLng(listaCoordenadas[0].Lat,listaCoordenadas[0].Lng);
            gMap_mapa.MinZoom = 1;
            gMap_mapa.MaxZoom = 20;
            gMap_mapa.Zoom = 8;
            gMap_mapa.ShowCenter = false;
            for (int i = 0; i < listaCoordenadas.Count; i++)
            {
                Bitmap bmpMarker = (Bitmap)Image.FromFile("avion-negro.png");
                GMapMarker marker = new GMarkerGoogle(listaCoordenadas[i], bmpMarker);
                markers.Markers.Add(marker);
                gMap_mapa.Overlays.Add(markers);
            }
            label_SAC.Text = "SAC = " + cat20.SAC.ToString();
            label_SIC.Text = "SIC = " + cat20.SIC.ToString();
            label_Time.Text = "Time:" + cat20.myTime.ToString();
            label_X.Text = "X = " + cat20.X.ToString();
            label_Y.Text = "Y = " + cat20.Y.ToString();
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

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
