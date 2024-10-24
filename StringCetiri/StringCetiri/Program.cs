using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCetiri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            
            string[] rijeci = recenica.Split(' ');

            
            if (rijeci.Length > 0)
            {
                
                string prvaRijec = rijeci[0];
                
                string zadnjaRijec = rijeci[rijeci.Length - 1];

                
                Console.WriteLine("Prva riječ: " + prvaRijec);
                Console.WriteLine("Zadnja riječ: " + zadnjaRijec);
            }
            else
            {
                Console.WriteLine("Niste unijeli važeću rečenicu.");
            }
        }
    }
}
