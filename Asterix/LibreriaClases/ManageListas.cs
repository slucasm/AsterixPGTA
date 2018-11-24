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

        DataTable tablaSingle = new DataTable();

        List<Flight> listFlights = new List<Flight>();

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
            tablaCAT10.Columns.Add("Coordinates", typeof(string));
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
            tablaCAT20.Columns.Add("Time", typeof(TimeSpan));
            tablaCAT20.Columns.Add("X", typeof(double));
            tablaCAT20.Columns.Add("Y", typeof(double));
            tablaCAT20.Columns.Add("Coordinates", typeof(string));
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
            tablaCAT21.Columns.Add("Coordinates", typeof(string));
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


        public void singleList()
        {
            if (listaCAT10.Count != 0 && listaCAT21.Count != 0)
            {
                int x = 0;
                int z = 0;
                while (true)
                {
                    if (listaCAT10[x].myTime < listaCAT21[z].myTime)
                    {
                        this.listFlights.Add(new Flight(listaCAT10[x].CAT,listaCAT10[x].ACID_palabra,listaCAT10[x].ADDRESS,listaCAT10[x].myTime,listaCAT10[x].coordinates,listaCAT10[x].X,listaCAT10[x].Y,x,listaCAT10[x].punto));
                        x++;
                    }
                    else
                    {
                        this.listFlights.Add(new Flight(listaCAT21[z].CAT, listaCAT21[z].ACID_palabra, listaCAT21[z].ADDRESS, listaCAT21[z].myTime, listaCAT21[z].coordinates, listaCAT21[z].latitud, listaCAT21[z].longitud, z,listaCAT21[z].punto));
                        z++;                   
                    }
                    if (x == listaCAT10.Count)
                    {
                        for (int i = x;  i < listaCAT10.Count; i++)
                        {
                            this.listFlights.Add(new Flight(listaCAT10[i].CAT, listaCAT10[i].ACID_palabra, listaCAT10[i].ADDRESS, listaCAT10[i].myTime, listaCAT10[i].coordinates, listaCAT10[i].X, listaCAT10[i].Y, i,listaCAT10[i].punto));
                        }
                        break;
                    }

                    if (z == listaCAT21.Count)
                    {
                        for (int y = z; y < listaCAT21.Count; y++)
                        {
                            this.listFlights.Add(new Flight(listaCAT21[y].CAT, listaCAT21[y].ACID_palabra, listaCAT21[y].ADDRESS, listaCAT21[y].myTime, listaCAT21[y].coordinates, listaCAT21[y].latitud, listaCAT21[y].longitud, y,listaCAT21[y].punto));
                        }
                        break;
                    }
                }
            }

            else if (listaCAT10.Count != 0)
            {
                for (int a = 0; a < listaCAT10.Count; a++)
                {
                    this.listFlights.Add(new Flight(listaCAT10[a].CAT, listaCAT10[a].ACID_palabra, listaCAT10[a].ADDRESS, listaCAT10[a].myTime, listaCAT10[a].coordinates, listaCAT10[a].X, listaCAT10[a].Y, a,listaCAT10[a].punto));
                }
            }
            else if (listaCAT20.Count != 0)
            {
                for (int a = 0; a < listaCAT20.Count; a++)
                {
                    this.listFlights.Add(new Flight(listaCAT20[a].CAT, listaCAT20[a].ACID_palabra, listaCAT20[a].ADDRESS, listaCAT20[a].myTime, listaCAT20[a].coordinates, listaCAT20[a].X, listaCAT20[a].Y, a,listaCAT20[a].punto));
                }
            }
            else if (listaCAT21.Count != 0)
            {
                for (int a = 0; a < listaCAT21.Count; a++)
                {
                    this.listFlights.Add(new Flight(listaCAT21[a].CAT, listaCAT21[a].ACID_palabra, listaCAT21[a].ADDRESS, listaCAT21[a].myTime, listaCAT21[a].coordinates, listaCAT21[a].latitud, listaCAT21[a].longitud, a,listaCAT21[a].punto));
                }
            }
        }

        public List<Flight> getSingleList()
        {
            return this.listFlights;
        }

        public DataTable createSingleTable()
        {
            tablaSingle.Columns.Add("#", typeof(int));
            tablaSingle.Columns.Add("CAT", typeof(int));
            tablaSingle.Columns.Add("ACID", typeof(string));
            tablaSingle.Columns.Add("Time", typeof(TimeSpan));
            tablaSingle.Columns.Add("Coordinates", typeof(string));
            tablaSingle.Columns.Add("Real index", typeof(int));

            for (int i = 0; i < listFlights.Count; i++)
            {
                listFlights[i].actualizarTabla(tablaSingle, i);
            }
            return tablaSingle;
        }
    }
}
