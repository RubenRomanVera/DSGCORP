using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Caracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se escribe los caracteres
            Console.WriteLine("Ingrese los caracteres: ");
            string e= Console.ReadLine();

            //Se declaran las variables
            string ma = "";
            string mi = "";
            string d = "";
            string ce = "";
            var regexItem = new Regex("[!@#$%^&*(),.?\":{}|<>]"); //se utiliza un regex de solo caracteres especiales

            //Se inicializan las variables numericas
            int nma = 0;
            int nmi = 0;
            int nd=0;
            int nce=0;

            for (int i=0;i<e.Length;i++)
            {
                if (char.IsUpper(e[i]))
                {
                    nma++;
                    ma+= e[i];
                }
                if (char.IsLower(e[i]))
                {
                    nmi++;
                    mi += e[i];
                }
                if (char.IsDigit(e[i]))
                {
                    nd++;
                    d += e[i];
                }
                    if (regexItem.IsMatch(e[i].ToString()))
                    {
                        nce++;
                        ce += e[i];
                    }
            }
            Console.WriteLine("Cadena original: "+e);
            Console.WriteLine("Mayusculas: " + nma);
            Console.WriteLine("Minusculas: " + nmi);
            Console.WriteLine("Digitos: " + nd);
            Console.WriteLine("Caracteres especiales: " + nce);
            Console.ReadKey();
        }
    }
}
