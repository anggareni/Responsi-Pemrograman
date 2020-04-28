using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Theading.Tasks;

namespace ResponsiPemrograman2596
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan = new Karyawan(182012, "Angga", 500000);
            Karyawan karyawan2 = new Karyawan(182013, "Reni", -1000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Asiqqq naik gaji nih");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    