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

        Boolean playPress = false;
        Boolean stopPress = true;

        TimeSpan starttime = TimeSpan.FromHours(22);
        int i = 0;
        int j = 0;
        int counter = 0;

        GMapOverlay markers = new GMapOverlay("markers");

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                gMap_mapa.MapProvider = GMapProviders.GoogleMap;
                gMap_mapa.DragButton = MouseButtons.Left;
                gMap_mapa.Position = new PointLatLng(41.289182, 2.0746423);
                gMap_mapa.MinZoom = 1;
                gMap_mapa.MaxZoom = 20;
                gMap_mapa.Zoom = 7;
                gMap_mapa.ShowCenter = false;


                label_starttime.Text = starttime.ToString(@"hh\:mm\:ss");
                timer.Interval = 1000;
                trackBar_speedtime.Value = 1000;
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
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
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
                MessageBox.Show("File decoded correctly");
                trackBar_speedtime.Value = 1000;
                timer.Interval = 1000;
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                label_starttime.Text = starttime.ToString(@"hh\:mm\:ss");
            
                if (i < listFLights.Count)
                {
                
                    GMapOverlay markers = new GMapOverlay("markers" +counter);
                    while (listFLights[i].time < starttime)
                    {
                    
                        tablaSingle = listFLights[i].actualizarTabla(tablaSingle,i);
                        Bitmap bmpMarker = (Bitmap)Image.FromFile("avion-negro.png");
                        GMapMarker marker = new GMarkerGoogle(listFLights[i].punto, bmpMarker);
                        marker.Tag = i;
                        markers.Markers.Add(marker);
                        i++;
                    }
                    gMap_mapa.Overlays.Add(markers);
                
                    if (gMap_mapa.Overlays.Count >= 5)
                    {
                        gMap_mapa.Overlays.RemoveAt(0);
                        gMap_mapa.Refresh();
                        gMap_mapa.Update();
                    }
                    counter++;
                    gMap_mapa.Position = new PointLatLng(41.289182, 2.0746423);
                }

                starttime = starttime.Add(TimeSpan.FromSeconds(1));
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void trackBar_speedtime_Scroll(object sender, EventArgs e)
        {
            timer.Interval = trackBar_speedtime.Value;
            
        }

        private void button_tablas_Click(object sender, EventArgs e)
        {
            try
            {
                TablaVuelos f = new TablaVuelos(listas);
                f.Show();
                this.Hide();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_introduction_Click(object sender, EventArgs e)
        {
            try 
            {
                Introduction i = new Introduction();
                i.Show();
                this.Hide();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void pictureBox_start_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Start();
                playPress = true;
                stopPress = false;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void pictureBox_pause_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();
                playPress = false;
                stopPress = true;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }


        private void dataGridView_flights_CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (stopPress == true)
                {
                    int fila = dataGridView_flights.CurrentCell.RowIndex;
                    List<PointLatLng> listaCoordenades = createListCoordenadas(fila);
                    if (e.Button == MouseButtons.Left)
                    {
                        if (listFLights[fila].CAT == 10)
                        {
                            CAT10_INFOFLIGHT cat10_infoflight = new CAT10_INFOFLIGHT(listaCAT10[listFLights[fila].realindex], listaCoordenades);
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
                        /*Bitmap bmpMarker = (Bitmap)Image.FromFile("avion-amarillo.png");
                        GMapMarker marker = new GMarkerGoogle(listFLights[i].punto, bmpMarker);
                        markers.Markers.Add(marker);
                        gMap_mapa.Overlays.Add(markers);*/
                    }
                }
                else
                {
                    MessageBox.Show("Please, stop simulation to view more flight information!");
                }
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private List<PointLatLng> createListCoordenadas(int fila)
        {
                List<PointLatLng> listaCoordenadas = new List<PointLatLng>();

                string nombre = listFLights[fila].ACID;
                listaCoordenadas.Add(listFLights[fila].punto);
                if (listFLights[fila].ACID != null)
                {
                    for (int i = fila + 1; i < listFLights.Count; i++)
                    {
                        if (nombre.Equals(listFLights[i].ACID))
                        {
                            listaCoordenadas.Add(listFLights[i].punto);
                        }
                    }
                }
                return listaCoordenadas;
        }

        private void dataGridView_flights_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int fila = e.RowIndex;//dataGridView_flights.CurrentRow.Index;
                    Bitmap bmpMarker = (Bitmap)Image.FromFile("avion-amarillo.png");
                    GMapMarker marker = new GMarkerGoogle(listFLights[fila].punto, bmpMarker);
                    markers.Markers.Add(marker);
                    gMap_mapa.Overlays.Add(markers);
                }
            }
            catch (Exception j)
            {
                MessageBox.Show(j.Message);
            }

        }

        private void gMap_mapa_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            try
            {
                if (stopPress == true)
                {
                    //timer.Stop();
                    if (e.Button == MouseButtons.Left)
                    {
                        int index = Convert.ToInt32(item.Tag);
                        List<PointLatLng> listaCoordenades = createListCoordenadas(index);
                        if (listFLights[index].CAT == 10)
                        {
                            CAT10_INFOFLIGHT cat10_infoflight = new CAT10_INFOFLIGHT(listaCAT10[listFLights[index].realindex], listaCoordenades);
                            cat10_infoflight.Show();
                        }
                        else if (listFLights[index].CAT == 20)
                        {
                            CAT20_INFOFLIGHT cat20_infoflight = new CAT20_INFOFLIGHT(listaCAT20[listFLights[index].realindex], listaCoordenades);
                            cat20_infoflight.Show();
                        }
                        else if (listFLights[index].CAT == 21)
                        {
                            CAT21_INFOFLIGHT cat21_infoflight = new CAT21_INFOFLIGHT(listaCAT21[listFLights[index].realindex], listaCoordenades);
                            cat21_infoflight.Show();
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        int index = Convert.ToInt32(item.Tag);
                        dataGridView_flights.ClearSelection();
                        dataGridView_flights.Rows[index].Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please, stop simulation to view more flight information!");
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }

        private void pictureBox_restart_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();
                starttime = TimeSpan.FromHours(22);
                label_starttime.Text = starttime.ToString(@"hh\:mm\:ss");
                timer.Interval = 1000;
                trackBar_speedtime.Value = 1000;
                tablaSingle.Clear();
                i = 0;
                gMap_mapa.Overlays.Clear();
                gMap_mapa.Refresh();

            }
            catch (Exception l)
            {
                MessageBox.Show(l.Message);
            }
        }

        

        

    }
}
