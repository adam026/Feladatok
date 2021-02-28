// *********** Tóth Ádám 2021.02.28 adamtoth4@gmail.com ************
using System;

namespace ConsoleApp2
{
    class Program
  
    {
        
        static Random rnd = new Random();

        static void Main()
        {
            //Feladatok0101();
            //Feladatok0102();
            //Feladatok0103();
            //Feladatok0104();
            //Feladatok0105();
            //Feladatok0106();
            //Feladatok0107();
            //Feladatok0108();
            //Feladatok0109();
            //Feladatok0110();
            //Feladatok0111();
            //Feladatok0112();
            //Feladatok0113();
            //Feladatok0114();
            //Feladatok0115();
            //Feladatok0116();
            //Feladatok0117();
            //Feladatok0118();
            //Feladatok0119();
            //Feladatok0120();
            //Feladatok0121();
            //Feladatok0122();
            //Feladatok0123();
            //Feladatok0124();
            //Feladatok0129();
            //Feladatok0130();
            //Feladatok0134();
            //Feladatok0135();
            //Feladatok0136();
            //Feladatok0137();
            //Feladatok0138();
            //Feladatok0139();
            //Feladatok0140();

            //DatumIdoF01();
            //RandomDolgok();
            Console.ReadKey();
        }
    

        private static void Feladatok0101()
        {
            Console.Write("Irányítószám? ");
            int irsz = int.Parse(Console.ReadLine());
            Console.Write("Város? ");
            string varos = Console.ReadLine();
            Console.Write("Közterület neve? ");
            string koztnev = Console.ReadLine();
            Console.Write("Közterület jellege? ");
            string koztjell = Console.ReadLine();
            Console.Write("Házszám? ");
            int hazszam = int.Parse(Console.ReadLine( ));
            Console.WriteLine("--------------------");
            Console.WriteLine($"Lakcím: {irsz} {varos} {koztnev} {koztjell} {hazszam}.");
        }

        private static void Feladatok0102()
        {
            Console.Write("1. Vezetéknév? ");
            string vez1 = Console.ReadLine();
            Console.Write("2. Vezetéknév? ");
            string vez2 = Console.ReadLine();
            Console.Write("1. Keresztnév ");
            string ker1 = Console.ReadLine();
            Console.Write("2. Keresztnév ");
            string ker2 = Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"{vez1} {ker1}; {vez1} {ker2}; {vez2} {ker2}; {vez2} {ker1}");
        }

        private static void Feladatok0103()
        {
            Console.Write("Add meg a havi fizetésed: ");
            int eves = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("Éves fizetésed: " + eves * 12);

        }

        private static void Feladatok0104()
        {
            Console.Write("Euró árfolyama? ");
            float eur = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("MEnnyi eurót szeretnél váltani? ");
            float valt = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Az átváltott euró {eur * valt} Ft");
        }

