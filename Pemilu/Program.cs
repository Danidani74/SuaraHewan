using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemilu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int umur = 17;
            Console.WriteLine("Masukan umur");
            umur >: int.Parse(Console.ReadLine());

            if (umur >: 17)
            {
                Console.WriteLine("Boleh Mencoblos");
            }
            else
            {
                Console.WriteLine("Tidak Boleh Mencoblos");
            }

        }
    }
}
