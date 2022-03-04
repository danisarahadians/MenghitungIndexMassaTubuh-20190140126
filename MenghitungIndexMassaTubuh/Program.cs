using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenghitungIndexMassaTubuh
{
    class Program
    {
        /// <summary>
        /// main class
        /// </summary>
        /// <param name="args">Index Massa Tubuh</param>
        /// <remarks>Menampilkan Index Massa tubuh apakah Ideal atau tidak dengan beberapa indikasi sesuai tinggi dan berat badan</remarks>
        static void Main(string[] args)
        {
            Console.WriteLine(
           " ┌──────────────────────────────────────────────────────────────┐\n" +
           " │    SELAMAT DATANG DI APLIKASI PENGHITUNG INDEKS MASSA TUBUH  │\n" +
           " │                SILAHKAN MENGISI DATA DIBAWAH INI             │\n" +
           " └──────────────────────────────────────────────────────────────┘\n");
            int berat, tinggi;
            float IMT;

            Console.Write(
                   "┌──────────────────────────────────────────────────────────────┐\n" +
                   "│                  MASUKKAN BERAT BADAN ANDA (kg)              │\n" +
                   "└──────────────────────────────────────────────────────────────┘\n");
            berat = Convert.ToInt32(Console.ReadLine());

            Console.Write(
                "┌──────────────────────────────────────────────────────────────┐\n" +
                "│                  MASUKKAN TINGGI BADAN ANDA (cm)             │\n" +
                "└──────────────────────────────────────────────────────────────┘\n");
            tinggi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            
            tinggi = tinggi / 100;
            IMT = (float)berat / (tinggi * tinggi);

            if (IMT < 14.9)
                Console.Write("\"INDIKASI  BUSUNG LAPAR\"");
            else

            if (IMT >= 15 && IMT <= 18.4)
                Console.Write("\"ANDA KURUS, PERBANYAK MAKANAN BERSERAT DAN RAJIN BEROLAHRAGA\"");
            else

            if (IMT >= 18.5 && IMT <= 22.9)
                Console.Write("\"ANDA SUDAH BERADA PADA TUBUH IDEAL, PERTAHANKAN POLA HIDUP ANDA\"");
            else

            if (IMT >= 23 && IMT <= 27.5)
                Console.Write("\"ANDA GEMUK, RAJINLAH BEROLAHRAGA\"");
            else

            if (IMT >= 27.6 && IMT <= 40)
                Console.Write("\"ANDA TERLALU GEMUK, RAJINLAH BEROLAHRAGA DAN KONSUMSI MAKANAN SEHAT\"");
            else

            if (IMT > 40)
                Console.Write("\"BAHAYA !!! ANDA SUDAH OBESITAS, RAJINLAH BEROLAHRAGA DAN KONSUMSI MAKANAN SEHAT\"");
           

            Console.ReadKey();

           
        }
    }
}
