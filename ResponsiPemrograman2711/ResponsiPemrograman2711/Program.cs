using System;

namespace ResponsiPemrograman2711
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan1 = new Karyawan(19112711, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(19112712, "Saripah", 4000000);


            Console.WriteLine("NIK \t Nama \t Gaji Bulanan");
            Console.WriteLine("--------------------------");
            karyawan1.newKaryawan();
            karyawan2.newKaryawan();

            Console.WriteLine("\n\n Asyiik Naik Gaji 10%");

            Console.WriteLine("NIK \t Nama \t Gaji Bulanan");
            Console.WriteLine("--------------------------");
            karyawan1.newGaji();
            karyawan2.newGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void newKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }

        public void newGaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }
    }
}