using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibreriaClases;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace Asterix
{
    public partial class Simulation : Form
    {
        public Simulation(ManageListas listas)
        {
            InitializeComponent();
            this.listas = listas;
        }

        Fichero fichero;
        List<CAT10> listaCAT10;
        List<CAT20> listaCAT20;
        List<CAT21> listaCAT21;
        List<Flight> listFLights;
        ManageListas listas;
        DataTable tablaSingle = new DataTable();

        TimeSpan starttime = TimeSpan.FromHours(22);
        int i = 0;
        int j = 0;
        int counter = 0;
        GMapOverlay markers = new GMapOverlay("markers");

        private void Main_Load(object sender, EventArgs e)
        {
            gMap_mapa.MapProvider = GMapProviders.GoogleMap;
            gMap_mapa.DragButton = MouseButtons.Left;
            gMap_mapa.Zoom = 5;
            gMap_mapa.MinZoom = 1;
            gMap_mapa.MaxZoom = 50;
            gMap_mapa.Position = new PointLatLng(41.289182, 2.0746423);
            
            
            label_starttime.Text = starttime.ToString(@"hh\:mm\:ss");
            timer.Interval = 1000;
            listaCAT10 = listas.getListCAT10();
            listaCAT20 = listas.getListCAT20();
            listaCAT21 = listas.getListCAT21();
            listFLights = listas.getSingleList();
            tablaSingle.Columns.Add("#", typeof(int));
            tablaSingle.Columns.Add("CAT", typeof(int));
            tablaSingle.Columns.Add("ACID", typeof(string));
            tablaSingle.Columns.Add("Time", typeof(TimeSpan));
            tablaSingle.Columns.Add("Coordinates", typeof(string));
            tablaSingle.Columns.Add("Real index", typeof(int));
            dataGridView_flights.DataSource = tablaSingle;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            tablaSingle.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "AST";
            ofd.Filter = "Archivos AST|*.AST|All files(*.*)|*.*";
            ofd.Title = "Abrir archivos";
            ofd.ShowDialog();
            fichero = new Fichero(ofd.FileName);
            fichero.leer();
            listaCAT10 = fichero.getListCAT10();
            listaCAT20 = fichero.getListCAT20();
            listaCAT21 = fichero.getListCAT21();
            listas = new ManageListas(listaCAT10, listaCAT20, listaCAT21);
            listas.resolvelistas();
            listas.actualizarTabla();
            listas.singleList();
            listFLights = listas.getSingleList();
            label_starttime.Text = TimeSpan.FromHours(22).ToString(@"hh\:mm\:ss");
            starttime = TimeSpan.FromHours(22);
            i = 0;
            dataGridView_flights.DataSource = tablaSingle;
            MessageBox.Show("Fichero decodificado correctamente");
 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            label_starttime.Text = starttime.ToString(@"hh\:mm\:ss");
            
            if (i < listFLights.Count)
            {
                while (listFLights[i].time < starttime)
                {
                    tablaSingle = listFLights[i].actualizarTabla(tablaSingle,i);
                    Bitmap bmpMarker = (Bitmap)Image.FromFile("avion-negro.png");
                    GMapMarker marker = new GMarkerGoogle(listFLights[i].punto, bmpMarker);
                    markers.Markers.Add(marker);
                    gMap_mapa.Overlays.Add(markers);
                    i++;
                    
                }
                if (counter > 5)
                {
                    gMap_mapa.Overlays.RemoveAt(0);
                    gMap_mapa.Refresh();
                }
                counter++;
                
            }


            //if (listaCAT21.Count != 0 && listaCAT10.Count != 0)
            //{
            //    if (i < listaCAT21.Count)
            //    {
            //        while (listaCAT21[i].getTime() < starttime)
            //        {
            //            Console.WriteLine(listaCAT21[i].getADDRESS());
            //            Console.WriteLine(listaCAT21[i].getTime());
            //            Console.WriteLine(i);
            //            i++;
            //        }
            //    }
            //    if (j < listaCAT10.Count)
            //    {
            //        while (listaCAT10[j].getTime() < starttime)
            //        {
            //            Console.WriteLine(listaCAT10[j].getADDRESS());
            //            Console.WriteLine(listaCAT10[j].getTime());
            //            Console.WriteLine(j);
            //            j++;
            //        }
            //    }

            //}
            //else if (listaCAT21.Count != 0)
            //{
            //    if ( i < listaCAT21.Count)
            //    {
            //        while (listaCAT21[i].getTime() < starttime)
            //        {
            //            Console.WriteLine(listaCAT21[i].getADDRESS());
            //            Console.WriteLine(listaCAT21[i].getTime());
            //            Console.WriteLine(i);
            //            i++;
            //        }
            //    }
                
            //}
            //else if (listaCAT20.Count != 0)
            //{
            //    if (i < listaCAT20.Count)
            //    {
            //        while (listaCAT20[i].getTime() < starttime)
            //        {
            //            Console.WriteLine(listaCAT20[i].getADDRESS());
            //            Console.WriteLine(listaCAT20[i].getTime());
            //            Console.WriteLine(i);
            //            i++;
            //        }
            //    }

            //}
            //else if (listaCAT10.Count != 0)
            //{
            //    if (i < listaCAT10.Count)
            //    {
            //        while (listaCAT10[i].getTime() < starttime)
            //        {
            //            Console.WriteLine(listaCAT10[i].getADDRESS());
            //            Console.WriteLine(listaCAT10[i].getTime());
            //            Console.WriteLine(i);
            //            i++;
            //        }
            //    }

            //}
            starttime = starttime.Add(TimeSpan.FromSeconds(1));
        }

        private void trackBar_speedtime_Scroll(object sender, EventArgs e)
        {
            timer.Interval = trackBar_speedtime.Value;
            
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer.Start();
            
        }

        private void button_tablas_Click(object sender, EventArgs e)
        {
            TablaVuelos f = new TablaVuelos(listas);
            f.Show();
            this.Hide();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_introduction_Click(object sender, EventArgs e)
        {
            Introduction i = new Introduction();
            i.Show();
            this.Hide();
        }

        private void pictureBox_start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pictureBox_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void dataGridView_flights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            int columna = dataGridView_flights.CurrentCell.ColumnIndex;
            int fila = dataGridView_flights.CurrentCell.RowIndex;

            if (listFLights[fila].CAT == 10)
            {
                CAT10_INFOFLIGHT cat10_infoflight = new CAT10_INFOFLIGHT(listaCAT10[listFLights[fila].realindex]);
                cat10_infoflight.Show();
            }
            else if (listFLights[fila].CAT == 20)
            {
                CAT20_INFOFLIGHT cat20_infoflight = new CAT20_INFOFLIGHT(listaCAT20[listFLights[fila].realindex]);
                cat20_infoflight.Show();
            }
            else if (listFLights[fila].CAT == 21)
            {
                CAT21_INFOFLIGHT cat21_infoflight = new CAT21_INFOFLIGHT(listaCAT21[listFLights[fila].realindex]);
                cat21_infoflight.Show();
            }
        */}

        private void dataGridView_flights_CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = dataGridView_flights.CurrentCell.RowIndex;
            List<PointLatLng> listaCoordenades = createListCoordenadas(fila);
            if (e.Button == MouseButtons.Left)
            {
                if (listFLights[fila].CAT == 10)
                {
                    CAT10_INFOFLIGHT cat10_infoflight = new CAT10_INFOFLIGHT(listaCAT10[listFLights[fila].realindex],listaCoordenades);
                    cat10_infoflight.Show();
                }
                else if (listFLights[fila].CAT == 20)
                {
                    CAT20_INFOFLIGHT cat20_infoflight = new CAT20_INFOFLIGHT(listaCAT20[listFLights[fila].realindex], listaCoordenades);
                    cat20_infoflight.Show();
                }
                else if (listFLights[fila].CAT == 21)
                {
                    CAT21_INFOFLIGHT cat21_infoflight = new CAT21_INFOFLIGHT(listaCAT21[listFLights[fila].realindex], listaCoordenades);
                    cat21_infoflight.Show();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Bitmap bmpMarker = (Bitmap)Image.FromFile("avion-amarillo.png");
                GMapMarker marker = new GMarkerGoogle(listFLights[i].punto, bmpMarker);
                markers.Markers.Add(marker);
                gMap_mapa.Overlays.Add(markers);
            }
        }

        private List<PointLatLng> createListCoordenadas(int fila)
        {
            List<PointLatLng> listaCoordenadas = new List<PointLatLng>();

            string nombre = listFLights[fila].ACID;
            listaCoordenadas.Add(listFLights[fila].punto);
            for (int i = fila+1; i < listFLights.Count; i++)
            {
                if (nombre.Equals(listFLights[i].ACID))
                {
                    listaCoordenadas.Add(listFLights[i].punto);
                }
            }

            return listaCoordenadas;
        }

    }
}
