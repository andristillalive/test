using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class listMobil
    {
        public int IDRegistrasi
        {
            get;
            set;
        }
        public string Tipe
        {
            get;
            set;
        }
        public string Merk
        {
            get;
            set;
        }
        public string Varian
        {
            get;
            set;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Mobil();
            BermainAngka();
            Console.ReadLine();
        }

        public static void Mobil()
        {
            IEnumerable<listMobil> ListMobil = new listMobil[] {
                new listMobil { IDRegistrasi = 0001, Tipe = "Sedan", Merk = "Toyota", Varian = "FT86"},
                new listMobil { IDRegistrasi = 0002, Tipe = "SUV", Merk = "Toyota", Varian = "RAV4"},
                new listMobil { IDRegistrasi = 0003, Tipe = "Sedan", Merk = "Honda", Varian = "Accord"},
                new listMobil { IDRegistrasi = 0004, Tipe = "SUV", Merk = "Honda", Varian = "CRV"},
                new listMobil { IDRegistrasi = 0005, Tipe = "Sedan", Merk = "Honda", Varian = "City"},
            };
            // Isi code dibawah
            //Soal Nomor 1
            Console.WriteLine("Soal Nomor 1");
            listMobil lm = ListMobil.FirstOrDefault(p => p.Merk == "Honda");
            if (lm != null)
            {
                Console.Write("ID Registrasi = " + lm.IDRegistrasi + ", Merk = " + lm.Merk + ", Varian = " + lm.Varian);
            }
            Console.WriteLine("\n");

            //Soal Nomor 2
            Console.WriteLine("Soal Nomor 2");
            listMobil lm2 = ListMobil.LastOrDefault(q => q.Merk == "Honda" && q.Tipe == "Sedan");
            if (lm2 != null)
            {
                Console.Write("ID Registrasi = " + lm2.IDRegistrasi + ", Merk = " + lm2.Merk + ", Varian = " + lm2.Varian);
            }
            Console.WriteLine("\n");

            //Soal Nomor 3
            Console.WriteLine("Soal Nomor 3");
            listMobil lm3 = ListMobil.FirstOrDefault(q => q.Merk == "Honda" && q.Varian == "City");
            if (lm3 != null)
            {
                Console.Write("ID Registrasi = " + lm3.IDRegistrasi + ", Merk = " + lm3.Merk + ", Varian = " + lm3.Varian);
            }
            Console.WriteLine("\n");

            //Soal Nomor 4
            Console.WriteLine("Soal Nomor 4");
            IEnumerable<listMobil> lm4 = ListMobil.Where(q => q.Merk == "Toyota");
            foreach (listMobil x in lm4)
            {
                Console.WriteLine("ID Registrasi = " + x.IDRegistrasi + ", Merk = " + x.Merk + ", Varian = " + x.Varian);
            }
            Console.WriteLine("\n");

            //Soal Nomor 5
            Console.WriteLine("Soal Nomor 5");
            IEnumerable<listMobil> lm5 = ListMobil.OrderBy(p => new Random().Next()).Take(3);
            foreach (listMobil x in lm5)
            {
                Console.WriteLine("ID Registrasi = " + x.IDRegistrasi + ", Merk = " + x.Merk + ", Varian = " + x.Varian);
            }
            Console.WriteLine("\n");
        }

        public static void BermainAngka()
        {
            DateTime start = DateTime.Now;
            bool a = true; string at = "A";
            bool b = false; string bt = "B";
            bool c = false; string ct = "C";
            //for(int i = 1; i <= 5000; i++)
            for (int i = 1; i <= 500; i++)
            {
                string player = "";
                //if ((DateTime.Now - start).TotalMinutes >= 0.01)
                if ((DateTime.Now - start).TotalMinutes >= 5)
                {
                    if (a == true)
                    {
                        player = at;
                        a = false;
                        b = true;
                    }
                    else if (b == true)
                    {
                        b = false;
                        c = true;
                        player = bt;
                    }
                    else if (c == true)
                    {
                        c = false;
                        a = true;
                        player = ct;
                    }

                    if (i % 3 == 0)
                        Console.WriteLine(player + ": tik");
                    else if (i % 5 == 0)
                        Console.WriteLine(player + ": tek");
                    else if (i % 7 == 0)
                        Console.WriteLine(player + ": tok");
                    else
                        Console.WriteLine(player + ": " + i);
                }
                else
                {
                    if (a == true)
                    {
                        a = false;
                        b = true;
                        player = at;
                    }
                    else if (b == true)
                    {
                        b = false;
                        a = true;
                        player = bt;
                    }

                    if (i % 3 == 0)
                        Console.WriteLine(player + ": tik");
                    else if (i % 5 == 0)
                        Console.WriteLine(player + ": tek");
                    else
                        Console.WriteLine(player + ": " + i);
                }
            }

            double timelapse = (DateTime.Now - start).TotalMinutes;

            Console.WriteLine("Time Lapse = " + timelapse);
        }
    }
}
