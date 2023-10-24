using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Raiz.Servicios
{
    internal class NumeroImplementacion : NumeroInterfaz
    {

        public double peticionNumero()
        {

            double aka;
            Console.WriteLine("Introduzca número");
            aka = double.Parse(Console.ReadLine());     
            return aka;
        
        }

        
        
    }
}
