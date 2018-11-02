using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaClases
{
    public class CAT10
    {
        string[] stringhex;
        int[] arraydec;
        string[] stringbinary;
        List<Boolean> listboolean_fspec = new List<Boolean>();
        Boolean DI_000,DI_010, DI_020, DI_040,DI_041, DI_042, DI_060, DI_090, DI_091, DI_131, DI_140, DI_161, DI_170, DI_200, DI_202, DI_210, DI_220, DI_245, DI_250, DI_270, DI_280, DI_300, DI_310, DI_500, DI_550;

        string DI_010_buffer1, DI_010_buffer2, DI_000_buffer1, DI_020_buffer1, DI_020_buffer2, DI_140_buffer1, DI_140_buffer2, DI_140_buffer3, DI_041_buffer1, DI_041_buffer2, DI_041_buffer3, DI_041_buffer4, DI_041_buffer5, DI_041_buffer6, DI_041_buffer7, DI_041_buffer8, DI_040_buffer1, DI_040_buffer2, DI_040_buffer3, DI_040_buffer4, DI_042_buffer1, DI_042_buffer2, DI_042_buffer3, DI_042_buffer4, DI_200_buffer1, DI_200_buffer2, DI_200_buffer3, DI_200_buffer4, DI_202_buffer1, DI_202_buffer2, DI_202_buffer3, DI_202_buffer4, DI_161_buffer1, DI_161_buffer2, DI_170_buffer1, DI_170_buffer2, DI_060_buffer1, DI_060_buffer2, DI_220_buffer1, DI_220_buffer2, DI_220_buffer3, DI_245_buffer1, DI_245_buffer2, DI_245_buffer3, DI_245_buffer4, DI_245_buffer5, DI_245_buffer6, DI_245_buffer7, DI_250_buffer1, DI_300_buffer1, DI_090_buffer1, DI_090_buffer2, DI_091_buffer1, DI_091_buffer2, DI_270_buffer1, DI_270_buffer2, DI_550_buffer1, DI_310_buffer1, DI_500_buffer1, DI_500_buffer2, DI_500_buffer3, DI_500_buffer4, DI_280_buffer1, DI_131_buffer1, DI_210_buffer1, DI_210_buffer2;


        public CAT10(string[] stringhex)
        {
            this.stringhex = stringhex;
        }

        public void hex2binary()
        {
            arraydec = new int[stringhex.Length];
            for (int i = 0; i < stringhex.Length; i++)
            {
                arraydec[i] = int.Parse(stringhex[i], System.Globalization.NumberStyles.HexNumber);
            }
            stringbinary = new string[stringhex.Length];
            for (int i = 0; i < stringhex.Length; i++)
            {
                stringbinary[i] = Convert.ToString(arraydec[i], 2);
                int length = stringbinary[i].Length;
                if (length == 1)
                {
                    string conc = "0000000";
                    stringbinary[i] = String.Concat(conc, stringbinary[i]);
                }
                else if (length == 2)
                {
                    string conc = "000000";
                    stringbinary[i] = String.Concat(conc, stringbinary[i]);
                }
                else if (length == 3)
                {
                    string conc = "00000";
                    stringbinary[i] = String.Concat(conc, stringbinary[i]);
                }
                else if (length == 4)
                {
                    string conc = "0000";
                    stringbinary[i] = String.Concat(conc, stringbinary[i]);
                }
                else if (length == 5)
                {
                    string conc = "000";
                    stringbinary[i] = String.Concat(conc, stringbinary[i]);
                }
                else if (length == 6)
                {
                    string conc = "00";
                    stringbinary[i] = String.Concat(conc, stringbinary[i]);
                }
                else if (length == 7)
                {
                    string conc = "0";
                    stringbinary[i] = String.Concat(conc, stringbinary[i]);
                }
            }
        }

        public void fspec()
        {
            for (int i = 3; i < stringbinary.Length; i++)
            {
                char[] fspec_provisional = stringbinary[i].ToArray();

                for (int j = 0; j < fspec_provisional.Length; j++)
                {
                    if (Convert.ToInt32(fspec_provisional[j]) == '1')
                    {
                        Boolean b = true;
                        listboolean_fspec.Add(b);
                    }
                    else
                    {
                        Boolean b = false;
                        listboolean_fspec.Add(b);
                    }

                }
                if (Convert.ToInt32(fspec_provisional[7]) == '0')
                {
                    i = stringbinary.Length + 1;
                }
            }
        }

        public void comprobar_fspec()
        {
            int count = listboolean_fspec.Count;
            if (count > 1)
            {
                if (listboolean_fspec[0] == true)
                {
                    DI_010 = true;
                }
                if (listboolean_fspec[1] == true)
                {
                    DI_000 = true;
                }
                if (listboolean_fspec[2] == true)
                {
                    DI_020 = true;
                }
                if (listboolean_fspec[3] == true)
                {
                    DI_140 = true;
                }
                if (listboolean_fspec[4] == true)
                {
                    DI_041 = true;
                }
                if (listboolean_fspec[5] == true)
                {
                    DI_040 = true;
                }
                if (listboolean_fspec[6] == true)
                {
                    DI_042 = true;
                }


            }
            if (count > 8)
            {
                if (listboolean_fspec[8] == true)
                {
                    DI_200 = true;
                }
                if (listboolean_fspec[9] == true)
                {
                    DI_202 = true;
                }
                if (listboolean_fspec[10] == true)
                {
                    DI_161 = true;
                }
                if (listboolean_fspec[11] == true)
                {
                    DI_170 = true;
                }
                if (listboolean_fspec[12] == true)
                {
                    DI_060 = true;
                }
                if (listboolean_fspec[13] == true)
                {
                    DI_220 = true;
                }
                if (listboolean_fspec[14] == true)
                {
                    DI_245 = true;
                }

            }
            if (count > 16)
            {
                if (listboolean_fspec[16] == true)
                {
                    DI_250 = true;
                }
                if (listboolean_fspec[17] == true)
                {
                    DI_300 = true;
                }
                if (listboolean_fspec[18] == true)
                {
                    DI_090 = true;
                }
                if (listboolean_fspec[19] == true)
                {
                    DI_091 = true;
                }
                if (listboolean_fspec[20] == true)
                {
                    DI_270 = true;
                }
                if (listboolean_fspec[21] == true)
                {
                    DI_550 = true;
                }
                if (listboolean_fspec[22] == true)
                {
                    DI_310 = true;
                }

            }
            if (count > 24)
            {
                if (listboolean_fspec[24] == true)
                {
                    DI_500 = true;
                }
                if (listboolean_fspec[25] == true)
                {
                    DI_280 = true;
                }
                if (listboolean_fspec[26] == true)
                {
                    DI_131 = true;
                }
                if (listboolean_fspec[27] == true)
                {
                    DI_210 = true;
                }
            }
        }


        public void resolver_dataitems()
        {
            int count = 0;
            if (listboolean_fspec.Count == 8)
            {
                count = 1;
            }
            else if (listboolean_fspec.Count == 16)
            {
                count = 2;
            }
            else if (listboolean_fspec.Count == 24)
            {
                count = 3;
            }
            else if (listboolean_fspec.Count == 32)
            {
                count = 4;
            }
            else if (listboolean_fspec.Count == 40)
            {
                count = 5;
            }
            else if (listboolean_fspec.Count == 48)
            {
                count = 6;
            }

            for (int i = (3 + count); i < stringbinary.Length; i++)
            {

                if (DI_010 == true) //VERDADERO
                {
                    DI_010_buffer1 = stringbinary[i];
                    i++;
                    DI_010_buffer2 = stringbinary[i];
                    DI_010 = false;

                    //SAC = Convert.ToInt32(DI_010_buffer1, 2);
                    //SIC = Convert.ToInt32(DI_010_buffer2, 2);
                }
                else if (DI_000 == true)//VERDADERO
                {
                    DI_000_buffer1 = stringbinary[i];
                    DI_000 = false;
                }
                else if (DI_020 == true)//VERDADERO
                {
                    DI_020_buffer1 = stringbinary[i];
                    char[] prov = DI_020_buffer1.ToArray();
                    if (prov[prov.Length - 1] == 1)
                    {
                        i++;
                        DI_020_buffer2 = stringbinary[i];
                    }
                    DI_020 = false;

                }
                else if (DI_140 == true)//VERDADERO
                {
                    DI_140_buffer1 = stringbinary[i];
                    i++;
                    DI_140_buffer2 = stringbinary[i]; 
                    i++;
                    DI_140_buffer3 = stringbinary[i];
                    DI_140 = false;
                }
                else if (DI_041 == true)
                {
                    DI_041_buffer1 = stringbinary[i];
                    i++;
                    DI_041_buffer2 = stringbinary[i];
                    i++;
                    DI_041_buffer3 = stringbinary[i];
                    i++;
                    DI_041_buffer4 = stringbinary[i];
                    i++;
                    DI_041_buffer5 = stringbinary[i];
                    i++;
                    DI_041_buffer6 = stringbinary[i];
                    i++;
                    DI_041_buffer7 = stringbinary[i];
                    i++;
                    DI_041_buffer8 = stringbinary[i];
                    DI_041 = false;
                }
                else if (DI_040 == true)//VERDADERO
                {
                    DI_040_buffer1 = stringbinary[i];
                    i++;
                    DI_040_buffer2 = stringbinary[i];
                    i++;
                    DI_040_buffer3 = stringbinary[i];
                    i++;
                    DI_040_buffer4 = stringbinary[i];
                    DI_040 = false;
                }
                else if (DI_042 == true)//VERDADERO
                {
                    DI_042_buffer1 = stringbinary[i];
                    i++;
                    DI_042_buffer2 = stringbinary[i];
                    i++;
                    DI_042_buffer3 = stringbinary[i];
                    i++;
                    DI_042_buffer4 = stringbinary[i];
                    DI_042 = false;

                }
                else if (DI_200 == true)//VERDADERO
                {
                    DI_200_buffer1 = stringbinary[i];
                    i++;
                    DI_200_buffer2 = stringbinary[i];
                    i++;
                    DI_200_buffer3 = stringbinary[i];
                    i++;
                    DI_200_buffer4 = stringbinary[i];
                    DI_200 = false;

                }
                else if (DI_202 == true)//VERDADERO
                {
                    DI_202_buffer1 = stringbinary[i];
                    i++;
                    DI_202_buffer2 = stringbinary[i];
                    i++;
                    DI_202_buffer3 = stringbinary[i];
                    i++;
                    DI_202_buffer4 = stringbinary[i];
                    DI_202 = false;
                }
                else if (DI_161 == true)//VERDADERO
                {
                    DI_161_buffer1 = stringbinary[i];
                    i++;
                    DI_161_buffer2 = stringbinary[i];
                    DI_161 = false;
                }
                else if (DI_170 == true)//VERDADERO
                {
                    DI_170_buffer1 = stringbinary[i];
                    char[] prov = DI_170_buffer1.ToArray();
                    if (prov[prov.Length - 1] == 1)
                    {
                        i++;
                        DI_170_buffer2 = stringbinary[i];
                    }
                    DI_170 = false;
                }
                else if (DI_060 == true)//VERDADERO
                {

                    DI_060_buffer1 = stringbinary[i];
                    i++;
                    DI_060_buffer2 = stringbinary[i];
                    DI_060 = false;
                }
                else if (DI_220 == true)//VERDADERO
                {
                    DI_220_buffer1 = stringbinary[i];
                    i++;
                    DI_220_buffer2 = stringbinary[i];
                    i++;
                    DI_220_buffer3 = stringbinary[i];
                    i++;
                    DI_220 = false;
                }
                else if (DI_245 == true)//VERDADERO
                {
                    DI_245_buffer1 = stringbinary[i];
                    i++;
                    DI_245_buffer2 = stringbinary[i];
                    i++;
                    DI_245_buffer3 = stringbinary[i];
                    i++;
                    DI_245_buffer4 = stringbinary[i];
                    i++;
                    DI_245_buffer5 = stringbinary[i];
                    i++;
                    DI_245_buffer6 = stringbinary[i];
                    i++;
                    DI_245_buffer7 = stringbinary[i];
                    DI_245 = false;
                }
                else if (DI_250 == true)
                {
                    DI_250_buffer1 = stringbinary[i];
                    DI_250 = false;
                }
                else if (DI_300 == true)
                {
                    DI_300_buffer1 = stringbinary[i];
                    DI_300 = false;
                }
                else if (DI_090 == true)//VERDADERO
                {
                    DI_090_buffer1 = stringbinary[i];
                    i++;
                    DI_090_buffer2 = stringbinary[i];
                    DI_090 = false;
                }
                else if (DI_091 == true)
                {
                    DI_091_buffer1 = stringbinary[i];
                    i++;
                    DI_091_buffer2 = stringbinary[i];
                    DI_091 = false;
                }
                else if (DI_270 == true)//VERDADERO
                {
                    DI_270_buffer1 = stringbinary[i];
                    char[] prov = DI_270_buffer1.ToArray();
                    if (prov[prov.Length - 1] == 1)
                    {
                        i++;
                        DI_270_buffer2 = stringbinary[i];
                    }
                    DI_270 = false;
                }
                else if (DI_550 == true)
                {
                    DI_550_buffer1 = stringbinary[i];
                    DI_550 = false;
                }
                else if (DI_310 == true)
                {
                    DI_310_buffer1 = stringbinary[i];
                    DI_310 = false;
                }
                else if (DI_500 == true)
                {
                    DI_500_buffer1 = stringbinary[i];
                    i++;
                    DI_500_buffer2 = stringbinary[i];
                    i++;
                    DI_500_buffer3 = stringbinary[i];
                    i++;
                    DI_500_buffer4 = stringbinary[i];
                    DI_550 = false;
                }
                else if (DI_280 == true)
                {
                    DI_280_buffer1 = stringbinary[i];
                    DI_280 = false;
                }
                else if (DI_131 == true)
                {
                    DI_131_buffer1 = stringbinary[i];
                    DI_131 = false;
                }
                else if (DI_210 == true)
                {
                    DI_210_buffer1 = stringbinary[i];
                    i++;
                    DI_210_buffer2 = stringbinary[i];
                    DI_210 = false;
                }
            }
        }
    }
}
