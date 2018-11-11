using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asterix
{
    public partial class TablaVuelos : Form
    {
        public TablaVuelos(Main IncomingForm)
        {
            InitializeComponent();
            MainForm = IncomingForm;
        }

        Main MainForm;

        private void TablaVuelos_Load(object sender, EventArgs e)
        {
            dataGridView_CAT10.DataSource = MainForm.tablaCAT10;
            dataGridView_CAT20.DataSource = MainForm.tablaCAT20;
            dataGridView_CAT21.DataSource = MainForm.tablaCAT21;
            dataGridView_CAT10.AllowUserToAddRows = false;
            dataGridView_CAT20.AllowUserToAddRows = false;
            dataGridView_CAT21.AllowUserToAddRows = false;
            dataGridView_CAT10.RowHeadersVisible = false;
            dataGridView_CAT20.RowHeadersVisible = false;
            dataGridView_CAT21.RowHeadersVisible = false;

            if (MainForm.listaCAT10.Count != 0)
            {
                checkBox_CAT10.Checked = true;
                checkBox_CAT20.Checked = false;
                checkBox_CAT21.Checked = false;
                dataGridView_CAT10.Visible = true;
                dataGridView_CAT20.Visible = false;
                dataGridView_CAT21.Visible = false;
                
            }
            else if (MainForm.listaCAT20.Count != 0)
            {
                checkBox_CAT10.Checked = false;
                checkBox_CAT20.Checked = true;
                checkBox_CAT21.Checked = false;
                dataGridView_CAT10.Visible = false;
                dataGridView_CAT20.Visible = true;
                dataGridView_CAT21.Visible = false;
            }
            else if (MainForm.listaCAT21.Count != 0)
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
            this.Close();
        }

        
    }
}
