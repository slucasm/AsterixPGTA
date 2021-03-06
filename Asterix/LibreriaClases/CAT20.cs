﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GMap.NET.MapProviders;
using GMap.NET;

namespace LibreriaClases
{
    public class CAT20
    {
        string[] stringhex;
        int[] arraydec;
        string[] stringbinary;
        List<Boolean> listboolean_fspec = new List<Boolean>();
        Boolean DI_010, DI_020, DI_030, DI_041, DI_042, DI_050, DI_055, DI_070, DI_090, DI_100, DI_105, DI_110, DI_140, DI_161, DI_170, DI_202, DI_210, DI_220, DI_230, DI_245, DI_250, DI_260, DI_300, DI_310, DI_400, DI_500;

        string DI_010_buffer1, DI_010_buffer2, DI_020_buffer1, DI_020_buffer2, DI_140_buffer1, DI_140_buffer2, DI_140_buffer3, DI_041_buffer1, DI_041_buffer2, DI_041_buffer3, DI_041_buffer4, DI_041_buffer5, DI_041_buffer6, DI_041_buffer7, DI_041_buffer8, DI_042_buffer1, DI_042_buffer2, DI_042_buffer3, DI_042_buffer4, DI_042_buffer5, DI_042_buffer6, DI_161_buffer1, DI_161_buffer2, DI_170_buffer1, DI_170_buffer2, DI_070_buffer1, DI_070_buffer2, DI_202_buffer1, DI_202_buffer2, DI_202_buffer3, DI_202_buffer4, DI_090_buffer1, DI_090_buffer2, DI_100_buffer1, DI_100_buffer2, DI_100_buffer3, DI_100_buffer4, DI_220_buffer1, DI_220_buffer2, DI_220_buffer3, DI_245_buffer1, DI_245_buffer2, DI_245_buffer3, DI_245_buffer4, DI_245_buffer5, DI_245_buffer6, DI_245_buffer7, DI_110_buffer1, DI_110_buffer2, DI_105_buffer1, DI_105_buffer2, DI_210_buffer1, DI_210_buffer2, DI_300_buffer1, DI_310_buffer1, DI_500_buffer1, DI_400_buffer1, DI_250_buffer1, DI_230_buffer1, DI_230_buffer2, DI_260_buffer1, DI_260_buffer2, DI_260_buffer3, DI_260_buffer4, DI_260_buffer5, DI_260_buffer6, DI_260_buffer7, DI_030_buffer1, DI_030_buffer2, DI_055_buffer1, DI_050_buffer1, DI_050_buffer2, DI_500_buffer2, DI_500_buffer3, DI_500_buffer4, DI_500_buffer5, DI_500_buffer6, DI_500_buffer7, DI_500_buffer8, DI_500_buffer9, DI_500_buffer10, DI_500_buffer11, DI_500_buffer12, DI_500_buffer13, DI_500_buffer14, DI_500_buffer15, DI_400_buffer2, DI_400_buffer3, DI_400_buffer4, DI_400_buffer5, DI_400_buffer6, DI_400_buffer7, DI_400_buffer8, DI_400_buffer9;


        public int SAC, SIC;
        public string MLAT_type;
        public string D020_SSR, D020_MS, D020_HF, D020_VDL4, D020_UAT, D020_DME, D020_OT, D020_RAB, D020_SPI, D020_CHN, D020_GBS, D020_CRT, D020_SIM, D020_TST;
        public string Time;
        public double X, Y;
        public string TRACK_NUM;
        public string TRACKSTATUS_CNF, TRACKSTATUS_TRE, TRACKSTATUS_CST, TRACKSTATUS_CDM, TRACKSTATUS_MAH, TRACKSTATUS_STH, TRACKSTATUS_GHO;
        public string MODE_3A;
        public double VX, VY;
        public double MODE_C;
        public string ADDRESS;
        public string ACID_palabra;
        public int RECEIVERS;

        public int CAT;

        public TimeSpan myTime;

        public string coordinates;
        public PointLatLng punto;

