using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {

        static Random rnd = new Random();
        static void Main()
        {
            //Feladatok0301v1();
            //Feladatok0301v2();
            //Feladatok0302();
            //Feladatok0303();
            //Feladatok0304();
            //Feladatok0305();
            //Feladatok0306();
            //Feladatok0307();
            //Feladatok0308();
            //Feladatok0309();
            //Feladatok0310();
            //Feladatok0311();
            Feladatok0312();
            Console.ReadKey();
        }

        private static void Feladatok0301v1()
        {
            // A)
            Console.WriteLine("1. Feladat: Nevek\n");
            Console.WriteLine("A)");
            string[] nevek = new string[5];

            nevek[0] = "Bianka";
            nevek[1] = "Emese";
            nevek[2] = "Zsuzsanna";
            nevek[3] = "Rita";
            nevek[4] = "Renáta";

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            Console.WriteLine("------------------------------------\n");

            foreach (string aktualisNev in nevek)
            {
                Console.WriteLine(aktualisNev);
            }
            //Ezzel a ciklussal a bejárt tömb nem szerkeszthető! Read only.

            // B)
            Console.WriteLine("----------------------------------");
            Console.WriteLine("B)");
            int[] magassagok = new int[5];

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write($"Add meg {nevek[i]} magasságát: ");
                magassagok[i] = int.Parse(Console.ReadLine());
            }

            // C)

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("C)");
            int sum = 0;

            foreach (int m in magassagok)
            {
                sum += m;
            }

            Console.WriteLine($"Átlagmagasság: {sum / (float)magassagok.Length}");

            // D) 

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("D)");
            Array.Sort(nevek, magassagok);

            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            // E)

            Console.WriteLine("---------------------------------");
            Console.WriteLine("E)");
            Array.Sort(magassagok, nevek);

            Console.WriteLine($"A legmagasabb {nevek[nevek.Length - 1]}, {magassagok.Last()} cm");
        }

        private static void Feladatok0301v2()
        {
            //string[] nevek = new string[] { "I. Béla", "II. Béla", "III. Béla", "IV. Béla", "V. Béla", };
            string[] nevek = { "I. Béla", "II. Béla", "III. Béla", "IV. Béla", "V. Béla", };

        }

        private static void Feladatok0302()
        {
            Console.WriteLine("2. Feladat");
            int[] tomb = new int[20];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(50, 151);
            }

            Array.Sort(tomb);
            int sum = 0;
            int c = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0,3} ", tomb[i]); // Makrózás
                if ((i + 1) % 5 == 0) Console.WriteLine("\n");
                sum += tomb[i];
                if (tomb[i] % 10 == 0) c++;
            }

            Console.WriteLine($"Elemek összege: {sum}");
            Console.WriteLine($"Elemek átlaga: {sum / (float)tomb.Length}");
            Console.WriteLine($"0-ra végződők száma: {c}");
        }

        private static void Feladatok0303()
        {
            Console.WriteLine("3. Feladat:");
            int[] t = new int[20];

            for (int i = 0; i < t.Length; i++)
            {
                int a = 10;
                t[i] = rnd.Next(a, 10 + ((i + 1) * 5));
                a = t[i];
                Console.Write($"{a} ");
            }
        }

        private static void Feladatok0304()
        {
            Console.WriteLine("4. Feladat");
            string[] nevek = new string[20];

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write("{0,2}. név: ", i + 1);
                string nev = Console.ReadLine();

                if (nev == "") break;
                else nevek[i] = nev;
            }

            Console.WriteLine("-----------------------------------");

            Array.Sort(nevek);

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write("{0,10}", nevek[i]);
                if (i % 5 == 0 && i != 0) Console.Write("\n");
            }



        }

        private static void Feladatok0305()
        {
            Console.WriteLine("5. Feladat");
            int[] t = new int[50];

            bool van13 = false;

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(5, 50) * 2 + 1;

                if (t[i] == 13)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    van13 = true;
                }

                Console.Write(t[i] + " ");
                Console.ResetColor();

                if ((i + 1) / 10 == 0) Console.Write("\n");
            }

            if (van13) Console.WriteLine("Van 13!");
            else Console.WriteLine("Nincs 13!");
        }

        private static void Feladatok0306()
        {
            Console.WriteLine("6. Feladat: 50 elemű tömb 2 jegyű, különböző véletlenszámokkal");
            int[] t = new int[50];

            for (int i = 0; i < t.Length;)
            {
                int x = rnd.Next(10, 100);

                if (!t.Contains(x))
                {
                    t[i] = x;
                    i++;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
                if ((i + 1) / 10 == 0) Console.Write("\n");
            }
        }

        private static void Feladatok0307()
        {
            Console.WriteLine("7. Feladat: Lottóhúzás");
            #region jatek
            int[] tippek = new int[5];

            Console.WriteLine("Milyen számokat szeretne megjátszani?");

            for (int i = 0; i < tippek.Length;)
            {
                Console.Write($"{i + 1} tipp: ");
                int tipp = int.Parse(Console.ReadLine());

                if (tipp >= 1 && tipp <= 90 && !tippek.Contains(tipp))
                {
                    tippek[i] = tipp;
                    i++;
                }
                else Console.WriteLine("Nem jó, próbáld újra!");
            }

            int[] osszesSzam = new int[90];
            #endregion

            #region sorsolas

            Console.WriteLine("\n------------------------------------------\n");
            for (int i = 0; i < osszesSzam.Length; i++)
            {
                osszesSzam[i] = i + 1;
            }

            for (int i = 0; i < osszesSzam.Length; i++)
            {
                int x = rnd.Next(osszesSzam.Length);
                int y = rnd.Next(osszesSzam.Length);

                int s = osszesSzam[x];
                osszesSzam[x] = osszesSzam[y];
                osszesSzam[y] = s;
            }

            int[] nyeroszamok = { osszesSzam[0], osszesSzam[1], osszesSzam[2], osszesSzam[3], osszesSzam[4], };
            
            #endregion

            #region eredmeny

            for (int i = 1; i < 90; i++)
            {
                if (nyeroszamok.Contains(i)) Console.BackgroundColor = ConsoleColor.Red;
                if (tippek.Contains(i)) Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("{0,2} ", i);
                Console.ResetColor();

                if (i % 10 == 0) Console.Write("\n");
            }

            int talalat = 0;

            foreach (var tipp in tippek)
            {
                if (nyeroszamok.Contains(tipp))
                {
                    talalat++;
                }
            }

            Console.WriteLine("\n------------------------------------------------\n");
            if (talalat > 1) Console.WriteLine("Nyertél!");
            Console.WriteLine($"\n\n Összesen {talalat} találatod volt!");
            #endregion

        }

        private static void Feladatok0308()
        {
            Console.WriteLine("8. Feladat: Átutalások száma:");
            int[] atutalasok = new int[12];
            Console.WriteLine("Kérjük adja meg az utalások számát az alábbi felbontásban: ");

            int osszatutalasok = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"{i+1} nap: ");
                atutalasok[i] = int.Parse(Console.ReadLine());
                osszatutalasok = osszatutalasok + atutalasok[i];
            }

            Console.WriteLine($"Az átutalások napi átlaga: {osszatutalasok / atutalasok.Length}");
        }

        private static void Feladatok0309()
        {
            Console.WriteLine("9. Feladat: Traffipax\n");
            int maxsebesseg = 90;
            int[] sebessegek = new int[10];
            string[] rendszamok = new string[10];
            int gyorshajtok = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. jármű rendszámát: ");
                string szam = Console.ReadLine();
                if (rendszamok[i] == "") break;
                else rendszamok[i] = szam;
                Console.Write($"Kérem a(z) {i + 1}. jármű sebességét: ");
                sebessegek[i] = int.Parse(Console.ReadLine());
                if (sebessegek[i] > maxsebesseg)
                {
                    gyorshajtok++;
                }
                Console.WriteLine("-------------------------------------------------\n");
            }

            if (gyorshajtok >= 1)
            {
                for (int i = 0; i < sebessegek.Length; i++)
                {
                    if (sebessegek[i] > maxsebesseg)
                    {
                        Console.WriteLine($"Gyorshajtó rendszáma: {rendszamok[i]}, sebessége: {sebessegek[i]}\n");
                    }
                }
            }
            else Console.WriteLine("Nem volt gyorshajtó!");
        }

        private static void Feladatok0310()
        {
            Console.WriteLine("10 Feladat: Diákok és az internet");

            string[] diakok = new string[10];
            int[] idok = new int[10];
            int osszido = 0;
            int neminternetezo = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Kérem adja meg a nevét: ");
                diakok[i] = Console.ReadLine();
                idok[i] = rnd.Next(10);
                osszido = osszido + idok[i];
                if (idok[i] == 0)
                {
                    neminternetezo += 1;
                }


            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"A diákok átlagosan {osszido/diakok.Length} órát interneteznek.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("2 óránál többet internetező diákok: ");
            for (int i = 0; i < 10; i++)
            {
                if (idok[i] > 2)
                {
                    Console.WriteLine($"{diakok[i]} - internetezéssel töltött idő: {idok[i]} óra");
                }
                    
            }

            Console.WriteLine("--------------------------------------");

            if (neminternetezo > 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (idok[i] == 0)
                    {
                        Console.WriteLine($"{diakok[i]} nem internetezik!");
                    }
                }           
            }
           
            else Console.WriteLine("Nincs olyan diák aki ne internetezne!");
        }

        private static void Feladatok0311()
        {
            Console.WriteLine("11. Feladat: ");

            double[] tomb = new double[40];
            int paros = 0;
            int paratlan = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = (i * i) % 6.0;
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0,2} ", tomb[i]);
                if ((i + 1) % 5 == 0) Console.Write("\n");
                else if (tomb[i] % 2 == 0) paros += 1;
                else if (tomb[i] % 2 != 0) paratlan += 1;
            }

            Console.WriteLine("----------------------------");
            if (paros > paratlan)
            {
                Console.WriteLine("A tömb elemei közt több páros van mint páratlan!");
            }
            else Console.WriteLine("A tömb elemei közt több páratlan van mint páros!");

        }

        private static void Feladatok0312()
        {
            Console.WriteLine("12. Feladat - A Török szultán");
            int[] tomb = new int[100];
            string[] tomb_2 = new string[100];

            for (int i = 0; i < 100; i++)
            {
                tomb[i] = i + 1;
                tomb_2[i] = "Nyitva";
            }

            for (int i = 0; i < tomb_2.Length; i++)
            {
                Console.Write($"{tomb_2[i]}  ");
                if ((i + 1) % 10 == 0)
                {
                    Console.Write("\n");
                }
            }

            Console.WriteLine("--------------------------------------------------------------------------------------");

            for (int i = 0; i < 100; i += 2)
            {
                tomb_2[i + 1] = "Zarva";
            }

            for (int i = 0; i < tomb_2.Length; i++)
            {
                Console.Write($"{tomb_2[i]}  ");
                if ((i + 1) % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");

            for (int i = 3; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if ((j + 1) % i == 0 && tomb_2[j] == "Zarva") tomb_2[j] = "Nyitva";
                    else if ((j + 1) % i == 0 && tomb_2[j] == "Nyitva") tomb_2[j] = "Zarva";
                }
            }
           
            Console.WriteLine("A Nyitva maradt cellák: " + "\n");
            for (int i = 0; i < tomb_2.Length; i++)
            {
                Console.Write($"{tomb_2[i]}  ");
                if ((i + 1) % 10 == 0)
                {
                    Console.Write("\n");
                }
            }




        }
    }


}
