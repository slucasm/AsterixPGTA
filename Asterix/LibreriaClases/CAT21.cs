using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LibreriaClases
{
    public class CAT21
    {
        string[] stringhex;
        int[] arraydec;
        string[] stringbinary;
        List<Boolean> listboolean_fspec = new List<Boolean>();
        Boolean DI_010,DI_020,DI_030,DI_032, DI_040, DI_080, DI_090,DI_095, DI_110, DI_130, DI_140, DI_145, DI_146, DI_148, DI_150, DI_151, DI_152, DI_155, DI_157, DI_160,DI_165, DI_170, DI_200, DI_210, DI_220,DI_230;

        string DI_010_buffer1, DI_010_buffer2, DI_040_buffer1,DI_040_buffer2, DI_030_buffer1, DI_030_buffer2, DI_030_buffer3, DI_130_buffer1, DI_130_buffer2, DI_130_buffer3, DI_130_buffer4, DI_130_buffer5, DI_130_buffer6, DI_080_buffer1, DI_080_buffer2,DI_080_buffer3, DI_140_buffer1, DI_140_buffer2, DI_090_buffer1, DI_090_buffer2, DI_210_buffer1, DI_230_buffer1, DI_230_buffer2, DI_145_buffer1, DI_145_buffer2, DI_150_buffer1, DI_150_buffer2, DI_151_buffer1, DI_151_buffer2, DI_152_buffer1, DI_152_buffer2, DI_155_buffer1, DI_155_buffer2, DI_157_buffer1, DI_157_buffer2, DI_160_buffer1, DI_160_buffer2, DI_160_buffer3, DI_160_buffer4, DI_165_buffer1,DI_165_buffer2,DI_170_buffer1,DI_170_buffer2,DI_170_buffer3,DI_170_buffer4,DI_170_buffer5,DI_170_buffer6, DI_095_buffer1, DI_032_buffer1, DI_200_buffer1, DI_020_buffer1, DI_220_buffer1, DI_220_buffer2, DI_146_buffer1, DI_146_buffer2, DI_148_buffer1, DI_148_buffer2;

        int SAC, SIC;
        string TARGET;
        string Time;
        string ADDRESS;
        string FOM_AC, FOM_MN, FOM_DC, FOM_PA;
        string LINK;
        string LEVEL;
        string VR;
        string SPD, AGL;
        string ACID_palabra;
        string VA;
        double latitud, longitud;

        int CAT;

        TimeSpan myTime;

        string coordinates;

        public int getCAT()
        {
            return CAT;
        }
        public string getADDRESS()
        {
            return this.ADDRESS;
        }
        public string getACID()
        {
            return this.ACID_palabra;
        }
        public TimeSpan getTime()
        {
            return this.myTime;
        }

        public CAT21(string[] stringhex)
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
                    DI_040 = true;
                }
                if (listboolean_fspec[2] == true)
                {
                    DI_030 = true;
                }
                if (listboolean_fspec[3] == true)
                {
                    DI_130 = true;
                }
                if (listboolean_fspec[4] == true)
                {
                    DI_080 = true;
                }
                if (listboolean_fspec[5] == true)
                {
                    DI_140 = true;
                }
                if (listboolean_fspec[6] == true)
                {
                    DI_090 = true;
                }


            }
            if (count > 8)
            {
                if (listboolean_fspec[8] == true)
                {
                    DI_210 = true;
                }
                if (listboolean_fspec[9] == true)
                {
                    DI_230 = true;
                }
                if (listboolean_fspec[10] == true)
                {
                    DI_145 = true;
                }
                if (listboolean_fspec[11] == true)
                {
                    DI_150 = true;
                }
                if (listboolean_fspec[12] == true)
                {
                    DI_151 = true;
                }
                if (listboolean_fspec[13] == true)
                {
                    DI_152 = true;
                }
                if (listboolean_fspec[14] == true)
                {
                    DI_155 = true;
                }

            }
            if (count > 16)
            {
                if (listboolean_fspec[16] == true)
                {
                    DI_157 = true;
                }
                if (listboolean_fspec[17] == true)
                {
                    DI_160 = true;
                }
                if (listboolean_fspec[18] == true)
                {
                    DI_165 = true;
                }
                if (listboolean_fspec[19] == true)
                {
                    DI_170 = true;
                }
                if (listboolean_fspec[20] == true)
                {
                    DI_095 = true;
                }
                if (listboolean_fspec[21] == true)
                {
                    DI_032 = true;
                }
                if (listboolean_fspec[22] == true)
                {
                    DI_200 = true;
                }

            }
            if (count > 24)
            {
                if (listboolean_fspec[24] == true)
                {
                    DI_020 = true;
                }
                if (listboolean_fspec[25] == true)
                {
                    DI_220 = true;
                }
                if (listboolean_fspec[26] == true)
                {
                    DI_146 = true;
                }
                if (listboolean_fspec[27] == true)
                {
                    DI_148 = true;
                }
                if (listboolean_fspec[28] == true)
                {
                    DI_110 = true;
                }
            }
        }

        public void resolver_dataitems()
        {
            CAT = Convert.ToInt32(stringbinary[0], 2);
            int count = 0;
            if (listboolean_fspec.Count == 8)
            {
                count = 1;
            }
            else if(listboolean_fspec.Count == 16)
            {
                count = 2;
            }
            else if(listboolean_fspec.Count == 24)
            {
                count = 3;
            }
            else if(listboolean_fspec.Count == 32)
            {
                count = 4;
            }
            else if(listboolean_fspec.Count == 40)
            {
                count = 5;
            }
            else if(listboolean_fspec.Count == 48)
            {
                count = 6;
            }

            for (int i = (3 + count); i < stringbinary.Length; i++)
            {

                if (DI_010 == true)//VERDADERO
                {
                    DI_010_buffer1 = stringbinary[i];
                    i++;
                    DI_010_buffer2 = stringbinary[i];
                    DI_010 = false;

                    SAC = Convert.ToInt32(DI_010_buffer1, 2);
                    SIC = Convert.ToInt32(DI_010_buffer2, 2);
                }
                else if (DI_040 == true)//VERDADERO
                {
                    DI_040_buffer1 = stringbinary[i];
                    i++;
                    DI_040_buffer2 = stringbinary[i];
                    DI_040 = false;

                    char[] buff1 = DI_040_buffer1.ToArray();
                    if (buff1[0] == '1')
                    {
                        TARGET = "DCR";
                    }
                    else if (buff1[1] == '1')
                    {
                        TARGET = "GBS";
                    }
                    else if (buff1[2] == '1')
                    {
                        TARGET = "SIM";
                    }
                    else if (buff1[3] == '1')
                    {
                        TARGET = "TST";
                    }
                    else if (buff1[4] == '1')
                    {
                        TARGET = "RAB";
                    }
                    else if (buff1[5] == '1')
                    {
                        TARGET = "SAA";
                    }
                    else if (buff1[6] == '1')
                    {
                        TARGET = "SPI";
                    }
                    else
                    {
                        TARGET = "NORMAL";
                    }

                }
                else if (DI_030 == true)//VERDADERO
                {
                    DI_030_buffer1 = stringbinary[i];
                    i++;
                    DI_030_buffer2 = stringbinary[i];
                    i++;
                    DI_030_buffer3 = stringbinary[i];
                    DI_030 = false;

                    
                    int DI_030_bff = Convert.ToInt32(String.Concat(DI_030_buffer1, DI_030_buffer2, DI_030_buffer3),2);
                    double seconds = Math.Round(Convert.ToDouble(DI_030_bff) / 128, 3);
                    myTime = TimeSpan.FromSeconds(seconds);
                    //Time = time.ToString(@"hh\:mm\:ss\.fff");


                }
                else if (DI_130 == true)//VERDADERO
                {
                    DI_130_buffer1 = stringbinary[i];
                    i++;
                    DI_130_buffer2 = stringbinary[i];
                    i++;
                    DI_130_buffer3 = stringbinary[i];
                    i++;
                    DI_130_buffer4 = stringbinary[i];
                    i++;
                    DI_130_buffer5 = stringbinary[i];
                    i++;
                    DI_130_buffer6 = stringbinary[i];
                    DI_130 = false;

                    string lat = String.Concat(DI_130_buffer1, DI_130_buffer2, DI_130_buffer3);
                    string lon = String.Concat(DI_130_buffer4,DI_130_buffer5,DI_130_buffer6);

                    latitud = CA2todec(lat)*(2.145767 * Math.Pow(10,-5));
                    longitud = CA2todec(lon) * (2.145767 * Math.Pow(10, -5));

                    string[] separados1lat;
                    string[] separados1lon;

                    separados1lat = Convert.ToString(latitud).Split(',');
                    separados1lon = Convert.ToString(longitud).Split(',');
                    string gradoslat = separados1lat[0];
                    string gradoslon = separados1lon[0];
                    string uno = String.Concat("0,", separados1lat[1]);
                    string dos = String.Concat("0,", separados1lon[1]);
                    double mindeclat = Convert.ToDouble(uno) * 60;
                    double mindeclon = Convert.ToDouble(dos) * 60;
                    string[] separados2lat = Convert.ToString(mindeclat).Split(',');
                    string[] separados2lon = Convert.ToString(mindeclon).Split(',');
                    string minlat = separados2lat[0];
                    string minlon = separados2lon[0];
                    double segdeclat = Convert.ToDouble(String.Concat("0.",separados2lat[1])) * 60;
                    double segdeclon = Convert.ToDouble(String.Concat("0.",separados2lon[1])) * 60;
                    string seclat = Convert.ToString(Math.Round(segdeclat,3));
                    string seclon = Convert.ToString(Math.Round(segdeclon, 3));
                    string latitudd, longitudd;
                    if (latitud > 0)
                    { latitudd = String.Concat(gradoslat,"º", minlat,"'", seclat,"''", 'N'); }
                    else
                    { latitudd = String.Concat(gradoslat, 'º', minlat, "'", seclat, "''", 'S'); }
                    if (longitud > 0)
                    { longitudd = String.Concat(gradoslon,'º', minlon,"'", seclon,"''", 'E'); }
                    else
                    { longitudd = String.Concat(gradoslon, 'º', minlon, "'", seclon, "''", 'O'); }

                    coordinates = String.Concat(latitudd, longitudd);


                }
                else if (DI_080 == true)//VERDADERO
                {
                    DI_080_buffer1 = stringbinary[i];
                    i++;
                    DI_080_buffer2 = stringbinary[i];
                    i++;
                    DI_080_buffer3 = stringbinary[i];
                    DI_080 = false;
                    if (stringhex[i].Count() == 1) { stringhex[i] = String.Concat("0", stringhex[i]); }
                    if (stringhex[i - 1].Count() == 1) { stringhex[i - 1] = String.Concat("0", stringhex[i]); }
                    if (stringhex[i - 2].Count() == 1) { stringhex[i - 2] = String.Concat("0", stringhex[i]); }
                    ADDRESS = String.Concat(stringhex[i-2],stringhex[i-1], stringhex[i]);
                }
                else if (DI_140 == true)
                {
                    DI_140_buffer1 = stringbinary[i];
                    i++;
                    DI_140_buffer2 = stringbinary[i];
                    DI_140 = false;
                }
                else if (DI_090 == true)//VERDADERO
                {
                    DI_090_buffer1 = stringbinary[i];
                    i++;
                    DI_090_buffer2 = stringbinary[i];
                    DI_090 = false;

                    char[] octet1 = DI_090_buffer1.ToArray();
                    char[] octet2 = DI_090_buffer2.ToArray();
                    int AC = Convert.ToInt32(String.Concat(Convert.ToString(octet1[0]),Convert.ToString(octet1[1])));
                    int MN = Convert.ToInt32(String.Concat(Convert.ToString(octet1[2]),Convert.ToString(octet1[3])));
                    int DC = Convert.ToInt32(String.Concat(Convert.ToString(octet1[4]), Convert.ToString(octet1[5])));
                    string PA = String.Concat(octet2[4],octet2[5],octet2[6],octet2[7]);

                    if (AC == 00)
                    { FOM_AC = "Uknown"; }
                    else if (AC == 01)
                    { FOM_AC = "ACAS not operational"; }
                    else if (AC == 10)
                    { FOM_AC = "ACAS operational"; }
                    else
                    { FOM_AC = "invalid"; }

                    if (MN == 00)
                    { FOM_MN = "Uknown"; }
                    else if (MN == 01)
                    { FOM_MN = "Multiple navigational aids not operatingl"; }
                    else if (MN == 10)
                    { FOM_MN = "Multiple navigational aids operating"; }
                    else
                    { FOM_MN = "invalid"; }

                    if (DC== 00)
                    { FOM_DC = "Uknown"; }
                    else if (DC == 01)
                    { FOM_DC = "Differential correction"; }
                    else if (DC == 10)
                    { FOM_DC = "No Differential correction"; }
                    else
                    { FOM_DC = "invalid"; }
                    FOM_PA = Convert.ToString(Convert.ToInt32(PA, 2));
                }
                else if (DI_210 == true)//VERDADERO
                {
                    DI_210_buffer1 = stringbinary[i];
                    DI_210 = false;
                    char[] octet = DI_210_buffer1.ToArray();
                    if (octet[3] == '1')
                    { LINK = " COCKPIT_DISPLAY_OF_TRAFFIC_INFO"; }
                    else if (octet[4] == '1')
                    { LINK = "MODE_S"; }
                    else if (octet[5] == '1')
                    { LINK = "UAT"; }
                    else if (octet[6] == '1')
                    { LINK = "VDL_MODE_4"; }
                    else if (octet[7] == '1')
                    { LINK = "OTHER"; }
                }
                else if (DI_230 == true)
                {
                    DI_230_buffer1 = stringbinary[i];
                    i++;
                    DI_230_buffer2 = stringbinary[i];
                    DI_230 = false;
                }
                else if (DI_145 == true)//VERDADERO
                {
                    DI_145_buffer1 = stringbinary[i];
                    i++;
                    DI_145_buffer2 = stringbinary[i];
                    DI_145 = false;

                    string octetos = String.Concat(DI_145_buffer1, DI_145_buffer2);
                    //double FL = Convert.ToDouble(Convert.ToInt32(octetos, 2)/4);
                    double FL = Convert.ToDouble(CA2todec(octetos)) / 4;
                    LEVEL = String.Format("{0}FL", FL);
                }
                else if (DI_150 == true)
                {
                    DI_150_buffer1 = stringbinary[i];
                    i++;
                    DI_150_buffer2 = stringbinary[i];
                    DI_150 = false;
                }
                else if (DI_151 == true)
                {
                    DI_151_buffer1 = stringbinary[i];
                    i++;
                    DI_151_buffer2 = stringbinary[i];
                    DI_151 = false;
                }
                else if (DI_152 == true)
                {
                    DI_152_buffer1 = stringbinary[i];
                    i++;
                    DI_152_buffer2 = stringbinary[i];
                    DI_152 = false;
                }
                else if (DI_155 == true)
                {
                    DI_155_buffer1 = stringbinary[i];
                    i++;
                    DI_155_buffer2 = stringbinary[i];
                    DI_155 = false;
                }
                else if (DI_157 == true)//VERDADERO
                {
                    DI_157_buffer1 = stringbinary[i];
                    i++;
                    DI_157_buffer2 = stringbinary[i];
                    DI_157 = false;

                    string octets = String.Concat(DI_157_buffer1, DI_157_buffer2);
                    int VR_prov = Convert.ToInt32(octets, 2);
                    VR = String.Format("{0} FT/M",VR_prov*6.25);
                }
                else if (DI_160 == true)//VERDADERO
                {
                    DI_160_buffer1 = stringbinary[i];
                    i++;
                    DI_160_buffer2 = stringbinary[i];
                    i++;
                    DI_160_buffer3 = stringbinary[i];
                    i++;
                    DI_160_buffer4 = stringbinary[i];
                    DI_160 = false;

                    string octet1 = String.Concat(DI_160_buffer1, DI_160_buffer2);
                    string octet2 = String.Concat(DI_160_buffer3, DI_160_buffer4);

                    int oc1 = Convert.ToInt32(octet1,2);
                    int oc2 = Convert.ToInt32(octet2,2);

                    SPD = String.Format("{0}KT", oc1*0.22);
                    AGL = String.Format("{0}DEG", oc2*0.0055);
                }
                else if (DI_165 == true)
                {
                    DI_165_buffer1 = stringbinary[i];
                    char[] prov = DI_165_buffer1.ToArray();
                    if (prov[prov.Length - 1] == '1')
                    {
                        i++;
                        DI_165_buffer2 = stringbinary[i];
                    }
                    DI_165 = false;
                }
                else if (DI_170 == true)//VERDADERO
                {
                    DI_170_buffer1 = stringbinary[i];
                    i++;
                    DI_170_buffer2 = stringbinary[i];
                    i++;
                    DI_170_buffer3 = stringbinary[i];
                    i++;
                    DI_170_buffer4 = stringbinary[i];
                    i++;
                    DI_170_buffer5 = stringbinary[i];
                    i++;
                    DI_170_buffer6 = stringbinary[i];
                    DI_170 = false;

                    string fulloctet = String.Concat(DI_170_buffer1, DI_170_buffer2, DI_170_buffer3, DI_170_buffer4, DI_170_buffer5, DI_170_buffer6);
                    char[] fulloctetchar = fulloctet.ToArray();
                    string oc1 = String.Concat(Convert.ToString(fulloctetchar[0]),Convert.ToString(fulloctetchar[1]),Convert.ToString(fulloctetchar[2]),Convert.ToString(fulloctetchar[3]),Convert.ToString(fulloctetchar[4]),Convert.ToString(fulloctetchar[5]));
                    string oc2 = String.Concat(Convert.ToString(fulloctetchar[6]), Convert.ToString(fulloctetchar[7]), Convert.ToString(fulloctetchar[8]), Convert.ToString(fulloctetchar[9]), Convert.ToString(fulloctetchar[10]), Convert.ToString(fulloctetchar[11]));
                    string oc3 = String.Concat(Convert.ToString(fulloctetchar[12]), Convert.ToString(fulloctetchar[13]), Convert.ToString(fulloctetchar[14]), Convert.ToString(fulloctetchar[15]), Convert.ToString(fulloctetchar[16]), Convert.ToString(fulloctetchar[17]));
                    string oc4 = String.Concat(Convert.ToString(fulloctetchar[18]), Convert.ToString(fulloctetchar[19]), Convert.ToString(fulloctetchar[20]), Convert.ToString(fulloctetchar[21]), Convert.ToString(fulloctetchar[22]), Convert.ToString(fulloctetchar[23]));
                    string oc5 = String.Concat(Convert.ToString(fulloctetchar[24]), Convert.ToString(fulloctetchar[25]), Convert.ToString(fulloctetchar[26]), Convert.ToString(fulloctetchar[27]), Convert.ToString(fulloctetchar[28]), Convert.ToString(fulloctetchar[29]));
                    string oc6 = String.Concat(Convert.ToString(fulloctetchar[30]), Convert.ToString(fulloctetchar[31]), Convert.ToString(fulloctetchar[32]), Convert.ToString(fulloctetchar[33]), Convert.ToString(fulloctetchar[34]), Convert.ToString(fulloctetchar[35]));                    
                    string oc7 = String.Concat(Convert.ToString(fulloctetchar[36]), Convert.ToString(fulloctetchar[37]), Convert.ToString(fulloctetchar[38]), Convert.ToString(fulloctetchar[39]), Convert.ToString(fulloctetchar[40]), Convert.ToString(fulloctetchar[41]));
                    string oc8 = String.Concat(Convert.ToString(fulloctetchar[42]), Convert.ToString(fulloctetchar[43]), Convert.ToString(fulloctetchar[44]), Convert.ToString(fulloctetchar[45]), Convert.ToString(fulloctetchar[46]), Convert.ToString(fulloctetchar[47]));
                    ACID_palabra = ACID(oc1, oc2, oc3, oc4, oc5, oc6,oc7,oc8); 
                }
                else if (DI_095 == true) //VERDADERO???
                {
                    DI_095_buffer1 = stringbinary[i];
                    DI_095 = false;

                    VA = Convert.ToString(Convert.ToInt32(DI_095_buffer1, 2));

                }
                else if (DI_032 == true)//????????
                {
                    DI_032_buffer1 = stringbinary[i];
                    DI_032 = false;
                }
                else if (DI_200 == true)
                {
                    DI_200_buffer1 = stringbinary[i];
                    DI_200 = false;

                }
                else if (DI_020 == true)
                {
                    DI_020_buffer1 = stringbinary[i];
                    DI_020 = false;
                }
                else if (DI_220 == true)//VERDADERO
                {
                    DI_220_buffer1 = stringbinary[i];
                    char[] prov = DI_220_buffer1.ToArray();
                    if (prov[prov.Length - 1] == '1')
                    {
                        i++;
                        DI_220_buffer2 = stringbinary[i];
                    }
                    DI_220 = false;
                }
                else if (DI_146 == true)
                {
                    DI_146_buffer1 = stringbinary[i];
                    i++;
                    DI_146_buffer2 = stringbinary[i];
                    DI_146 = false;
                }
                else if (DI_148 == true)
                {
                    DI_148_buffer1 = stringbinary[i];
                    i++;
                    DI_148_buffer2 = stringbinary[i];
                    DI_148 = false;
                }
                else if (DI_110 == true)
                {

                }
            }
            //myTime = DateTime.ParseExact(Time, "HH:mm:ss.fff",null);
        }


        public string ACID_oneletter(string letra)
        {
            string letradevolver = "";
            if (String.Compare(letra,"000001")==0)
            {
                letradevolver = "A";
            }
            else if(String.Compare(letra,"000010") == 0)
            {
                letradevolver = "B";
            }
            else if (String.Compare(letra, "000011") == 0)
            {
                letradevolver = "C";
            }
            else if (String.Compare(letra, "000100") == 0)
            {
                letradevolver = "D";
            }
            else if (String.Compare(letra, "000101") == 0)
            {
                letradevolver = "E";
            }
            else if (String.Compare(letra, "000110") == 0)
            {
                letradevolver = "F";
            }
            else if (String.Compare(letra, "000111") == 0)
            {
                letradevolver = "G";
            }
            else if (String.Compare(letra, "001000") == 0)
            {
                letradevolver = "H";
            }
            else if (String.Compare(letra, "001001") == 0)
            {
                letradevolver = "I";
            }
            else if (String.Compare(letra, "001010") == 0)
            {
                letradevolver = "J";
            }
            else if (String.Compare(letra, "001011") == 0)
            {
                letradevolver = "K";
            }
            else if (String.Compare(letra, "001100") == 0)
            {
                letradevolver = "L";
            }
            else if (String.Compare(letra, "001101") == 0)
            {
                letradevolver = "M";
            }
            else if (String.Compare(letra, "001110") == 0)
            {
                letradevolver = "N";
            }
            else if (String.Compare(letra, "001111") == 0)
            {
                letradevolver = "O";
            }
            else if (String.Compare(letra, "010000") == 0)
            {
                letradevolver = "P";
            }
            else if (String.Compare(letra, "010001") == 0)
            {
                letradevolver = "Q";
            }
            else if (String.Compare(letra, "010010") == 0)
            {
                letradevolver = "R";
            }
            else if (String.Compare(letra, "010011") == 0)
            {
                letradevolver = "S";
            }
            else if (String.Compare(letra, "010100") == 0)
            {
                letradevolver = "T";
            }
            else if (String.Compare(letra, "010101") == 0)
            {
                letradevolver = "U";
            }
            else if (String.Compare(letra, "010110") == 0)
            {
                letradevolver = "V";
            }
            else if (String.Compare(letra, "010111") == 0)
            {
                letradevolver = "W";
            }
            else if (String.Compare(letra, "011000") == 0)
            {
                letradevolver = "X";
            }
            else if (String.Compare(letra, "011001") == 0)
            {
                letradevolver = "Y";
            }
            else if (String.Compare(letra, "011010") == 0)
            {
                letradevolver = "Z";
            }
            else if (String.Compare(letra, "110000") == 0)
            {
                letradevolver = "0";
            }
            else if (String.Compare(letra, "110001") == 0)
            {
                letradevolver = "1";
            }
            else if (String.Compare(letra, "110010") == 0)
            {
                letradevolver = "2";
            }
            else if (String.Compare(letra, "110011") == 0)
            {
                letradevolver = "3";
            }
            else if (String.Compare(letra, "110100") == 0)
            {
                letradevolver = "4";
            }
            else if (String.Compare(letra, "110101") == 0)
            {
                letradevolver = "5";
            }
            else if (String.Compare(letra, "110110") == 0)
            {
                letradevolver = "6";
            }
            else if (String.Compare(letra, "110111") == 0)
            {
                letradevolver = "7";
            }
            else if (String.Compare(letra, "111000") == 0)
            {
                letradevolver = "8";
            }
            else if (String.Compare(letra, "111001") == 0)
            {
                letradevolver = "9";
            }
            return letradevolver;
        }

        public string ACID(string oc1, string oc2, string oc3, string oc4, string oc5, string oc6,string oc7,string oc8)
        {
            string let1 = ACID_oneletter(oc1);
            string let2 = ACID_oneletter(oc2);
            string let3 = ACID_oneletter(oc3);
            string let4 = ACID_oneletter(oc4);
            string let5 = ACID_oneletter(oc5);
            string let6 = ACID_oneletter(oc6);
            string let7 = ACID_oneletter(oc7);
            string let8 = ACID_oneletter(oc8);

            string final = String.Concat(let1, let2, let3, let4, let5, let6,let7,let8);
            return final;
        }

        public int CA2todec(string CA2)
        {
            bool negativo;
            if (Convert.ToInt32("" + CA2[0]) == 1)
            { negativo = true; }
            else
            { negativo = false; }

            int result;
            string binario = "";
            int i = 1;
            if (negativo)
            {
                while (i < CA2.Length)
                {
                    if (Convert.ToInt32("" + CA2[i]) == 1)
                    { binario = binario + "0"; }
                    if (Convert.ToInt32("" + CA2[i]) == 0)
                    { binario = binario + "1"; }
                    i++;
                }
                result = Convert.ToInt32(binario, 2) + 1;
                result = -result;
            }
            else
            {
                while (i < CA2.Length)
                {
                    if (Convert.ToInt32("" + CA2[i]) == 1)
                    { binario = binario + "1"; }
                    if (Convert.ToInt32("" + CA2[i]) == 0)
                    { binario = binario + "0"; }
                    i++;
                }
                result = Convert.ToInt32(binario, 2) ;
            }
            return result;
        }

        public DataTable actualizarTabla(DataTable dt)
        {
            dt.Rows.Add(SAC, SIC, TARGET, myTime, latitud, longitud,coordinates, VR, LINK, LEVEL, SPD, AGL, "No sé", ADDRESS, ACID_palabra, VA);
            return dt;
        }
    }
}
