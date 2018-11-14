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
    public partial class TablaVuelos : Form
    {
        public TablaVuelos(ManageListas listas)
        {
            InitializeComponent();
            this.listas = listas;
        }

        ManageListas listas;
        DataTable tablaCAT10, tablaCAT20, tablaCAT21;

        Fichero fichero;
        List<CAT10> listaCAT10;
        List<CAT20> listaCAT20;
        List<CAT21> listaCAT21;


        private void TablaVuelos_Load(object sender, EventArgs e)
        {
            tablaCAT10 = listas.getTablaCAT10();
            tablaCAT20 = listas.getTablaCAT20();
            tablaCAT21 = listas.getTablaCAT21();
            dataGridView_CAT10.DataSource = tablaCAT10;
            dataGridView_CAT20.DataSource = tablaCAT20;
            dataGridView_CAT21.DataSource = tablaCAT21;
            dataGridView_CAT10.AllowUserToAddRows = false;
            dataGridView_CAT20.AllowUserToAddRows = false;
            dataGridView_CAT21.AllowUserToAddRows = false;
            dataGridView_CAT10.RowHeadersVisible = false;
            dataGridView_CAT20.RowHeadersVisible = false;
            dataGridView_CAT21.RowHeadersVisible = false;
            

            if (tablaCAT10.Rows.Count != 0)
            {
                checkBox_CAT10.Checked = true;
                checkBox_CAT20.Checked = false;
                checkBox_CAT21.Checked = false;
                dataGridView_CAT10.Visible = true;
                dataGridView_CAT20.Visible = false;
                dataGridView_CAT21.Visible = false;
                
            }
            else if (tablaCAT20.Rows.Count != 0)
            {
                checkBox_CAT10.Checked = false;
                checkBox_CAT20.Checked = true;
                checkBox_CAT21.Checked = false;
                dataGridView_CAT10.Visible = false;
                dataGridView_CAT20.Visible = true;
                dataGridView_CAT21.Visible = false;
            }
            else if (tablaCAT21.Rows.Count != 0)
            {
                checkBox_CAT10.Checked = false;
                checkBox_CAT20.Checked = false;
                checkBox_CAT21.Checked = true;
                dataGridView_CAT10.Visible = false;
                dataGridView_CAT20.Visible = false;
                dataGridView_CAT21.Visible = true;
            }
            

        }

        private void checkBox_CAT10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CAT10.Checked == true)
            {
                checkBox_CAT10.Checked = true;
                checkBox_CAT20.Checked = false;
                checkBox_CAT21.Checked = false;
                dataGridView_CAT10.Visible = true;
                dataGridView_CAT20.Visible = false;
                dataGridView_CAT21.Visible = false;
            }
            else
            {
                checkBox_CAT10.Checked = false;
                dataGridView_CAT10.Visible = false;
            }
        }

        private void checkBox_CAT20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CAT20.Checked == true)
            {
                checkBox_CAT10.Checked = false;
                checkBox_CAT20.Checked = true;
                checkBox_CAT21.Checked = false;
                dataGridView_CAT10.Visible = false;
                dataGridView_CAT20.Visible = true;
                dataGridView_CAT21.Visible = false;
            }
            else
            {
                checkBox_CAT20.Checked = false;
                dataGridView_CAT20.Visible = false;
            }
        }

        private void checkBox_CAT21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CAT21.Checked == true)
            {
                checkBox_CAT10.Checked = false;
                checkBox_CAT20.Checked = false;
                checkBox_CAT21.Checked = true;
                dataGridView_CAT10.Visible = false;
                dataGridView_CAT20.Visible = false;
                dataGridView_CAT21.Visible = true;
            }
            else
            {
                checkBox_CAT21.Checked = false;
                dataGridView_CAT21.Visible = false;
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_simulation_Click(object sender, EventArgs e)
        {
            Simulation s = new Simulation(listas);
            s.Show();
        }

        private void button_introduction_Click(object sender, EventArgs e)
        {
            Introduction i = new Introduction();
            i.Show();
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
            MessageBox.Show("Fichero decodificado correctamente");
            dataGridView_CAT10.DataSource = tablaCAT10;
            dataGridView_CAT20.DataSource = tablaCAT20;
            dataGridView_CAT21.DataSource = tablaCAT21;
        }

        

        
    }
}
