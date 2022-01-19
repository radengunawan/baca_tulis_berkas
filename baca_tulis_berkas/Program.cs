using System;
using System.IO;

namespace baca_tulis_berkas
{
    class Program
    {
        //start main
        static void Main(string[] args)
        {
            StreamWriter tls = new StreamWriter ("rahasia.txt");

            tls.WriteLine("I'll win over army");
            tls.WriteLine ("big plan by lier");
            tls.WriteLine("I'll unleash my army of clones upon the citizens of SL CIty.");

            string tempat_nya = "di mall";
            
            //start loop 1
            for (int angka = 1; angka <= 5 ; angka++)
            {
                tls.WriteLine("Clone #{0} attacks {1}", angka, tempat_nya);
                tempat_nya = (tempat_nya == "di mall") ? "downtown" : "di mall";
            }//end loop 1

            tls.Close(); //<-- needd always


        } //end main
    } //end class
}// end namespace
