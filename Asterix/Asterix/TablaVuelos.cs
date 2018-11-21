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
            listaCAT10 = listas.getListCAT10();
            listaCAT20 = listas.getListCAT20();
            listaCAT21 = listas.getListCAT21();
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

            dataGridView_CAT10.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridView_CAT20.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridView_CAT21.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);

            dataGridView_CAT10.DefaultCellStyle.ForeColor = Color.White;
            dataGridView_CAT20.DefaultCellStyle.ForeColor = Color.White;
            dataGridView_CAT21.DefaultCellStyle.ForeColor = Color.White;

            dataGridView_CAT10.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_CAT20.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_CAT21.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView_CAT10.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 124, 191);
            dataGridView_CAT20.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 124, 191);
            dataGridView_CAT21.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 124, 191);

            dataGridView_CAT10.EnableHeadersVisualStyles = false;
            dataGridView_CAT20.EnableHeadersVisualStyles = false;
            dataGridView_CAT21.EnableHeadersVisualStyles = false;

            dataGridView_CAT10.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dataGridView_CAT20.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dataGridView_CAT21.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48);



            

            if (tablaCAT10.Rows.Count != 0)
            {
                checkBox_CAT10.Checked = true;
                checkBox_CAT20.Checked = false;
                checkBox_CAT21.Checked = false;
                dataGridView_CAT10.Visible = true;
                dataGridView_CAT20.Visible = false;
                dataGridView_CAT21.Visible = false;
                dataGridView_CAT10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                
            }
            else if (tablaCAT20.Rows.Count != 0)
            {
                checkBox_CAT10.Checked = false;
                checkBox_CAT20.Checked = true;
                checkBox_CAT21.Checked = false;
                dataGridView_CAT10.Visible = false;
                dataGridView_CAT20.Visible = true;
                dataGridView_CAT21.Visible = false;
                dataGridView_CAT20.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else if (tablaCAT21.Rows.Count != 0)
            {
                checkBox_CAT10.Checked = false;
                checkBox_CAT20.Checked = false;
                checkBox_CAT21.Checked = true;
                dataGridView_CAT10.Visible = false;
                dataGridView_CAT20.Visible = false;
                dataGridView_CAT21.Visible = true;
                dataGridView_CAT21.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
                dataGridView_CAT10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                
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
                dataGridView_CAT20.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
                dataGridView_CAT21.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            listas.singleList();
            MessageBox.Show("Fichero decodificado correctamente");
            dataGridView_CAT10.DataSource = tablaCAT10;
            dataGridView_CAT20.DataSource = tablaCAT20;
            dataGridView_CAT21.DataSource = tablaCAT21;
            if (listaCAT10.Count != 0) { dataGridView_CAT10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; }
            if (listaCAT20.Count != 0) { dataGridView_CAT20.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; }
            if (listaCAT21.Count != 0) { dataGridView_CAT21.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; }
            
            
            
        }

        private void dataGridView_CAT21_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = dataGridView_CAT21.CurrentCell.ColumnIndex;
            int fila = dataGridView_CAT21.CurrentCell.RowIndex;
            if (columna == 2)
            { 
                CAT21_TARGET target = new CAT21_TARGET(listaCAT21[fila]);
                target.Show();
            }
            else if (columna == 8)
            {
                CAT21_LINK link = new CAT21_LINK(listaCAT21[fila]);
                link.Show();
            }
            else if (columna == 12)
            {
                CAT21_FOM fom = new CAT21_FOM(listaCAT21[fila]);
                fom.Show();
            }
        }

        private void dataGridView_CAT20_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = dataGridView_CAT20.CurrentCell.ColumnIndex;
            int fila = dataGridView_CAT20.CurrentCell.RowIndex;
            if (columna == 8)
            {
                CAT20_TARGET target = new CAT20_TARGET(listaCAT20[fila]);
                target.Show();
            }
            else if (columna == 10)
            {
                CAT20_TRACKSTATUS trackstatus = new CAT20_TRACKSTATUS(listaCAT20[fila]);
                trackstatus.Show();
            }

        }

        private void dataGridView_CAT10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = dataGridView_CAT10.CurrentCell.ColumnIndex;
            int fila = dataGridView_CAT10.CurrentCell.RowIndex;
            if (columna == 9)
            {
                CAT10_TARGET target = new CAT10_TARGET(listaCAT10[fila]);
                target.Show();
            }
            else if (columna == 11)
            {
                CAT10_TRACKSTATUS trackstatus = new CAT10_TRACKSTATUS(listaCAT10[fila]);
                trackstatus.Show();
            }
        }

        

        
    }
}
