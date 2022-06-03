using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            kucing kucing1 = new kucing();//instantiasi object
            kucing1.jenis = "Persia";
            kucing1.usia = 10;
        }
    }
    class kucing
    {
        //Atribut class kucing //
        public string jenis;
        public string warna;
        public string suara;
        public int usia;//enkapsulasi

        //method class kucing//
        public void usia()
        {
            Console.WriteLine("apa" + this.jenis + "berusia" + this.usia);
        }
    }
}
