using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LibreriaClases
{
    public class ManageListas
    {
        List<CAT10> listaCAT10 = new List<CAT10>();
        List<CAT20> listaCAT20 = new List<CAT20>();
        List<CAT21> listaCAT21 = new List<CAT21>();
        DataTable tablaCAT10 = new DataTable();
        DataTable tablaCAT20 = new DataTable();
        DataTable tablaCAT21 = new DataTable();

        public ManageListas(List<CAT10> listaCAT10, List<CAT20> listaCAT20, List<CAT21> listaCAT21)
        {
            this.listaCAT10 = listaCAT10;
            this.listaCAT20 = listaCAT20;
            this.listaCAT21 = listaCAT21;
        }

        public void resolvelistas()
        {
            if (listaCAT10 != null)
            {
                for (int i = 0; i < listaCAT10.Count; i++)
                {
                    listaCAT10[i].hex2binary();
                    listaCAT10[i].fspec();
                    listaCAT10[i].comprobar_fspec();
                    listaCAT10[i].resolver_dataitems();
                }
            }


            if (listaCAT20 != null)
            {
                for (int j = 0; j < listaCAT20.Count; j++)
                {
                    listaCAT20[j].hex2binary();
                    listaCAT20[j].fspec();
                    listaCAT20[j].comprobar_fspec();
                    listaCAT20[j].resolver_dataitems();
                }

            }
            if (listaCAT21 != null)
            {
                for (int k = 0; k < listaCAT21.Count; k++)
                {
                    listaCAT21[k].hex2binary();
                    listaCAT21[k].fspec();
                    listaCAT21[k].comprobar_fspec();
                    listaCAT21[k].resolver_dataitems();
                }
            }
        }

        public void actualizarTabla()
        {
            tablaCAT10.Columns.Add("SAC", typeof(int));
            tablaCAT10.Columns.Add("SIC", typeof(int));
            tablaCAT10.Columns.Add("Message", typeof(string));
            tablaCAT10.Columns.Add("Time", typeof(TimeSpan));
            tablaCAT10.Columns.Add("X", typeof(double));
            tablaCAT10.Columns.Add("Y", typeof(double));
            tablaCAT10.Columns.Add("Vx", typeof(double));
            tablaCAT10.Columns.Add("Vy", typeof(double));
            tablaCAT10.Columns.Add("Target", typeof(string));
            tablaCAT10.Columns.Add("Track number", typeof(string));
            tablaCAT10.Columns.Add("Targ", typeof(string));
            tablaCAT10.Columns.Add("Mode 3A", typeof(string));
            tablaCAT10.Columns.Add("Address", typeof(string));
            tablaCAT10.Columns.Add("ACID", typeof(string));
            tablaCAT10.Columns.Add("Fligh level", typeof(double));

            tablaCAT20.Columns.Add("SAC", typeof(int));
            tablaCAT20.Columns.Add("SIC", typeof(int));
            tablaCAT20.Columns.Add("MLAT", typeof(string));
            tablaCAT20.Columns.Add("Time", typeof(TimeSpan));
            tablaCAT20.Columns.Add("X", typeof(double));
            tablaCAT20.Columns.Add("Y", typeof(double));
            tablaCAT20.Columns.Add("Vx", typeof(double));
            tablaCAT20.Columns.Add("Vy", typeof(double));
            tablaCAT20.Columns.Add("Target report", typeof(string));
            tablaCAT20.Columns.Add("Track number", typeof(string));
            tablaCAT20.Columns.Add("Track status", typeof(string));
            tablaCAT20.Columns.Add("Mode 3A", typeof(string));
            tablaCAT20.Columns.Add("Mode C", typeof(double));
            tablaCAT20.Columns.Add("Addres", typeof(string));
            tablaCAT20.Columns.Add("Acid", typeof(string));
            tablaCAT20.Columns.Add("Nº receivers", typeof(int));

            tablaCAT21.Columns.Add("SAC", typeof(int));
            tablaCAT21.Columns.Add("SIC", typeof(int));
            tablaCAT21.Columns.Add("Target", typeof(string));
            tablaCAT21.Columns.Add("Time", typeof(TimeSpan));
            tablaCAT21.Columns.Add("Latitud", typeof(double));
            tablaCAT21.Columns.Add("Longitud", typeof(double));
            tablaCAT21.Columns.Add("Vr", typeof(string));
            tablaCAT21.Columns.Add("Link", typeof(string));
            tablaCAT21.Columns.Add("Level", typeof(string));
            tablaCAT21.Columns.Add("SPD", typeof(string));
            tablaCAT21.Columns.Add("AGL", typeof(string));
            tablaCAT21.Columns.Add("FOM", typeof(string));
            tablaCAT21.Columns.Add("Address", typeof(string));
            tablaCAT21.Columns.Add("ACID", typeof(string));
            tablaCAT21.Columns.Add("VA", typeof(string));



            if (listaCAT10.Count != 0)
            {
                for (int i = 0; i < listaCAT10.Count; i++)
                {
                    tablaCAT10 = listaCAT10[i].actualizarTabla(tablaCAT10);
                }
            }
            if (listaCAT20.Count != 0)
            {
                for (int j = 0; j < listaCAT20.Count; j++)
                {
                    tablaCAT20 = listaCAT20[j].actualizarTabla(tablaCAT20);
                }
            }
            if (listaCAT21.Count != 0)
            {
                for (int k = 0; k < listaCAT21.Count; k++)
                {
                    tablaCAT21 = listaCAT21[k].actualizarTabla(tablaCAT21);
                }
            }

        }

        public DataTable getTablaCAT10()
        {
            return tablaCAT10;
        }
        public DataTable getTablaCAT20()
        {
            return tablaCAT20;
        }
        public DataTable getTablaCAT21()
        {
            return tablaCAT21;
        }

        public List<CAT10> getListCAT10()
        {
            return listaCAT10;
        }
        public List<CAT20> getListCAT20()
        {
            return listaCAT20;
        }
        public List<CAT21> getListCAT21()
        {
            return listaCAT21;
        }
    }
}
