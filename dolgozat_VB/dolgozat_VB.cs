using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dolgozat_VB
{
    class FociVbk
    {
        public int[] orszag = new int [80];
        public string reszvetelszam;
        public string elso;
        public string utolso;
        public string legjobb;

       






    }



    class Program
    {
        static void Main(string[] args)
        {

            List<FociVBk> FociVBklista = new List<FociVbk>();
            string[] excel = File.ReadAllLines(fociVbk.csv);
            for (int i = 1; i < excel.Count(); i++)
            {

                Console.Write(FociVBklista[i].orszag + " ");
                for (int j = 0; j < 16; j++)
                {
                    Console.Write(FociVBklista[i].reszvetelszam[j] + " ");
                }
                Console.WriteLine();

            }

            if (orszag[i] > FociVBklista[i])
            {

            }

        }




    }
}
