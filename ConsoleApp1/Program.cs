using System;
using System.Threading;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {

    static Random rnd = new Random();
        static void Main()
        {
            //Feladatok0201();
            //Feladatok0202();
            //Feladatok0203();
            //Feladatok0204();
            //Feladatok0204_b();
            //Feladatok0205();
            //Feledatok0207();
            //Feladatok0208();
            //Feladatok0209();
            //Feladatok0210();
            //Feladatok0211();
            //Feladatok0212();
            //Feladatok0213();
            //Feladatok0214();
            //Feladatok0215();
            //Feladatok0216();
            //Feladatok0217();
            //Feladatok0218();
            //Feladatok0219();
            //Feladatok0220();
            //Feladatok0221();
            //Feladatok0222();
            //Feladatok0223();
            //Feladatok0224();
            //Feladatok0225();
            //Feladatok0226();
            //Feladatok0227();
            //Feladatok0228();
            //Feladatok0229();
            //Feladatok0230();
            //Feladatok0231_a();
            //Feladatok0231_b();
            //Feladatok0232();
            Console.ReadKey();
        }


        private static void Feladatok0201()
        {
            Console.WriteLine("Névkiíró");
            Console.Write("Add meg a neved ");
            string nev = Console.ReadLine();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(nev);
            }
        }

        private static void Feladatok0202()
        {
            Console.WriteLine("Beírt szöveg * beírt szám");
            Console.Write("Adj meg egy szöveget: ");
            string szoveg = Console.ReadLine();
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= szam; i++)
            {
                Console.Write($"{szoveg}" + " ");
            }
        }

        private static void Feladatok0203()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.Clear();
            }

            Console.WriteLine("Helló");

            Thread.Sleep(3000);

            Console.Clear();
            Console.WriteLine("Nyomj bármilyen gombot a kilépéshez");
        }

        private static void Feladatok0204()
        {
            Console.WriteLine("Mozgó név");
            Console.Write("Add meg a neved ");
            string nevunk = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(nevunk);
                Thread.Sleep(500);
                Console.Clear();
            }
        }

        private static void Feladatok0204_b()
        {
            Console.WriteLine("Az ablakban ugráló név");
            Console.Write("Add meg a neved");
            string nevem = Console.ReadLine();
            Console.CursorVisible = false;
            Console.Clear();

            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;

            for (int i = 0; i < 100; i++)
            {
                int balrol = rnd.Next(szelesseg - nevem.Length);
                int fentrol = rnd.Next(magassag);

                Console.SetCursorPosition(balrol, fentrol);

                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);

                Console.WriteLine(nevem);
                Thread.Sleep(200);
                //Console.Clear();
            }
        }

        private static void Feladatok0205()
        {
            Console.WriteLine("Randomcsillag");
            Console.Clear();

            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;

            for (int i = 0; i < 200; i++)
            {
                int balrol = rnd.Next(szelesseg);
                int fentrol = rnd.Next(magassag);

                Console.SetCursorPosition(balrol, fentrol);

                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);

                Console.WriteLine("*");
                Thread.Sleep(200);

            }

        }

        private static void Feledatok0207()
        {
            Console.WriteLine("A számok négyzete 0-tól 30-ig");
            for (int i = 1; i < 31; i++)
            {
                Console.WriteLine($"{i} négyzete = " + i * i);
            }
        }

        private static void Feladatok0208()
        {
            Console.WriteLine("A kettő első 30 hatványa");
            for (int i = 1; i < 31; i++)
            {
                Console.WriteLine($"A kettő {i}. hatványa " + Math.Pow(2, i));
            }
        }

        private static void Feladatok0209()
        {
            Console.WriteLine("A 100-nál nem nagyobb páratlan számok: ");
            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i + " ");
            }
        }

        private static void Feladatok0210()
        {
            Console.WriteLine("A 100-nál nem nagyobb páratlan számok csökkenő sorrendben: ");
            for (int i = 99; i > 0; i -= 2)
            {
                Console.WriteLine(i + " ");
            }
        }

        private static void Feladatok0211()
        {
            Console.WriteLine("Számtani sorozat mely 10-el kezdődik és 7-el növekszik");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(10 + i * 7);
            }
        }

        private static void Feladatok0212()
        {
            Console.WriteLine("Saját számtani sorozat");
            Console.Write("Add meg a számtani sorozat első tagját: ");
            int elsotag = int.Parse(Console.ReadLine());
            Console.Write("Add meg a diferenciát: ");
            int dif = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("A számtani sorozatod: ");
            Console.WriteLine(elsotag);
            for (int i = 1; i < 31; i++)
            {
                Console.WriteLine(elsotag + i * dif);
            }
        }

        private static void Feladatok0213()
        {
            Console.WriteLine("Számtani sorozat");
            Console.Write("Add meg a számtani sorozat egyik tagját (kisebb): ");
            int egyiktag = int.Parse(Console.ReadLine());
            Console.Write("Add meg a számtani sorozat másik tagját (nagyobb): ");
            int masiktag = int.Parse(Console.ReadLine());
            Console.Clear();
            int diff = egyiktag - masiktag;
            Console.WriteLine("A számtani sorozatod előző és következő 10 tagja: ");
            for (int i = 11; i > 0; i--)
            {
                Console.WriteLine(egyiktag - i * diff);
            }
           
            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine(masiktag + i * diff);
            }
        }

        private static void Feladatok0214()
        {
            for (int i = -30; i < 30; i++)
            {
                Console.WriteLine("{0,3}C == {1, 5:0.0}", i, i*1.8+32);
            }
        }

        private static void Feladatok0215()
        {
            for (int i = 12; i < 99; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        private static void Feladatok0216()
        {
            Console.WriteLine("A megadott szám összes osztója: ");
            Console.Write("Kérem a számot: ");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    Console.WriteLine($"A megadott {szam} osztója: {i}, az osztás eredménye: {szam / i}");
                }
            }
        }

        private static void Feladatok0217()
        {
            Console.WriteLine("Prímszámteszt: ");
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int osztok = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    osztok += 1;
                }
            }
                if (osztok == 2)
                {
                    Console.WriteLine($"A megadott {szam} szám prímszám!");
                }
                else
                {
                    Console.WriteLine($"A megadott {szam} szám nem prímszám!");
                }
            
        }

        private static void Feladatok0218()
        {
            Console.WriteLine("Legnagyobb közös osztó");
            Console.Write("Kérem az első számot: ");
            int szám1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            int szám2 = int.Parse(Console.ReadLine());
            int osztó = 2;
            int közös = 0;
            while (osztó <= szám1 && osztó <= szám2)
            {
                if (szám1 % osztó == 0 && szám2 % osztó == 0)
                    közös = osztó;
                    osztó++;
            }
            if (közös == 0) Console.WriteLine("Nincs legnagyobb közös osztójuk.");
            else Console.WriteLine("Legnagyobb közös osztó: " + közös);



        }
        private static void Feladatok0219()
        {
            Console.WriteLine("Az összes háromjegyű szám, melynek az első és utolsó számjegye egyforma");
            for (int i = 100; i < 1000; i++)
            {
                string szam = Convert.ToString(i);
                char elso = szam[0];
                char utolso = szam[2];
                if (elso == utolso)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Feladatok0220()
        {
            Console.WriteLine("A Fibonacci sorozat első 10 eleme: ");
            int elso = 1;
            int masodik = 1;
            Console.Write(elso + " " + masodik + " ");
            for (int i = 3; i < 11; i++)
            {
                int köv = elso + masodik;
                Console.Write(köv + " ");
                elso = masodik;
                masodik = köv;

            }
        }

        private static void Feladatok0221()
        {
            int num, r, sum, temp;
            int stno, enno;
            Console.Write("Armstrong számok:\n");
            Console.WriteLine("Olyan háromjegyű számok, melyek számjegyeit külön-külön a harmadikra emelve és ezeket összeadva az eredeti számot kapjuk vissza!");
            Console.Write("--------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Add meg a kezdőértéket: ");
            stno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a végértéket: ");
            enno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Armstrong számok a megadott intervallumban: ");
            for (num = stno; num <= enno; num++)
            {
                temp = num;
                sum = 0;

                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == num)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }


        private static void Feladatok0222()
        {
            
            Console.WriteLine("Faktoriális");
            Console.Write("Kérem a számot: ");
            int szam = int.Parse(Console.ReadLine());
            int faktertek = 1;
            for (int i = 1; i <= szam; i++)
            {
                faktertek = faktertek * i;   
            }
            Console.WriteLine("A megadott ({0}) szám faktoriálisa: {1}", szam, faktertek);
        }

        private static void Feladatok0223()
        {
            Console.WriteLine("Száz dobókockadobás. Mennyi hatos?");
            int hatosok = 0;
            for (int i = 1; i <= 100; i++)
            {
                int dobas = rnd.Next(1, 7);
                if (dobas == 6) hatosok += 1;
            }
            Console.WriteLine("Hatos dobások száma: " + hatosok);
        }

        private static void Feladatok0224()
        {
            Console.WriteLine("Két dobókockával dobunk. Hányszor dobtunk 12-t?");
            int hatos = 0;
            for (int i = 1; i <= 20; i++)
            {
                int dobas_1 = rnd.Next(1, 7);
                int dobas_2 = rnd.Next(1, 7);
                if (dobas_1 == 6 && dobas_2 == 6) hatos += 1;
            }
            Console.WriteLine($"Összesen 12-t {hatos} alkalommal dobtunk");
        }

        private static void Feladatok0225()
        {
            Console.WriteLine("Az első 100 természetes szám összege: ");
            int elso = 1;
            int masodik = 2;
            for (int i = 3; i <= 101; i++)
            {
                Console.WriteLine($"{i-2}. {elso} + {masodik} = {elso + masodik}");
                elso = elso + masodik;
                masodik = i;
            }
        }

        private static void Feladatok0226()
        {
            Console.WriteLine("100 x dobunk fel egy dobókockát, mennyi az összeg?");
            int dobas_osszeg = 0;
            for (int i = 1; i <= 100; i++)
            {
                int dobas = rnd.Next(1, 7);
                dobas_osszeg += dobas;
                Console.WriteLine($"{i}. dobás: {dobas} --> Az aktuális dobásösszeg: {dobas_osszeg}");
            }
        }

        private static void Feladatok0227()
        {
            Console.WriteLine("Adj meg egy szöveget: ");
            string szoveg = Console.ReadLine();
            Console.WriteLine("_________________________________");
            List<string> authors = new List<string>(1);
            authors.Add(szoveg);
            Console.WriteLine("Original List items");
            Console.WriteLine("===============");
            foreach (string a in authors)
                Console.WriteLine(a);
            authors.Reverse();

            Console.WriteLine();
            Console.WriteLine("Sorted List items");
            Console.WriteLine("===============");
            foreach (string a in authors)
                Console.WriteLine(a);



        }

        private static void Feladatok0228()
        {
            Console.WriteLine("Nevünk átlósan: ");
            Console.Write("Kérem a neved: ");
            string nev = Console.ReadLine();
            string spaces = String.Empty;
            for (int i = 0; i < nev.Length; i++)
            {
                Console.WriteLine(spaces + nev[i]);
                spaces += " ";
            }
        }

        private static void Feladatok0229()
        {
            Console.WriteLine("Az első 10 szám faktoriálisa");
            for (int i = 1; i <= 10; i++)
            {
                int szam = i;
                int faktertek = 1;

                for (int j = 1; j <= szam; j++)
                {
                    faktertek = faktertek * j;
                }
                Console.WriteLine("{0} faktoriálisa: {1}", szam, faktertek);
            }
        }

        private static void Feladatok0230()
        {
            Console.WriteLine("500 nál kisebb prímszámok: ");
            for (int i = 1; i <= 500; i++)
            {
                int szam = i;
                int osztok = 0;
                for (int j = 1; j <= i; j++)
                {   
                    if (szam % j == 0)
                    {
                        osztok += 1;
                    }
                }
                if (osztok == 2)
                {
                Console.WriteLine(szam);
                }
                else
                {
                continue;
                }

            }
            

        }

        private static void Feladatok0231_a()
        {
            Console.WriteLine("Számok");
            int x = 1; 
            int y = 1;
            while (x < 10)
            {
                while (y <= x)
                {
                    Console.Write(x + " ");
                    y += 1;
                }
                Console.WriteLine();
                y = 1;
                x += 1;
            }
               
        }
        private static void Feladatok0231_b()
        {
            Console.WriteLine("Számok");
            int x = 9;
            int y = 1;
            while (x > 0)
            {
                while (y <= x)
                {
                    Console.Write(x + " ");
                    y += 1;
                }
                Console.WriteLine();
                y = 1;
                x -= 1;
            }

        }
        private static void Feladatok0232()
        {
            int x = 0;
            string t = "VAKÁCIÓ";
            while (x < t.Length)
            {
                for (int i = 0; i < t.Length - x; i++)
                {
                    Console.Write(t[i + x]);
                }
                Console.WriteLine();
                x += 1;
            }
        }


    }
    
}