        private static void Feladatok0105()
        {
            Console.Write("Add meg a téglalap rövidebb oldalának hosszát (cm): ");
            int cm1 = int.Parse(Console.ReadLine());
            Console.Write("Add meg a téglalap hoszabb oldalának hosszát (cm): ");
            int cm2 = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"A téglalap kerülete: {2 * cm1 + 2 * cm2} cm, területe: {cm1 * cm2} cm2");
            //Kerület: 2* (a+b); Terület: ab 
        }

        private static void Feladatok0106()
        {
            Console.Write("Add meg a kör sugarát: ");
            float sugar = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"A kör területe: {Math.PI * Math.Pow(sugar, 2)} cm2; Kerülete: {2* Math.PI * sugar} cm");
            //Terület: pi*r2; KErülete 2*pi*r
        }

        private static void Feladatok0107()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------");
            int aNegyzet = (int)Math.Pow(a, 2);
            int bNegyzet = (int)Math.Pow(b, 2);
            int cNegyzet = aNegyzet + bNegyzet;
            double c = Math.Sqrt(cNegyzet);

            Console.WriteLine("c csak lassan = " + c);
        }

        private static void Feladatok0108()
        {
            Console.Write("Kérem a megtett út hosszát (méterben): ");
            float megtettut = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem az eltelt időt (percben): ");
            int elteltido = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Átlagsebesség: {megtettut / elteltido} m/s, ami {(megtettut / 1000) / (elteltido / 60)} km/h");

        }

        private static void Feladatok0109()
        {
            Console.Write("Kérem a kocsi fogyasztását (100km-en): ");
            float fogy = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Mennyi a benzin ára literenként? ");
            float ar = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Megtett út hossza (km-ben)? ");
            float ut = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Utiköltség: {(ut * (fogy / 100)) * ar} Ft");
        }

        private static void Feladatok0110()
        {
            Console.Write("súlyod: ");
            float kg = float.Parse(Console.ReadLine());
            Console.Write("magasságod ");
            float m = float.Parse(Console.ReadLine()) / 100;

            float tti = kg / (float)Math.Pow(m, 2);

            Console.WriteLine("Testtömegindexed alapján az alábbi testsúlykategóriába tartozol");

            if (tti < 16)           Console.WriteLine("Súlyos soványság");
            else if (tti < 17)      Console.WriteLine("Mérsékellt soványság");
            else if (tti < 18.5)    Console.WriteLine("Enyhe soványság");
            else if (tti < 25)      Console.WriteLine("Normális testsúly");
            else if (tti < 30)      Console.WriteLine("Túlsúlyos");
            else if (tti < 35)      Console.WriteLine("I fokú elhízás");
            else if (tti < 17)      Console.WriteLine("II fokú elhízás");
            else                    Console.WriteLine("III. fokú (súlyos) elhízás");
        }

        private static void Feladatok0111()
        {
            Console.WriteLine("Gyümölcsök: ");
            Console.WriteLine($"    Alma        |   Ára: 200 Ft");
            Console.WriteLine($"    Szilva      |   Ára: 300 Ft");
            Console.WriteLine($"    Szőlő       |   Ára: 400 Ft");
            Console.Write("Milyen gyümölcsöt szeretnél vásárolni? ");
            string gyumolcs = Console.ReadLine();
            Console.Write("Mennyit szeretnél vásárolni belőle? ");
            int kg = int.Parse(Console.ReadLine());
            if (gyumolcs == "Alma") Console.Write($"Fizetendő összeg: {kg * 200} Ft ");
            else if (gyumolcs == "Szilva") Console.Write($"Fizetendő összeg: {kg * 300} Ft ");
            else if (gyumolcs == "Szőlő") Console.Write($"Fizetendő összeg: {kg * 400} Ft ");
        }

        private static void Feladatok0112()
        {
            Console.WriteLine("Hordó térfogata(l): ");
            int hordo = int.Parse(Console.ReadLine());
            Console.WriteLine("Kancsó térfogata(l): ");
            int kancso = int.Parse(Console.ReadLine());

            Console.WriteLine($"{ hordo / kancso} teli kancsó mérhető ki");
            Console.WriteLine($"a hordóban {hordo % kancso } liter cucc marad");
            Console.WriteLine($"A hordó és a kancsó hányadosa: {0:0.00}", hordo / (float)kancso);
        }

        private static void Feladatok0113()
        {
            Console.WriteLine("Bankjegyautomata\n");
            Console.WriteLine("A legkisebb címlet 1000 Ft, a maximálisan felvehető összeg 300 000 Ft\n");
            Console.Write("Adja meg mekkora összeget kíván felvenni: ");
            int osszeg = int.Parse(Console.ReadLine());
            Console.WriteLine("A kiadott bankjegyek:\n ");
            int tizezres = osszeg / 10000;
            Console.WriteLine($"{tizezres} * 10 000 = {tizezres * 10000}");
            int maradek = osszeg - (10000 * tizezres);
            int otezres = maradek / 5000;
            Console.WriteLine($"{otezres} * 5 000 = {otezres * 5000}");
            int maradek2 = maradek - (5000 * otezres);
            int ezres = maradek2 / 1000;
            Console.WriteLine($"{ezres} * 1 000 = {ezres * 1000}");
            Console.WriteLine("_______________________________________");
            Console.WriteLine($"Összeg:          {osszeg} Ft");

        }

        private static void Feladatok0114()
        {
            Console.WriteLine("Üzemidő másodpercben: ");
            Console.WriteLine("Kérlek add meg az eszköz másodpercben mért üzemidejét: ");
            long sec = long.Parse(Console.ReadLine());
            TimeSpan elteltido = new TimeSpan(0, 0, (int)sec);
            Console.WriteLine($"{elteltido.Days}.{elteltido.Hours}:{elteltido.Minutes}:{elteltido.Seconds}");

        }

        private static void Feladatok0115()
        {
            Console.WriteLine("Utazási költségtérítés\n");
            Console.Write("Kérem adja meg az út hosszát km-ben: ");
            float uthossz = (float) Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem adja meg az autó fogyasztását 100 km-en (l-ben): ");
            float fogy = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem adja meg az üzemanyag árat literre számítva: ");
            float ar = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("_____________________________________");
            if (uthossz < 100 || uthossz == 100) Console.WriteLine($"Költségtérítés: {((uthossz * fogy) / 100) * ar}");
            else if (uthossz > 100) Console.WriteLine($"Költségtérítés: {(((uthossz * fogy) / 100) * ar) + 25 * uthossz}");

        }

        private static void Feladatok0116()
        {
            Console.WriteLine("Add meg a külső hőmérsékletet: ");
            float hom = (float)Convert.ToDouble(Console.ReadLine());
            if (hom == 0) Console.WriteLine("Fagypont!");
            else if (hom < 0) Console.WriteLine("Fagypont alatt!");
            else if (hom > 0) Console.WriteLine("Fagypont felett!");
              
        }

        private static void Feladatok0117()
        {
            Console.Write("Szeretsz porgramozni? ");
            string valasz = Console.ReadLine();
            if (valasz == "igen") Console.WriteLine("Még sokra viszed az életben!");
            else if (valasz == "nem") Console.WriteLine("Tanulj meg!");
            Console.WriteLine("Viszontlátásra!");
            Console.WriteLine("-------------------------------------------------");
        }

        private static void Feladatok0118()
        {
            Console.Write("Adj meg egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0) Console.WriteLine("Páros!");
            else Console.WriteLine("Páratlan!");
            Console.WriteLine("-------------------------------------------------");
        }

        private static void Feladatok0119()
        {
            Console.Write("Kérek egy számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            if (szam1 % 3 == 0) Console.WriteLine("Osztható hárommal!");
            else Console.WriteLine("Nem osztható hárommal!");
            Console.WriteLine("-------------------------------------------------");
        }

        private static void Feladatok0120()
        {
            Console.Write("A változatosság kedvéért kérek egy számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam2 == 0) Console.WriteLine("A szám a nulla!");
            else if (szam2 > 0) Console.WriteLine("A szám pozitív!");
            else if (szam2 < 0) Console.WriteLine("A szém negatív!");
            Console.WriteLine("-------------------------------------------------");
        }

        private static void Feladatok0121()
        {
            Console.Write("Kérem az első számot: ");
            int szam3 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            int szam4 = int.Parse(Console.ReadLine());
            if (szam3 > szam4) Console.WriteLine($"{szam3} > {szam4}");
            else if (szam3 == szam4) Console.WriteLine($"{szam3} = {szam4}");
            else if (szam3 < szam4) Console.WriteLine($"{szam3} < {szam4}");
            Console.WriteLine("-------------------------------------------------");
        }

        private static void Feladatok0122()
        {
            Console.Write("Kérek számot: ");
            float szam5 = (float)Convert.ToDouble(Console.ReadLine());
            if (-30 < szam5 || szam5 < 40) Console.WriteLine("A szám -30 és +40 közt van!");
            else Console.WriteLine("A szám kisebb mint -30 vagy nagyobb mint +40!");
        }

        private static void Feladatok0123()
        {
            Console.Write("Add meg a dolgozat pontszámát: ");
            int pontszam = int.Parse(Console.ReadLine());
            if (pontszam < 43) Console.WriteLine("Elégtelen");
            else if (42 < pontszam && pontszam < 58) Console.WriteLine("Elégséges");
            else if (57 < pontszam && pontszam < 73) Console.WriteLine("Közepes");
            else if (72 < pontszam && pontszam < 88) Console.WriteLine("Jó");
            else if (87 < pontszam && pontszam < 101) Console.WriteLine("Jeles");

        }

        private static void Feladatok0124()
        {
            Console.Write("Adj meg egy helyiségnevet: ");
            string hn = Console.ReadLine();
            Console.Write("Add meg a lakosságát: ");
            int lakossag = int.Parse(Console.ReadLine());
            Console.Write($"{hn} ");
            if (lakossag < 5000) Console.WriteLine("község");
            else if (lakossag > 4999 && lakossag < 20000) Console.WriteLine("kisváros");
            else if (lakossag > 19999 && lakossag < 100000) Console.WriteLine("középváros");
            else if (lakossag > 99999 && lakossag < 1000000) Console.WriteLine("nagyváros");
            else if (lakossag > 999999) Console.WriteLine("metropolis");
            else Console.WriteLine("Hibás adatbevitel");
        }

        private static void Feladatok0129()
        {
            Console.Write("Kérem az árú egységárát: ");
            float egysegar = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Mennyit kérsz (db) ? ");
            int darab = int.Parse(Console.ReadLine());
            Console.Write("Mennyi pénz van nálad? ");
            int penz = int.Parse(Console.ReadLine());

            if (penz > egysegar * darab) Console.WriteLine($"Visszajáró: {penz - egysegar * darab}");
            else if (penz < egysegar * darab) Console.WriteLine($"Nincs elég pénzed. {penz / egysegar} db ot tudunk adni ami {(penz / egysegar) * egysegar} Ft-ba kerül");
        }

        private static void Feladatok0130()
        {
            Console.Write("Kérem az évet: ");
            int ev = int.Parse(Console.ReadLine());
            if (ev % 100 == 0 || ev % 400 == 0) Console.WriteLine("Szökőév!");
            else if (ev % 4 == 0 && ev % 100 != 0) Console.WriteLine("Szökőév!");
            else Console.WriteLine("Nem szökőév!");
            
        }

        private static void Feladatok0131()
        {
            Console.WriteLine("Háromjegyű randomszámgenerátor: ");
            int v1 = rnd.Next(100, 1000);
            Console.WriteLine(v1);
        }

        private static void Feladatok0132()
        {
            Console.WriteLine("Egész szám és tizedestört generátor: ");
            int v2 = rnd.Next(0, 26);
            float v3 = rnd.Next(0, 26);
            Console.WriteLine($"Generált egész szám: {v2}; Generált tizedes tört: {v3}");
        }

        private static void Feladatok0134()
        {
            Console.WriteLine("0-100 közötti páros szám generátor");
            int v4 = rnd.Next(0, 100);
            if (rnd.Next(0, 100) % 2 == 0) Console.WriteLine(v4);
        }

        private static void Feladatok0135()
        {
            Console.WriteLine("Öttel osztható randomszám generátor");
            int v5 = rnd.Next(100, 201);
            if (rnd.Next(100, 201) % 5 == 0) Console.WriteLine(v5);
        }

        private static void Feladatok0136()
        {
            Console.WriteLine("Randomszám hosszúság eldöntő");
            int v6 = rnd.Next(0, 1000001);
            string v7 = v6.ToString();
            Console.WriteLine($"A generált szám: {v6}, számjegyeinek száma: {v7.Length}");

        }
        private static void Feladatok0137()
        {
            Console.WriteLine("Kockadobás generátor");
            int[] tomb = new int[6];
            for (int i = 0; i < 6; ++i)
            {
                tomb[i] = rnd.Next(1, 7);
            }

            for (int i = 0; i < 6; ++i)
            {
                Console.Write(tomb[i] + " ");
            }
        }

        private static void Feladatok0138()
        {
            Console.WriteLine("Lottószám generátor");
            int[] tomb = new int[6];
            for (int i = 0; i < 6; ++i)
            {
                tomb[i] = rnd.Next(1, 91);
            }

            for (int i = 0; i < 6; ++i)
            {
                Console.Write(tomb[i] + " ");
            }
        }

        private static void Feladatok0139()
        {
            int szam1 = rnd.Next(10, 51);
            int szam2 = rnd.Next(10, 51);

            Console.Write($"{szam1} + {szam2} = ");
            int megoldas = int.Parse(Console.ReadLine());
            if (megoldas == szam1 + szam2) Console.WriteLine("Helyes!");
            else Console.WriteLine("Helytelen!");
        }

        private static void Feladatok0140()
        {
            int generalt = rnd.Next(0, 101);
            Console.Write("Kérek egy számot: ");
            int beirt = int.Parse(Console.ReadLine());
            if (generalt == beirt) Console.WriteLine("Nyert!");
            else Console.WriteLine("Nem nyert!");
        }



        private static void DatumIdoF01()
        {
            Console.Write("Üzemidő másodpercben ");
            long sec = long.Parse(Console.ReadLine());

            //TimeSpan elteltido = new TimeSpan(sec * 10000000); //Működik
            TimeSpan elteltido = new TimeSpan(0, 0, (int)sec); //Működik
            //Console.WriteLine(elteltIdo) //Működik

            Console.WriteLine($"{elteltido.Days}.{elteltido.Hours}:{elteltido.Minutes}:{elteltido.Seconds}");

            TimeSpan ido01 = new TimeSpan(10, 10, 00);
            TimeSpan ido02 = new TimeSpan(2, 20, 00);
            Console.WriteLine(ido01 + ido02);

            DateTime szul = new DateTime(1995, 03, 27, 11, 20, 00);

            DateTime fog = szul - new TimeSpan(270, 0, 0, 0);

            Console.WriteLine($"Ádám fogantatása {fog}");

            Console.WriteLine(DateTime.Now - szul);

        }
        private static void RandomDolgok()
        {
            int[,] tomb = new int[5, 5];

            for (int sor = 0; sor < 5; ++sor)
            {
                for (int oszlop = 0; oszlop < 5; ++oszlop)
                {
                    tomb[sor, oszlop] = rnd.Next(100);
                }
            }

            for (int sor = 0; sor < 5; ++sor)
            {
                for (int oszlop = 0; oszlop < 5; ++oszlop)
                {
                    Console.WriteLine(tomb[sor, oszlop] + "\t");
                }
                Console.WriteLine();
            }


        }


    }
}   
