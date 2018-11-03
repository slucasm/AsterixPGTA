using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaClases
{
    class ManageListas
    {
        List<CAT10> listaCAT10 = new List<CAT10>();
        List<CAT20> listaCAT20 = new List<CAT20>();
        List<CAT21> listaCAT21 = new List<CAT21>();

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
    }
}
