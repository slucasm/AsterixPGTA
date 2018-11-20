using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace LibreriaClases
{
    public class CAT10
    {
        string[] stringhex;
        int[] arraydec;
        string[] stringbinary;
        List<Boolean> listboolean_fspec = new List<Boolean>();
        Boolean DI_000, DI_010, DI_020, DI_040, DI_041, DI_042, DI_060, DI_090, DI_091, DI_131, DI_140, DI_161, DI_170, DI_200, DI_202, DI_210, DI_220, DI_245, DI_250, DI_270, DI_280, DI_300, DI_310, DI_500, DI_550;

        string DI_010_buffer1, DI_010_buffer2, DI_000_buffer1, DI_020_buffer1, DI_020_buffer2,DI_020_buffer3, DI_140_buffer1, DI_140_buffer2, DI_140_buffer3, DI_041_buffer1, DI_041_buffer2, DI_041_buffer3, DI_041_buffer4, DI_041_buffer5, DI_041_buffer6, DI_041_buffer7, DI_041_buffer8, DI_040_buffer1, DI_040_buffer2, DI_040_buffer3, DI_040_buffer4, DI_042_buffer1, DI_042_buffer2, DI_042_buffer3, DI_042_buffer4, DI_200_buffer1, DI_200_buffer2, DI_200_buffer3, DI_200_buffer4, DI_202_buffer1, DI_202_buffer2, DI_202_buffer3, DI_202_buffer4, DI_161_buffer1, DI_161_buffer2, DI_170_buffer1, DI_170_buffer2,DI_170_buffer3, DI_060_buffer1, DI_060_buffer2, DI_220_buffer1, DI_220_buffer2, DI_220_buffer3, DI_245_buffer1, DI_245_buffer2, DI_245_buffer3, DI_245_buffer4, DI_245_buffer5, DI_245_buffer6, DI_245_buffer7, DI_250_buffer1, DI_300_buffer1, DI_090_buffer1, DI_090_buffer2, DI_091_buffer1, DI_091_buffer2, DI_270_buffer1, DI_270_buffer2, DI_550_buffer1, DI_310_buffer1, DI_500_buffer1, DI_500_buffer2, DI_500_buffer3, DI_500_buffer4, DI_280_buffer1, DI_131_buffer1, DI_210_buffer1, DI_210_buffer2;

        public int SAC, SIC;
        public string Message_type;
        public string TARGET_TYP, TARGET_DCR, TARGET_CHN, TARGET_GBS, TARGET_CRT, TARGET_SIM, TARGET_TST, TARGET_RAB, TARGET_LOP, TARGET_TOT, TARGET_SPI;
        public string Time;
        public double X, Y;
        public double VX, VY;
        public int TRACKNUMBER;
        public string TRACKSTATUS_CNF, TRACKSTATUS_TRE, TRACKSTATUS_CST, TRACKSTATUS_MAH, TRACKSTATUS_TCC, TRACKSTATUS_STH, TRACKSTATUS_TOM, TRACKSTATUS_DOU, TRACKSTATUS_MRS, TRACKSTATUS_GHO;
        public string MODE_3A;
        public string ADDRESS;
        public string ACID_palabra;
        public double FLIGHTLEVEL;

        int CAT;

        public TimeSpan myTime;

        public string coordinates;


        public Tuple<string, string, string, string, string, string, string> getTarget1()
        {
            Tuple<string, string, string, string, string, string, string> tuple = new Tuple<string, string, string, string, string, string, string>(TARGET_TYP, TARGET_DCR, TARGET_CHN, TARGET_GBS, TARGET_CRT, TARGET_SIM, TARGET_TST);
            return tuple;
        }
        public Tuple<string, string, string, string> getTarget2()
        {
            Tuple<string, string, string, string> tuple = new Tuple<string, string, string, string>(TARGET_RAB, TARGET_LOP, TARGET_TOT, TARGET_SPI);
            return tuple;
        }
        public Tuple<string, string, string, string, string, string, string> getTrackstatus1()
        {
            Tuple<string, string, string, string, string, string, string> tuple = new Tuple<string, string, string, string, string, string, string>(TRACKSTATUS_CNF, TRACKSTATUS_TRE, TRACKSTATUS_CST, TRACKSTATUS_MAH, TRACKSTATUS_TCC, TRACKSTATUS_STH, TRACKSTATUS_TOM);
            return tuple;
        }
        public Tuple<string, string, string> getTrackstatus2()
        {
            Tuple<string, string, string> tuple = new Tuple<string, string, string>(TRACKSTATUS_DOU, TRACKSTATUS_MRS, TRACKSTATUS_GHO);
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
                else if (DI_000 == true)//VERDADERO COMPROBAR
                {
                    DI_000_buffer1 = stringbinary[i];
                    DI_000 = false;

                    int messg = Convert.ToInt32(DI_000_buffer1, 2);
                    if (messg == 1) { Message_type = "Target Report"; }
                    else if (messg == 2) { Message_type = "Start of Update Cycle"; }
                    else if (messg == 3) { Message_type = "Periodic Status Message"; }
                    else { Message_type = "Event-triggered Status Message"; }
                }
                else if (DI_020 == true)//VERDADERO COMPROBAR
                {
                    DI_020_buffer1 = stringbinary[i];
                    char[] prov = DI_020_buffer1.ToArray();

                    int TYP = Convert.ToInt32(String.Concat(prov[0], prov[1], prov[2]));
                    if (TYP == 0) { TARGET_TYP = "SSR multilateration"; }
                    else if (TYP == 1) { TARGET_TYP = "Mode S multilateration"; }
                    else if (TYP == 10) { TARGET_TYP = "ADS-B"; }
                    else if (TYP == 11) { TARGET_TYP = "PSR"; }
                    else if (TYP == 100) { TARGET_TYP = "Magnetic Loop System"; }
                    else if (TYP == 101) { TARGET_TYP = "HF multilateration"; }
                    else if (TYP == 110) { TARGET_TYP = "Not defined"; }
                    else if (TYP == 111) { TARGET_TYP = "Other types"; }

                    if (prov[3] == '0') { TARGET_DCR = "No differential correction"; }
                    else { TARGET_DCR = "Differential correction"; }

                    if (prov[4] == '0') { TARGET_CHN = "Chain 1"; }
                    else { TARGET_CHN = "Chain 2"; }

                    if (prov[5] == '0') { TARGET_GBS = "Transponder Ground bit not set"; }
                    else { TARGET_GBS = "Transponder Ground bit set"; }

                    if (prov[6] == '0') { TARGET_CRT = "No Corrupted reply in multilateration "; }
                    else { TARGET_CRT = "No Corrupted reply in multilateration "; }

                    if (prov[prov.Length - 1] == '1')
                    {
                        i++;
                        DI_020_buffer2 = stringbinary[i];
                        char[] prov2 = DI_020_buffer2.ToArray();
                        int LOP = Convert.ToInt32(String.Concat(prov[3], prov[4]));
                        int TOT = Convert.ToInt32(String.Concat(prov[5], prov[6]));
                        if (prov2[0] == '0') { TARGET_SIM = "Actual target report "; }
                        else { TARGET_SIM = "Simulated target report "; }

                        if (prov2[1] == '0') { TARGET_TST = "Default"; }
                        else { TARGET_TST = "Test Target"; }

                        if (prov2[2] == '0') { TARGET_RAB = "Report from target transponder "; }
                        else { TARGET_RAB = "Report from field monitor"; }

                        if (LOP == 0) { TARGET_LOP = "Undetermined "; }
                        else if (LOP == 1) { TARGET_LOP = "Loop start"; }
                        else if (LOP == 10) { TARGET_LOP = "Loop finish"; }

                        if (TOT == 0) { TARGET_TOT = "Undeterminated"; }
                        else if (TOT == 1) { TARGET_TOT = "Aircraft"; }
                        else if (TOT == 10) { TARGET_TOT = "Ground vehicle "; }
                        else { TARGET_TOT = "Helicopter "; }

                        if (prov2[prov.Length - 1] == '1')
                        {
                            i++;
                            DI_020_buffer3 = stringbinary[i];
                            if (DI_020_buffer3[0] == '0') { TARGET_SPI = "Absence of SPI"; }
                            else { TARGET_SPI = "Special Position Identification"; }
                        }
                    }
                    DI_020 = false;

                }
                else if (DI_140 == true)//VERDADERO COMPROBAR
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
                else if (DI_040 == true)
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
                else if (DI_042 == true)//VERDADERO COMPROBAR
                {
                    DI_042_buffer1 = stringbinary[i];
                    i++;
                    DI_042_buffer2 = stringbinary[i];
                    i++;
                    DI_042_buffer3 = stringbinary[i];
                    i++;
                    DI_042_buffer4 = stringbinary[i];
                    DI_042 = false;

                    string oc1 = String.Concat(DI_042_buffer1,DI_042_buffer2);
                    string oc2 = String.Concat(DI_042_buffer3,DI_042_buffer4);
                    X = CA2todec(oc1);
                    Y = CA2todec(oc2);
                    double latitud, longitud;
                    if (SAC == 107)
                    {
                        double gradlat = 41;
                        double gradlon = 2;
                        double mintogradlat = (Convert.ToDouble(17) / 60);
                        double mintogradlon = (Convert.ToDouble(4) / 60);
                        double sectogradlat = Convert.ToDouble(44.426) / 3600;
                        double sectogradlon = Convert.ToDouble(42.410) / 3600;
                        latitud = (Convert.ToDouble(gradlat) + Convert.ToDouble(mintogradlat)) + Convert.ToDouble(sectogradlat);
                        longitud = (Convert.ToDouble(gradlon) + Convert.ToDouble(mintogradlon)) + Convert.ToDouble(sectogradlon);
                    }
                    else
                    {
                        double gradlat = 41;
                        double gradlon = 2;
                        double mintogradlat = (Convert.ToDouble(17) / 60);
                        double mintogradlon = (Convert.ToDouble(5) / 60);
                        double sectogradlat = Convert.ToDouble(44.226) / 3600;
                        double sectogradlon = Convert.ToDouble(42.411) / 3600;
                        latitud = (Convert.ToDouble(gradlat) + Convert.ToDouble(mintogradlat)) + Convert.ToDouble(sectogradlat);
                        longitud = (Convert.ToDouble(gradlon) + Convert.ToDouble(mintogradlon)) + Convert.ToDouble(sectogradlon);
                    }
                    latitud = latitud + (X / 30) / 3600;
                    longitud = longitud + (Y / 30) / 3600;
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
                else if (DI_202 == true)//VERDADERO COMPROBAR
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
                    string oc2 = String.Concat(DI_202_buffer3, DI_202_buffer4);

                    VX = CA2todec(oc1)*0.25;
                    { VX = VX + 0.25; }
                    VY = CA2todec(oc2)*0.25;
                    { VY = VY + 0.25; }
                }
                else if (DI_161 == true)//VERDADERO COMPROBAR
                {
                    DI_161_buffer1 = stringbinary[i];
                    i++;
                    DI_161_buffer2 = stringbinary[i];
                    DI_161 = false;

                    string oc = String.Concat(DI_161_buffer1[3], DI_161_buffer1[4], DI_161_buffer1[5], DI_161_buffer1[6], DI_161_buffer1[7],DI_161_buffer2);
                    TRACKNUMBER = Convert.ToInt32(oc, 2);
                }
                else if (DI_170 == true)//VERDADERO COMPROBAR
                {
                    DI_170_buffer1 = stringbinary[i];
                    char[] prov = DI_170_buffer1.ToArray();

                    if (prov[0] == '0') { TRACKSTATUS_CNF = "Confirmed track"; }
                    else { TRACKSTATUS_CNF = "Track in initialisation phase"; }

                    if (prov[1] == '0') { TRACKSTATUS_TRE = "Default"; }
                    else { TRACKSTATUS_TRE = "Last report for a track"; }

                    int bit65 = Convert.ToInt32(String.Concat(prov[2], prov[3]));
                    if (bit65 == 0) { TRACKSTATUS_CST = "No extrapolation"; }
                    else if (bit65 == 1) { TRACKSTATUS_CST = "Predictable extrapolation due to sensor refresh period"; }
                    else if (bit65 == 10) { TRACKSTATUS_CST = "Predictable extrapolation in masked area"; }
                    else if (bit65 == 11) { TRACKSTATUS_CST = "Extrapolation due to unpredictable absence of detection"; }

                    if (prov[4] == '0') { TRACKSTATUS_MAH = "Default"; }
                    else { TRACKSTATUS_MAH = "Horizontal manoeuvre"; }

                    if (prov[5] == '0') { TRACKSTATUS_TCC = "Slant range correction and a suitable projection technique"; }
                    else { TRACKSTATUS_TCC = "Sensor plane  "; }

                    if (prov[6] == '0') { TRACKSTATUS_STH = "Measured position"; }
                    else { TRACKSTATUS_STH = "Smoothed position "; }

                    if (prov[prov.Length - 1] == '1')
                    {
                        i++;
                        DI_170_buffer2 = stringbinary[i];
                        char[] prov2 = DI_170_buffer2.ToArray();
                        int TOM = Convert.ToInt32(String.Concat(prov2[0],prov2[1]));
                        int DOU = Convert.ToInt32(String.Concat(prov2[2], prov2[3],prov2[4]));
                        int MRS = Convert.ToInt32(String.Concat(prov2[5], prov2[6]));

                        if (TOM == 0) { TRACKSTATUS_TOM = "Unknown type of movement"; }
                        else if (TOM == 1) { TRACKSTATUS_TOM = "Taking-off"; }
                        else if (TOM == 10) { TRACKSTATUS_TOM = "Lading"; }
                        else if (TOM == 11) { TRACKSTATUS_TOM = "Other types of movement"; }

                        if (DOU == 0) { TRACKSTATUS_DOU = "No doubt"; }
                        else if (DOU == 1) { TRACKSTATUS_DOU = "Doubtful correlation (undetermined reason)"; }
                        else if (DOU == 10) { TRACKSTATUS_DOU = "Doubtful correlation in clutter"; }
                        else if (DOU == 11) { TRACKSTATUS_DOU = " Loss of accuracy"; }
                        else if (DOU == 100) { TRACKSTATUS_DOU = "Loss of accuracy in clutter"; }
                        else if (DOU == 101) { TRACKSTATUS_DOU = "Unstable track"; }
                        else if (DOU == 110) { TRACKSTATUS_DOU = "Previously coasted"; }

                        if (MRS == 0) { TRACKSTATUS_MRS = "Merge or split indication undetermined "; }
                        else if (MRS == 1) { TRACKSTATUS_MRS = "Track merged by association to plot"; }
                        else if (MRS == 10) { TRACKSTATUS_MRS = "Track merged by non-association to plot "; }
                        else if (MRS == 11) { TRACKSTATUS_MRS = "Split track"; }

                        if (prov2[7] == '1')
                        {
                            i++;
                            DI_170_buffer3 = stringbinary[i];

                            if (DI_170_buffer3[0] == '0') { TRACKSTATUS_GHO = "Default"; }
                            else { TRACKSTATUS_GHO = "Ghost track"; }
                        }
                    }
                    DI_170 = false;
                }
                else if (DI_060 == true)//VERDADERO COMPROBAR
                {

                    DI_060_buffer1 = stringbinary[i];
                    i++;
                    DI_060_buffer2 = stringbinary[i];
                    DI_060 = false;

                    char[] oc1 = DI_060_buffer1.ToArray();
                    char[] oc2 = DI_060_buffer2.ToArray();
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
                else if (DI_220 == true)//VERDADERO COMPROBAR
                {
                    DI_220_buffer1 = stringbinary[i];
                    i++;
                    DI_220_buffer2 = stringbinary[i];
                    i++;
                    DI_220_buffer3 = stringbinary[i];
                    DI_220 = false;

                    if (stringhex[i].Count() == 1) { stringhex[i] = String.Concat("0", stringhex[i]); } //AÑADIMOS UN 0 SI SOLO HAY UNA LETRA O NÚMERO PORQUE EL 0 DESAPARECE AL PRINCIPIO
                    if (stringhex[i-1].Count() == 1) { stringhex[i - 1] = String.Concat("0", stringhex[i]); }
                    if (stringhex[i - 2].Count() == 1) { stringhex[i - 2] = String.Concat("0", stringhex[i]); }
                    ADDRESS = String.Concat(stringhex[i - 2], stringhex[i - 1], stringhex[i]);
                }
                else if (DI_245 == true)//VERDADERO COMPROBAR
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

                    string fulloctet = String.Concat(DI_245_buffer1, DI_245_buffer2, DI_245_buffer3, DI_245_buffer4, DI_245_buffer5, DI_245_buffer6, DI_245_buffer7);
                    char[] fulloctetchar = fulloctet.ToArray();
                    string oc1 = String.Concat(Convert.ToString(fulloctetchar[8]), Convert.ToString(fulloctetchar[9]), Convert.ToString(fulloctetchar[10]), Convert.ToString(fulloctetchar[11]), Convert.ToString(fulloctetchar[12]), Convert.ToString(fulloctetchar[13]));
                    string oc2 = String.Concat(Convert.ToString(fulloctetchar[14]), Convert.ToString(fulloctetchar[15]), Convert.ToString(fulloctetchar[16]), Convert.ToString(fulloctetchar[17]), Convert.ToString(fulloctetchar[18]), Convert.ToString(fulloctetchar[19]));
                    string oc3 = String.Concat(Convert.ToString(fulloctetchar[20]), Convert.ToString(fulloctetchar[21]), Convert.ToString(fulloctetchar[22]), Convert.ToString(fulloctetchar[23]), Convert.ToString(fulloctetchar[24]), Convert.ToString(fulloctetchar[25]));
                    string oc4 = String.Concat(Convert.ToString(fulloctetchar[26]), Convert.ToString(fulloctetchar[27]), Convert.ToString(fulloctetchar[28]), Convert.ToString(fulloctetchar[29]), Convert.ToString(fulloctetchar[30]), Convert.ToString(fulloctetchar[31]));
                    string oc5 = String.Concat(Convert.ToString(fulloctetchar[32]), Convert.ToString(fulloctetchar[33]), Convert.ToString(fulloctetchar[34]), Convert.ToString(fulloctetchar[35]), Convert.ToString(fulloctetchar[36]), Convert.ToString(fulloctetchar[37]));
                    string oc6 = String.Concat(Convert.ToString(fulloctetchar[38]), Convert.ToString(fulloctetchar[39]), Convert.ToString(fulloctetchar[40]), Convert.ToString(fulloctetchar[41]), Convert.ToString(fulloctetchar[42]), Convert.ToString(fulloctetchar[43]));
                    string oc7 = String.Concat(Convert.ToString(fulloctetchar[44]), Convert.ToString(fulloctetchar[45]), Convert.ToString(fulloctetchar[46]), Convert.ToString(fulloctetchar[47]), Convert.ToString(fulloctetchar[48]), Convert.ToString(fulloctetchar[49]));
                    string oc8 = String.Concat(Convert.ToString(fulloctetchar[50]), Convert.ToString(fulloctetchar[51]), Convert.ToString(fulloctetchar[52]), Convert.ToString(fulloctetchar[53]), Convert.ToString(fulloctetchar[54]), Convert.ToString(fulloctetchar[55]));

                    ACID_palabra = ACID(oc1, oc2, oc3, oc4, oc5, oc6, oc7,oc8); 
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
                else if (DI_090 == true)//VERDADERO COMPROBAR
                {
                    DI_090_buffer1 = stringbinary[i];
                    i++;
                    DI_090_buffer2 = stringbinary[i];
                    DI_090 = false;

                    string flighlvl = String.Concat(DI_090_buffer1[2], DI_090_buffer1[3], DI_090_buffer1[4], DI_090_buffer1[5], DI_090_buffer1[6], DI_090_buffer1[7], DI_090_buffer2);
                    FLIGHTLEVEL = Convert.ToDouble(Convert.ToInt32(flighlvl, 2)) / 4;
                
                
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
            //myTime = DateTime.ParseExact(Time, "HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);
            //roww = new DataRow(SAC, SIC, Message_type, "Target", myTime, X, Y, VX, VY, TRACKNUMBER, "Track Status", MODE_3A, ADDRESS, ACID_palabra, FLIGHTLEVEL);
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

        public string ACID(string oc1, string oc2, string oc3, string oc4, string oc5, string oc6, string oc7,string oc8)
        {
            string let1 = ACID_oneletter(oc1);
            string let2 = ACID_oneletter(oc2);
            string let3 = ACID_oneletter(oc3);
            string let4 = ACID_oneletter(oc4);
            string let5 = ACID_oneletter(oc5);
            string let6 = ACID_oneletter(oc6);
            string let7 = ACID_oneletter(oc7);
            string let8 = ACID_oneletter(oc8);

            string final = String.Concat(let1, let2, let3, let4, let5, let6, let7,oc8);
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
            dt.Rows.Add(SAC, SIC, Message_type, myTime, X, Y,coordinates, VX, VY, "Click for more information", TRACKNUMBER, "Click for more information", MODE_3A, ADDRESS, ACID_palabra, FLIGHTLEVEL);
            return dt;
        }
    }
}
