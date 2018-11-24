using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LibreriaClases
{
    public class Flight
    {

        public Flight(int CAT,string ACID,string ADDRESS,TimeSpan time,string coordinates,double lat, double lon,int realindex)
        {
            this.CAT = CAT;
            this.ACID = ACID;
            this.ADDRESS = ADDRESS;
            this.time = time;
            this.coordinates = coordinates;
            this.lat = lat;
            this.lon = lon;
            this.realindex = realindex;
        }

        public int CAT, realindex;
        public string ACID, ADDRESS, coordinates;
        public double lat, lon;
        public TimeSpan time;
        public List<String> listacoordenadas;

        public DataTable actualizarTabla(DataTable dt,int i)
        {
            dt.Rows.Add(i,CAT,ACID,time,coordinates,realindex);
            return dt;
        }
    }
}
