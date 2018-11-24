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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        Fichero fichero;
        public List<CAT10> listaCAT10;
        public List<CAT20> listaCAT20;
        public List<CAT21> listaCAT21;
        public ManageListas listas;

        public DataTable tablaCAT10;
        public DataTable tablaCAT20;
        public DataTable tablaCAT21;

        private void Introduction_Load(object sender, EventArgs e)
        {
            
            
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
            listas.actualizarTabla();
            tablaCAT10 = listas.getTablaCAT10();
            tablaCAT20 = listas.getTablaCAT20();
            tablaCAT21 = listas.getTablaCAT21();
            listas.singleList();
            MessageBox.Show("Fichero decodificado correctamente");
        }

        private void button_simulation_Click(object sender, EventArgs e)
        {
            if (fichero != null)
            {
                Simulation simulation = new Simulation(listas);
                simulation.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Primero debes cargar un fichero");
            }
        }

        private void button_tablas_Click(object sender, EventArgs e)
        {
            if (fichero != null)
            {
                TablaVuelos f = new TablaVuelos(listas);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Primero debes cargar un fichero");
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        
    }
}