        public Tuple<string, string, string, string, string, string, string> getTarget1()
        {
            Tuple<string, string, string, string, string, string, string> tuple = new Tuple<string, string, string, string, string, string, string>(D020_SSR, D020_MS, D020_HF, D020_VDL4, D020_UAT, D020_DME, D020_OT);
            return tuple;
        }
        public Tuple<string, string, string, string, string, string, string> getTarget2()
        {
            Tuple<string, string, string, string, string, string, string> tuple = new Tuple<string, string, string, string, string, string, string>(D020_RAB, D020_SPI, D020_CHN, D020_GBS, D020_CRT, D020_SIM, D020_TST);
            return tuple;
        }
        public Tuple<string, string, string, string, string, string, string> getTrackstatus()
        {
            Tuple<string, string, string, string, string, string, string> tuple = new Tuple<string, string, string, string, string, string, string>(TRACKSTATUS_CNF, TRACKSTATUS_TRE, TRACKSTATUS_CST, TRACKSTATUS_CDM, TRACKSTATUS_MAH, TRACKSTATUS_STH, TRACKSTATUS_GHO);
            return tuple;
        }

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
            CAT = Convert.ToInt32(stringbinary[0], 2);
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

                if (DI_010 == true) //VERDADERO HECHO
                {
                    DI_010_buffer1 = stringbinary[i];
                    i++;
                    DI_010_buffer2 = stringbinary[i];
                    DI_010 = false;

                    SAC = Convert.ToInt32(DI_010_buffer1, 2);
                    SIC = Convert.ToInt32(DI_010_buffer2, 2);
                }
                else if (DI_020 == true)//VERDADERO HECHO
                {
                    DI_020_buffer1 = stringbinary[i];
                    char[] prov = DI_020_buffer1.ToArray();
                    if (Convert.ToInt32(prov[prov.Length - 1]) == '1')
                    {
                        i++;
                        DI_020_buffer2 = stringbinary[i];
                    }
                    DI_020 = false;
                    if (prov[0] == '1')
                    {
                        D020_SSR = "Non-Mode S 1090MHz multilateration";
                    }
                    else { D020_SSR = "no Non-Mode S 1090MHz multilateration"; }
                    if (prov[1] == '1')
                    {
                        D020_MS = "Mode-S 1090 MHz multilateration";
                    }
                    else { D020_MS = "no Mode-s 1090 MHz multilateration"; }
                    if (prov[2] == '1')
                    {
                        D020_HF = "HF multilateration";
                    }
                    else { D020_HF = "no HF multilateration"; }
                    if (prov[3] == '1')
                    {
                        D020_VDL4 = "VDL Mode 4 multilateration";
                    }
                    else { D020_VDL4 = "no VDL Mode 4 multilateration"; }
                    if (prov[4] == '1')
                    {
                        D020_UAT = "UAT multilateration";
                    }
                    else { D020_UAT = "no UAT multilateration"; }
                    if (prov[5] == '1')
                    {
                        D020_DME = "DME/TACAN multilateration";
                    }
                    else { D020_DME = "no DME/TACAN multilateration"; }
                    if (prov[6] == '1')
                    {
                        D020_OT = "Other Tecnology Multilateration";
                    }
                    else { D020_OT = "No Other Tecnology Multilateration"; }

                    if (DI_020_buffer2 != null)
                    {
                        char[] prov2 = DI_020_buffer2.ToArray();
                        if (prov2[0] == '1')
                        {
                            D020_RAB = "Report from field monitor";
                        }
                        else
                        {
                            D020_RAB = "Report from target transponder";
                        }
                        if (prov2[1] == '1')
                        {
                            D020_SPI = "Special Position Identification";
                        }
                        else
                        {
                            D020_SPI = "Absence of SPI ";
                        }
                        if (prov2[2] == '1')
                        {
                            D020_CHN = "Chain 2";
                        }
                        else
                        {
                            D020_CHN = "Chain 1";
                        }
                        if (prov2[3] == '1')
                        {
                            D020_GBS = "Transponder Ground bit set";
                        }
                        else
                        {
                            D020_GBS = "Transponder Ground bit not set";
                        }
                        if (prov2[4] == '1')
                        {
                            D020_CRT = "Corrupted replies in multilateration";
                        }
                        else
                        {
                            D020_CRT = "No Corrupted reply in multilateration";
                        }
                        if (prov2[5] == '1')
                        {
                            D020_SIM = "Simulated target report";
                        }
                        else
                        {
                            D020_SIM = "Actual target report ";
                        }
                        if (prov2[6] == '1')
                        {
                            D020_TST = "Test Target";
                        }
                        else
                        {
                            D020_TST = "Default";
                        }
                    }
                }
                else if (DI_140 == true)//VERDADERO HECHO
                {
                    DI_140_buffer1 = stringbinary[i];
                    i++;
                    DI_140_buffer2 = stringbinary[i];
                    i++;
                    DI_140_buffer3 = stringbinary[i];
                    DI_140 = false;
                    int DI_140_bff = Convert.ToInt32(String.Concat(DI_140_buffer1, DI_140_buffer2, DI_140_buffer3), 2);
                    double seconds = Math.Round(Convert.ToDouble(DI_140_bff) / 128, 3);
                    myTime = TimeSpan.FromSeconds(seconds);
                    //Time = time.ToString(@"hh\:mm\:ss\.fff");
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
                else if (DI_042 == true)//VERDADERO COMPROBADO
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

                    string oc1 = String.Concat(DI_042_buffer1, DI_042_buffer2, DI_042_buffer3);
                    string oc2 = String.Concat(DI_042_buffer4, DI_042_buffer5, DI_042_buffer6);

                    X = CA2todec(oc1)*0.5;
                    if (X < 0)
                    { X = X + 0.5;}
                    Y = CA2todec(oc2)*0.5;
                    if (Y < 0)
                    { Y = Y + 0.5;}

                    double gradlat = 41;
                    double gradlon = 2;
                    double mintogradlat = (Convert.ToDouble(17)/60);
                    double mintogradlon = (Convert.ToDouble(4)/60);
                    double sectogradlat = Convert.ToDouble(49.426) / 3600;
                    double sectogradlon = Convert.ToDouble(42.410) / 3600;
                    double latitud = (Convert.ToDouble(gradlat) + Convert.ToDouble(mintogradlat)) + Convert.ToDouble(sectogradlat);
                    double longitud = (Convert.ToDouble(gradlon) + Convert.ToDouble(mintogradlon)) + Convert.ToDouble(sectogradlon);
                    double lat_original = latitud;
                    latitud = latitud + (X/6378000)*(180/Math.PI);
                    longitud = longitud + (Y / 6378000) * (180 / Math.PI) / Math.Cos(lat_original * (Math.PI / 180)); ;

                    punto = new PointLatLng(latitud, longitud);

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
                    double segdeclat = Convert.ToDouble(String.Concat("0,", separados2lat[1])) * 60;
                    double segdeclon = Convert.ToDouble(String.Concat("0,", separados2lon[1])) * 60;
                    string seclat = (Math.Round(segdeclat, 3)).ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    string seclon = (Math.Round(segdeclon, 3)).ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    string latitudd, longitudd;
                    if (latitud > 0)
                    { latitudd = String.Concat(gradoslat, "º", minlat, "'", seclat, '"', 'N'); }
                    else
                    { latitudd = String.Concat(gradoslat, 'º', minlat, "'", seclat, '"', 'S'); }
                    if (longitud > 0)
                    { longitudd = String.Concat(gradoslon, 'º', minlon, "'", seclon, '"', 'E'); }
                    else
                    { longitudd = String.Concat(gradoslon, 'º', minlon, "'", seclon, '"', 'O'); }

                    coordinates = String.Concat(latitudd, longitudd);                  

                }
                else if (DI_161 == true)//VERDADERO HECHO
                {
                    DI_161_buffer1 = stringbinary[i];
                    i++;
                    DI_161_buffer2 = stringbinary[i];
                    DI_161 = false;
                    char[] buf1 = DI_161_buffer1.ToArray();
                    string conc = String.Concat(buf1[4], buf1[5], buf1[6], buf1[7], DI_161_buffer2);
                    TRACK_NUM = Convert.ToString(Convert.ToInt32(conc, 2));

                }
                else if (DI_170 == true)//VERDADERO HECHO
                {
                    DI_170_buffer1 = stringbinary[i];
                    char[] prov = DI_170_buffer1.ToArray();
                    if (prov[prov.Length - 1] == '1')
                    {
                        i++;
                        DI_170_buffer2 = stringbinary[i];
                    }
                    DI_170 = false;

                    char[] oc1 = DI_170_buffer1.ToArray();

                    string oc34 = String.Concat(oc1[3], oc1[4]);
                    if (oc1[0] == '1') { TRACKSTATUS_CNF = "Initiation phase"; }
                    else { TRACKSTATUS_CNF = "Confirmed track"; }

                    if (oc1[1] == '1') { TRACKSTATUS_TRE = "Last report for a track "; }
                    else { TRACKSTATUS_TRE = "Default"; }
                    if (oc1[2] == '1') { TRACKSTATUS_CST = "Extrapolated"; }
                    else { TRACKSTATUS_CST = "Not extrapolated"; }
                    if (String.Compare(oc34, "00") == 0) { TRACKSTATUS_CDM = "Maintaning"; }
                    else if (String.Compare(oc34, "01") == 0) { TRACKSTATUS_CDM = "Cruising"; }
                    else if (String.Compare(oc34, "10") == 0) { TRACKSTATUS_CDM = "Descending"; }
                    else { TRACKSTATUS_CDM = "Invalid"; }
                    if (oc1[5] == '1') { TRACKSTATUS_MAH = "Horizontal manouvre"; }
                    else { TRACKSTATUS_MAH = "Default"; }
                    if (oc1[6] == '1') { TRACKSTATUS_STH = "Smoothed position"; }
                    else { TRACKSTATUS_STH = "Mesured position"; }

                    if (DI_170_buffer2 != null)
                    {
                        char[] oc2 = DI_170_buffer2.ToArray();
                        if (oc2[0] == '1')
                        { TRACKSTATUS_GHO = "Ghost track";}
                        else { TRACKSTATUS_GHO = "Default"; }

                    }
                    

                }
                else if (DI_070 == true)//VERDADERO HECHO
                {
                    DI_070_buffer1 = stringbinary[i];
                    i++;
                    DI_070_buffer2 = stringbinary[i];
                    DI_070 = false;

                    char[] oc1 = DI_070_buffer1.ToArray();
                    char[] oc2 = DI_070_buffer2.ToArray();
                    string bit4_6 = String.Concat(oc1[4], oc1[5], oc1[6]);
                    string bit7_9 = String.Concat(oc1[7], oc2[0], oc2[1]);
                    string bit10_12 = String.Concat(oc2[2], oc2[3], oc2[4]);
                    string bit13_15 = String.Concat(oc2[5], oc2[6], oc2[7]);
                    int bbit4_6 = Convert.ToInt32(bit4_6, 2);
                    int bbit7_9 = Convert.ToInt32(bit7_9, 2);
                    int bbit10_12 = Convert.ToInt32(bit10_12, 2);
                    int bbit13_15 = Convert.ToInt32(bit13_15, 2);
                    MODE_3A = String.Concat(bbit4_6, bbit7_9, bbit10_12, bbit13_15);


                }
                else if (DI_202 == true)//VERDADERO LA MAYORIA BIEN!
                {
                    DI_202_buffer1 = stringbinary[i];
                    i++;
                    DI_202_buffer2 = stringbinary[i];
                    i++;
                    DI_202_buffer3 = stringbinary[i];
                    i++;
                    DI_202_buffer4 = stringbinary[i];
                    DI_202 = false;

                    string oc1 = String.Concat(DI_202_buffer1, DI_202_buffer2);
                    string oc2 = String.Concat(DI_202_buffer3,DI_202_buffer4);

                    VX = CA2todec(oc1) * 0.25;
                    if (VX < 0)
                    { VX = VX + 0.25; }
                    VY = CA2todec(oc2) * 0.25;//PUEDE FALLAR ESTE POR EL ÚLTIMO VALOR DEL TERCER OCTETO!!!
                    if (VY < 0)
                    { VY = VY + 0.25; }
                }
                else if (DI_090 == true)//VERDADERO HECHO
                {
                    DI_090_buffer1 = stringbinary[i];
                    i++;
                    DI_090_buffer2 = stringbinary[i];
                    DI_090 = false;

                    char[] oc1 = DI_090_buffer1.ToArray();
                    string ocfinal = String.Concat(oc1[2], oc1[3], oc1[4], oc1[5], oc1[6],oc1[7], DI_090_buffer2);
                    MODE_C = Convert.ToDouble(Convert.ToInt32(ocfinal, 2)) * 0.25;
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
                else if (DI_220 == true)//VERDADERO HECHO
                {

                    DI_220_buffer1 = stringbinary[i];
                    i++;
                    DI_220_buffer2 = stringbinary[i];
                    i++;
                    DI_220_buffer3 = stringbinary[i];
                    DI_220 = false;
                    if (stringhex[i].Count() == 1) { stringhex[i] = String.Concat("0", stringhex[i]); }
                    if (stringhex[i - 1].Count() == 1) { stringhex[i - 1] = String.Concat("0", stringhex[i]); }
                    if (stringhex[i - 2].Count() == 1) { stringhex[i - 2] = String.Concat("0", stringhex[i]); }
                    ADDRESS = String.Concat(stringhex[i-2],stringhex[i-1], stringhex[i]);

                }
                else if (DI_245 == true)//VERDADERO HECHO
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

                    string fulloctet = String.Concat(DI_245_buffer1, DI_245_buffer2, DI_245_buffer3, DI_245_buffer4, DI_245_buffer5, DI_245_buffer6,DI_245_buffer7);
                    char[] fulloctetchar = fulloctet.ToArray();
                    string oc1 = String.Concat(Convert.ToString(fulloctetchar[8]), Convert.ToString(fulloctetchar[9]), Convert.ToString(fulloctetchar[10]), Convert.ToString(fulloctetchar[11]), Convert.ToString(fulloctetchar[12]), Convert.ToString(fulloctetchar[13]));
                    string oc2 = String.Concat(Convert.ToString(fulloctetchar[14]), Convert.ToString(fulloctetchar[15]), Convert.ToString(fulloctetchar[16]), Convert.ToString(fulloctetchar[17]), Convert.ToString(fulloctetchar[18]), Convert.ToString(fulloctetchar[19]));
                    string oc3 = String.Concat(Convert.ToString(fulloctetchar[20]), Convert.ToString(fulloctetchar[21]), Convert.ToString(fulloctetchar[22]), Convert.ToString(fulloctetchar[23]), Convert.ToString(fulloctetchar[24]), Convert.ToString(fulloctetchar[25]));
                    string oc4 = String.Concat(Convert.ToString(fulloctetchar[26]), Convert.ToString(fulloctetchar[27]), Convert.ToString(fulloctetchar[28]), Convert.ToString(fulloctetchar[29]), Convert.ToString(fulloctetchar[30]), Convert.ToString(fulloctetchar[31]));
                    string oc5 = String.Concat(Convert.ToString(fulloctetchar[32]), Convert.ToString(fulloctetchar[33]), Convert.ToString(fulloctetchar[34]), Convert.ToString(fulloctetchar[35]), Convert.ToString(fulloctetchar[36]), Convert.ToString(fulloctetchar[37]));
                    string oc6 = String.Concat(Convert.ToString(fulloctetchar[38]), Convert.ToString(fulloctetchar[39]), Convert.ToString(fulloctetchar[40]), Convert.ToString(fulloctetchar[41]), Convert.ToString(fulloctetchar[42]), Convert.ToString(fulloctetchar[43]));
                    string oc7 = String.Concat(Convert.ToString(fulloctetchar[44]), Convert.ToString(fulloctetchar[45]), Convert.ToString(fulloctetchar[46]), Convert.ToString(fulloctetchar[47]), Convert.ToString(fulloctetchar[48]), Convert.ToString(fulloctetchar[49]));
                    
                    ACID_palabra = ACID(oc1, oc2, oc3, oc4, oc5, oc6, oc7); 
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
                else if (DI_500 == true)//VERDADERO (NO SÉ SI ES NECESARIO)
                {
                    DI_500_buffer1 = stringbinary[i];
                    char[] buff1 = DI_500_buffer1.ToArray();
                    if (buff1[0] == '1')
                    {
                        i++;
                        DI_500_buffer2 = stringbinary[i];
                        i++;
                        DI_500_buffer3 = stringbinary[i];
                        i++;
                        DI_500_buffer4 = stringbinary[i];
                        i++;
                        DI_500_buffer5 = stringbinary[i];
                        i++;
                        DI_500_buffer6 = stringbinary[i];
                        i++;
                        DI_500_buffer7 = stringbinary[i];
                    }
                    if (buff1[1] == '1')
                    {
                        i++;
                        DI_500_buffer8 = stringbinary[i];
                        i++;
                        DI_500_buffer9 = stringbinary[i];
                        i++;
                        DI_500_buffer10 = stringbinary[i];
                        i++;
                        DI_500_buffer11 = stringbinary[i];
                        i++;
                        DI_500_buffer12 = stringbinary[i];
                        i++;
                        DI_500_buffer13 = stringbinary[i];
                    }
                    if (buff1[2] == '1')
                    {
                        i++;
                        DI_500_buffer14 = stringbinary[i];
                        i++;
                        DI_500_buffer15 = stringbinary[i];
                    }
                    DI_500 = false;
                }
                else if (DI_400 == true)//VERDADERO HECHO
                {
                    DI_400_buffer1 = stringbinary[i];
                    i++;
                    DI_400_buffer2 = stringbinary[i];
                    i++;
                    DI_400_buffer3 = stringbinary[i];
                    i++;
                    DI_400_buffer4 = stringbinary[i];
                    i++;
                    DI_400_buffer5 = stringbinary[i];
                    i++;
                    DI_400_buffer6 = stringbinary[i];
                    i++;
                    DI_400_buffer7 = stringbinary[i];
                    i++;
                    DI_400_buffer8 = stringbinary[i];
                    i++;
                    DI_400_buffer9 = stringbinary[i];
                    i++;
                    DI_400 = false;

                    char[] oc1 = DI_400_buffer1.ToArray();
                    char[] oc2 = DI_400_buffer2.ToArray();
                    char[] oc3 = DI_400_buffer3.ToArray();
                    char[] oc4 = DI_400_buffer4.ToArray();
                    char[] oc5 = DI_400_buffer5.ToArray();
                    char[] oc6 = DI_400_buffer6.ToArray();
                    char[] oc7 = DI_400_buffer7.ToArray();
                    char[] oc8 = DI_400_buffer8.ToArray();
                    char[] oc9 = DI_400_buffer9.ToArray();
                    int suma = 0;
                    for (int d = 0; d < oc1.Length; d++)
                    {
                        if (oc1[d] == '1') { suma++; }
                        if (oc2[d] == '1') { suma++; }
                        if (oc3[d] == '1') { suma++; }
                        if (oc4[d] == '1') { suma++; }
                        if (oc5[d] == '1') { suma++; }
                        if (oc6[d] == '1') { suma++; }
                        if (oc7[d] == '1') { suma++; }
                        if (oc8[d] == '1') { suma++; }
                        if (oc9[d] == '1') { suma++; }
                    }
                    RECEIVERS = suma-1;

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
                    if (prov[prov.Length - 1] == '1')
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
            //myTime = DateTime.ParseExact(Time, "HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);
        }

        public string ACID_oneletter(string letra)
        {
            string letradevolver = "";
            if (String.Compare(letra, "000001") == 0)
            {
                letradevolver = "A";
            }
            else if (String.Compare(letra, "000010") == 0)
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

        public string ACID(string oc1, string oc2, string oc3, string oc4, string oc5, string oc6, string oc7)
        {
            string let1 = ACID_oneletter(oc1);
            string let2 = ACID_oneletter(oc2);
            string let3 = ACID_oneletter(oc3);
            string let4 = ACID_oneletter(oc4);
            string let5 = ACID_oneletter(oc5);
            string let6 = ACID_oneletter(oc6);
            string let7 = ACID_oneletter(oc7);

            string final = String.Concat(let1, let2, let3, let4, let5, let6, let7);
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
                result = Convert.ToInt32(binario, 2);
            }
            return result;
        }

        public DataTable actualizarTabla(DataTable dt)
        {
            dt.Rows.Add(SAC, SIC, myTime, X, Y,coordinates, VX, VY, "Click for more information", TRACK_NUM, "Click for more information", MODE_3A, MODE_C, ADDRESS, ACID_palabra, RECEIVERS);
            return dt;
        }
    }
}
