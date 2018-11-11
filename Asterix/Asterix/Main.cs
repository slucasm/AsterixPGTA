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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Fichero fichero;
        public List<CAT10> listaCAT10;
        public List<CAT20> listaCAT20;
        public List<CAT21> listaCAT21;
        public DataTable tablaCAT10;
        public DataTable tablaCAT20;
        public DataTable tablaCAT21;
        public ManageListas listas;
        TimeSpan starttime = TimeSpan.FromHours(22);
        int i = 0;
        int j = 0;

        private void Main_Load(object sender, EventArgs e)
        {
            label_starttime.Text = starttime.ToString(@"hh\:mm\:ss");
            timer.Interval = 1000;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
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
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            label_starttime.Text = starttime.ToString(@"hh\:mm\:ss");
            if (listaCAT21.Count != 0 && listaCAT10.Count != 0)
            {
                if (i < listaCAT21.Count)
                {
                    while (listaCAT21[i].getTime() < starttime)
                    {
                        Console.WriteLine(listaCAT21[i].getADDRESS());
                        Console.WriteLine(listaCAT21[i].getTime());
                        Console.WriteLine(i);
                        i++;
                    }
                }
                if (j < listaCAT10.Count)
                {
                    while (listaCAT10[j].getTime() < starttime)
                    {
                        Console.WriteLine(listaCAT10[j].getADDRESS());
                        Console.WriteLine(listaCAT10[j].getTime());
                        Console.WriteLine(j);
                        j++;
                    }
                }

            }
            else if (listaCAT21.Count != 0)
            {
                if ( i < listaCAT21.Count)
                {
                    while (listaCAT21[i].getTime() < starttime)
                    {
                        Console.WriteLine(listaCAT21[i].getADDRESS());
                        Console.WriteLine(listaCAT21[i].getTime());
                        Console.WriteLine(i);
                        i++;
                    }
                }
                
            }
            else if (listaCAT20.Count != 0)
            {
                if (i < listaCAT20.Count)
                {
                    while (listaCAT20[i].getTime() < starttime)
                    {
                        Console.WriteLine(listaCAT20[i].getADDRESS());
                        Console.WriteLine(listaCAT20[i].getTime());
                        Console.WriteLine(i);
                        i++;
                    }
                }

            }
            else if (listaCAT10.Count != 0)
            {
                if (i < listaCAT10.Count)
                {
                    while (listaCAT10[i].getTime() < starttime)
                    {
                        Console.WriteLine(listaCAT10[i].getADDRESS());
                        Console.WriteLine(listaCAT10[i].getTime());
                        Console.WriteLine(i);
                        i++;
                    }
                }

            }
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
            listas.actualizarTabla();
            tablaCAT10 = listas.getTablaCAT10();
            tablaCAT20 = listas.getTablaCAT20();
            tablaCAT21 = listas.getTablaCAT21();
            TablaVuelos f = new TablaVuelos(this);
            f.Show();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
