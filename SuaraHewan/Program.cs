using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamaLengkap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            //Masukan nama panggilan kalian
            //jika benar, maka print Nama Lengkap, umur, dan asal
            //else : print "ini bukan nama saya"
            Console.WriteLine("Masukan nama panggilan : ");
            nama = Console.ReadLine();
            if (nama == "Dani")
            {
                Console.WriteLine("Dani Fatah");
                Console.WriteLine("Umur saya berapa 16 Tahun?");
                Console.WriteLine("Yogyakarta");
            } else if (nama == "Abdillah")
            {
                Console.WriteLine("Abdillah Hakim");
                Console.WriteLine("Umur saya berapa 15 Tahun?");
                Console.WriteLine("Cilacap");
            }
            else if (nama == "Rezy")
            {
                Console.WriteLine("Fahrezy Shiham Muttaki");
                Console.WriteLine("Umur saya berapa 16 Tahun?");
                Console.WriteLine("Kalimantan");
            }
            else if (nama == "Faikha")
            {
                Console.WriteLine("Faikha 'Adzroo Kaamila Q");
                Console.WriteLine("Umur saya berapa 16 Tahun?");
                Console.WriteLine("Yogyakarta");
            }
            else if (nama == "Kenjiro")
            {
                Console.WriteLine("Kenjiro Keiji Putra Hermawan");
                Console.WriteLine("Umur saya berapa 15 Tahun?");
                Console.WriteLine("Yogyakarta");
            }
            else if (nama == "Vieri")
            { 
                Console.WriteLine("Vieri Khairandy");
                Console.WriteLine("Umur saya berapa 16 Tahun?");
                Console.WriteLine("Yogyakarta");
            }
            else
            {
                Console.WriteLine("Kamu siapa");
            }
        }
    }
}
