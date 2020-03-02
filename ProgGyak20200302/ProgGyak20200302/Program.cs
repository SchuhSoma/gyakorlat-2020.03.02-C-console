using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgGyak20200302
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------------------------\n");
            Feladat1BankiKamat();
            Console.WriteLine("\n-------------------------------\n");
            Feladat2HettelOszthatoHaromJegyu();
            Console.WriteLine("\n-------------------------------\n");
            Feladat3OttelOszthatokOsszege();
            Console.WriteLine("\n-------------------------------\n");
            Feladat4KetovelOszthatokSzama();
            Console.WriteLine("\n-------------------------------\n");
            Feladat5Jatek();
            Console.WriteLine("\n-------------------------------\n");
            Feladat6Gomb();
            Console.WriteLine("\n-------------------------------\n");
            Feladat7Meterologia();
            Console.WriteLine("\n-------------------------------\n");
            Feladat8NegyHatvany();
            Console.WriteLine("\n-------------------------------\n");
            Feladat9Szemuveg();
            Console.WriteLine("\n-------------------------------\n");
            Console.ReadKey();
        }

        private static void Feladat9Szemuveg()
        {
            Console.WriteLine("9.Feladat: látás minőség");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            Console.Write("Kérem adja meg a dioptria számát: ");
            double Dioptria = double.Parse(Console.ReadLine());
            if(0<=Dioptria && Dioptria<=1)
            {
                Console.WriteLine("{0} az ön látása jó", Nev);
            }           
            if (1 < Dioptria && Dioptria <= 2)
            {
                Console.WriteLine("{0} az ön látása átlagos", Nev);
            }
            if (2 < Dioptria && Dioptria <= 3)
            {
                Console.WriteLine("{0} az ön látása kicsit gyenge", Nev);
            }
            if (3 < Dioptria && Dioptria <= 4)
            {
                Console.WriteLine("{0} az ön látása gyenge", Nev);
            }
            if (4 < Dioptria && Dioptria <= 5)
            {
                Console.WriteLine("{0} az ön látása nagyon gyenge", Nev);
            }
            if (5 < Dioptria && Dioptria <= 6)
            {
                Console.WriteLine("{0} az ön látása nagyon-nagyon gyenge", Nev);
            }

        }

        private static void Feladat8NegyHatvany()
        {
            Console.WriteLine("8.Feladat: Írja ki a képernyőre a négy első 12 hatványát");
            double Ertek = 0;
            for (int i = 1; i <= 12; i++)
            {
                Ertek = Math.Pow(4, i); 
                if(i%2==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t{0,-2}. hatvány := {1}",i,Ertek);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine("\t{0,-2}. hatvány := {1}", i, Ertek);
                }
            }
        }

        private static void Feladat7Meterologia()
        {
            Console.WriteLine("7.Feladat Meterológia intézet");
            int Csapadek;
            double Osszeg = 0;
            double Atlag = 0;
            int db = 0;
            for (int i = 1; i < 22; i++)
            {
                Csapadek = rnd.Next(33,76);                
                Osszeg += Csapadek;
                Atlag = Osszeg / 21;
                if(Csapadek>55)
                {
                    db++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t{0,-2} .nap csapadék mennyiség: {1}", i, Csapadek);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine("\t{0,-2} .nap csapadék mennyiség: {1}", i, Csapadek);
                }
            }
            Console.WriteLine("\n\tEnnyi nap volt 55mm feletti a csapadék mennyisége: {0}",db);
            Console.WriteLine("\tA csapadék átlag mennyisége: {0:0.00} mm",Atlag);

        }

        private static void Feladat6Gomb()
        {
            Console.WriteLine("6.Feladat: Gömb felszíne, térfogata");
            Console.WriteLine("\tKérem adja meg a Gönb sugarát: ");
            double Sugar = double.Parse(Console.ReadLine());
            double Terfogat = (4 * Math.PI * Math.Pow(Sugar, 3)) / 3;
            Console.WriteLine("\tA gömb térfogata: {0:0.00} cm^3", Terfogat);
            double Felszin = (4 * Math.PI * Math.Pow(Sugar, 2));
            Console.WriteLine("\tA gömb felszíne: {0:0.00} cm^2", Felszin);
        }
        private static void Feladat5Jatek()
        {
            Console.WriteLine("5.Feladat: Készítsen Játékot");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            Console.Write("Kérem adjon meg egy számot 1-10 között: ");
            int JatekosSzam = int.Parse(Console.ReadLine());
            int GeneraltSzam = rnd.Next(1, 11);
            if(JatekosSzam>GeneraltSzam)
            {
                Console.WriteLine("Állás \n\tJátékos száma: {0}\tGép által csinált szám: {1}",JatekosSzam,GeneraltSzam);
                Console.WriteLine("\tGratulálok {0} ön nyert");
            }
            else
            {
                Console.WriteLine("Állás \n\tJátékos száma: {0}\tGép által csinált szám: {1}", JatekosSzam, GeneraltSzam);
                Console.WriteLine("\tSajnálom {0} , ön nem nyert");
            }
           
        }
        private static void Feladat4KetovelOszthatokSzama()
        {
            Console.WriteLine("4.Feldat: Öttel osztható kétjegyü ami kettővel osztható");
            int OttelOszthato;
            int db = 0;
            Console.WriteLine("Öttelosztható kétjegyű számok:");
            for (int i = 2; i < 20; i++)
            {
                OttelOszthato = 5 * i;
                if (OttelOszthato%2==0)
                {
                    db++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0}, ", OttelOszthato);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write("{0}, ", OttelOszthato);
                }
                Console.Write("{0}, ", OttelOszthato);
            }
            Console.WriteLine("\nÖttel és kettővel is osztható száma: {0}",db);
        }

        private static void Feladat3OttelOszthatokOsszege()
        {
            Console.WriteLine("3.Feldat: Öttel osztható kétjegyü számok összege");
            int OttelOszthato;
            int Osszeg = 0;
            Console.WriteLine("Öttelosztható kétjegyű számok:");
            for (int i = 2; i < 20; i++)
            {
                OttelOszthato = 5 * i;
                Osszeg += OttelOszthato;
                Console.Write("{0}, " , OttelOszthato);
            }
            Console.WriteLine("\nÖttel osztható kétjegyű számok összege: {0}", Osszeg);
        }

        private static void Feladat2HettelOszthatoHaromJegyu()
        {
            Console.WriteLine("2.Feladat: Héttel osztható háromjegyű számok kiiratása");
            int Szam;
            for (int i = 100; i <= 999; i++)
            {
                Szam = i;
                if (Szam % 7 == 0)
                {
                    Console.Write("{0} , ",Szam);
                }

            }
        }

        private static void Feladat1BankiKamat()
        {
            Console.WriteLine("1.Feladat: Banki kamat kiszámítás");
            Console.Write("Kéem adja meg mkkora összeget kíván lekötni: ");
            double LekotottOsszeg = double.Parse(Console.ReadLine());
            Console.Write("Kéem adja meg mennyi időre szeretné lekötni: ");
            int CiklusVege=int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg milyen kamatre szeretné lekötni: ");
            double KamatSzazalek= double.Parse(Console.ReadLine());
            double KamatSzorzo = (100 + KamatSzazalek) / 100;
            double VegOsszeg = 0;
            for (int i = 1; i <= CiklusVege; i++)
            {
                VegOsszeg = LekotottOsszeg * Math.Pow(KamatSzorzo, i);
                Console.WriteLine("{0}. év Végöszege: {1:0.00} Ft",i,VegOsszeg);
            }
        }
    }
}
