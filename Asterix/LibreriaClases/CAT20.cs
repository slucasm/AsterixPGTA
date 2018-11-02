using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaClases
{
    public class CAT20
    {
        string[] stringhex;
        int[] arraydec;
        string[] stringbinary;
        List<Boolean> listboolean_fspec = new List<Boolean>();
        Boolean DI_010, DI_020, DI_030, DI_041, DI_042, DI_050, DI_055, DI_070, DI_090, DI_100, DI_105, DI_110, DI_140, DI_161, DI_170, DI_202, DI_210, DI_220, DI_230, DI_245, DI_250, DI_260, DI_300, DI_310, DI_400, DI_500;

        string DI_010_buffer1, DI_010_buffer2, DI_020_buffer1, DI_020_buffer2, DI_140_buffer1, DI_140_buffer2, DI_140_buffer3, DI_041_buffer1, DI_041_buffer2, DI_041_buffer3, DI_041_buffer4, DI_041_buffer5, DI_041_buffer6, DI_041_buffer7, DI_041_buffer8, DI_042_buffer1, DI_042_buffer2, DI_042_buffer3, DI_042_buffer4, DI_042_buffer5, DI_042_buffer6, DI_161_buffer1, DI_161_buffer2, DI_170_buffer1, DI_170_buffer2, DI_070_buffer1, DI_070_buffer2, DI_202_buffer1, DI_202_buffer2, DI_202_buffer3, DI_202_buffer4, DI_090_buffer1, DI_090_buffer2, DI_100_buffer1, DI_100_buffer2, DI_100_buffer3, DI_100_buffer4, DI_220_buffer1, DI_220_buffer2, DI_220_buffer3, DI_245_buffer1, DI_245_buffer2, DI_245_buffer3, DI_245_buffer4, DI_245_buffer5, DI_245_buffer6, DI_245_buffer7, DI_110_buffer1, DI_110_buffer2, DI_105_buffer1, DI_105_buffer2, DI_210_buffer1, DI_210_buffer2, DI_300_buffer1, DI_310_buffer1, DI_500_buffer1, DI_400_buffer1, DI_250_buffer1, DI_230_buffer1, DI_230_buffer2, DI_260_buffer1, DI_260_buffer2, DI_260_buffer3, DI_260_buffer4, DI_260_buffer5, DI_260_buffer6, DI_260_buffer7, DI_030_buffer1, DI_030_buffer2,DI_055_buffer1, DI_050_buffer1, DI_050_buffer2;

        public CAT20(string[] stringhex)
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
                    DI_020 = true;
                }
                if (listboolean_fspec[2] == true)
                {
                    DI_140 = true;
                }
                if (listboolean_fspec[3] == true)
                {
                    DI_041 = true;
                }
                if (listboolean_fspec[4] == true)
                {
                    DI_042 = true;
                }
                if (listboolean_fspec[5] == true)
                {
                    DI_161 = true;
                }
                if (listboolean_fspec[6] == true)
                {
                    DI_170 = true;
                }


            }
            if (count > 8)
            {
                if (listboolean_fspec[8] == true)
                {
                    DI_070 = true;
                }
                if (listboolean_fspec[9] == true)
                {
                    DI_202 = true;
                }
                if (listboolean_fspec[10] == true)
                {
                    DI_090 = true;
                }
                if (listboolean_fspec[11] == true)
                {
                    DI_100 = true;
                }
                if (listboolean_fspec[12] == true)
                {
                    DI_220 = true;
                }
                if (listboolean_fspec[13] == true)
                {
                    DI_245 = true;
                }
                if (listboolean_fspec[14] == true)
                {
                    DI_110 = true;
                }

            }
            if (count > 16)
            {
                if (listboolean_fspec[16] == true)
                {
                    DI_105 = true;
                }
                if (listboolean_fspec[17] == true)
                {
                    DI_210 = true;
                }
                if (listboolean_fspec[18] == true)
                {
                    DI_300 = true;
                }
                if (listboolean_fspec[19] == true)
                {
                    DI_310 = true;
                }
                if (listboolean_fspec[20] == true)
                {
                    DI_500 = true;
                }
                if (listboolean_fspec[21] == true)
                {
                    DI_400 = true;
                }
                if (listboolean_fspec[22] == true)
                {
                    DI_250 = true;
                }

            }
            if (count > 24)
            {
                if (listboolean_fspec[24] == true)
                {
                    DI_230 = true;
                }
                if (listboolean_fspec[25] == true)
                {
                    DI_260 = true;
                }
                if (listboolean_fspec[26] == true)
                {
                    DI_030 = true;
                }
                if (listboolean_fspec[27] == true)
                {
                    DI_055 = true;
                }
                if (listboolean_fspec[28] == true)
                {
                    DI_050 = true;
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
                else if (DI_042 == true)//VERDADERO
                {
                    DI_042_buffer1 = stringbinary[i];
                    i++;
                    DI_042_buffer2 = stringbinary[i];
                    i++;
                    DI_042_buffer3 = stringbinary[i];
                    i++;
                    DI_042_buffer4 = stringbinary[i];
                    i++;
                    DI_042_buffer5 = stringbinary[i];
                    i++;
                    DI_042_buffer6 = stringbinary[i];
                    DI_042 = false;
                }
                else if (DI_161 == true)//VERDADERO
                {
                    DI_161_buffer1 = stringbinary[i];
                    i++;
                    DI_161_buffer2 = stringbinary[i];
                    DI_140 = false;
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
                else if (DI_070 == true)//VERDADERO
                {
                    DI_070_buffer1 = stringbinary[i];
                    i++;
                    DI_070_buffer2 = stringbinary[i];
                    DI_070 = false;

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
                else if (DI_090 == true)//VERDADERO
                {
                    DI_090_buffer1 = stringbinary[i];
                    i++;
                    DI_090_buffer2 = stringbinary[i];
                    DI_090 = false;
                }
                else if (DI_100 == true)
                {
                    DI_100_buffer1 = stringbinary[i];
                    i++;
                    DI_100_buffer2 = stringbinary[i];
                    i++;
                    DI_100_buffer3 = stringbinary[i];
                    i++;
                    DI_100_buffer4 = stringbinary[i];
                    DI_100 = false;
                }
                else if (DI_220 == true)//VERDADERO
                {

                    DI_220_buffer1 = stringbinary[i];
                    i++;
                    DI_220_buffer2 = stringbinary[i];
                    i++;
                    DI_220_buffer3 = stringbinary[i];
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
                else if (DI_110 == true)
                {
                    DI_110_buffer1 = stringbinary[i];
                    i++;
                    DI_110_buffer2 = stringbinary[i];
                    DI_110 = false;
                }
                else if (DI_105 == true)
                {
                    DI_105_buffer1 = stringbinary[i];
                    i++;
                    DI_105_buffer2 = stringbinary[i];
                    DI_105 = false;
                }
                else if (DI_210 == true)
                {
                    DI_210_buffer1 = stringbinary[i];
                    i++;
                    DI_210_buffer2 = stringbinary[i];
                    DI_210 = false;
                }
                else if (DI_300 == true)
                {
                    DI_300_buffer1 = stringbinary[i];
                    DI_300 = false;
                }
                else if (DI_310 == true)
                {
                    DI_310_buffer1 = stringbinary[i];
                    DI_310 = false;
                }
                else if (DI_500 == true)//VERDADERO
                {
                    DI_500_buffer1 = stringbinary[i];
                    DI_500 = false;
                }
                else if (DI_400 == true)//VERDADERO
                {
                    DI_400_buffer1 = stringbinary[i];
                    DI_400 = false;
                }
                else if (DI_250 == true)
                {
                    DI_250_buffer1 = stringbinary[i];
                    DI_250 = false;

                }
                else if (DI_230 == true)
                {
                    DI_230_buffer1 = stringbinary[i];
                    i++;
                    DI_230_buffer2 = stringbinary[i];
                    DI_230 = false;
                }
                else if (DI_260 == true)
                {
                    DI_260_buffer1 = stringbinary[i];
                    i++;
                    DI_260_buffer2 = stringbinary[i];
                    i++;
                    DI_260_buffer3 = stringbinary[i];
                    i++;
                    DI_260_buffer4 = stringbinary[i];
                    i++;
                    DI_260_buffer5 = stringbinary[i];
                    i++;
                    DI_260_buffer6 = stringbinary[i];
                    i++;
                    DI_260_buffer7 = stringbinary[i];
                    DI_260 = false;
                }
                else if (DI_030 == true)
                {
                    DI_030_buffer1 = stringbinary[i];
                    char[] prov = DI_030_buffer1.ToArray();
                    if (prov[prov.Length - 1] == 1)
                    {
                        i++;
                        DI_030_buffer2 = stringbinary[i];
                    }
                    DI_030 = false;
                }
                else if (DI_055 == true)
                {
                    DI_055_buffer1 = stringbinary[i];
                    DI_055 = false;
                }
                else if (DI_050 == true)
                {
                    DI_050_buffer1 = stringbinary[i];
                    i++;
                    DI_050_buffer2 = stringbinary[i];
                    DI_050 = false;
                }
            }
        }


    }
}
