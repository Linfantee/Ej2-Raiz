using Ej2.Raiz.Servicios;

namespace Ej2.Raiz
{
    class Progam
    {

        static void Main(string[] args)
        {
            double raizCuadrada;
            NumeroInterfaz aka = new NumeroImplementacion();
            double ao = aka.peticionNumero();
            raizCuadrada = Math.Sqrt(ao);

            if (esEntero(raizCuadrada))
            {
                Console.WriteLine("la raíz cuadrada es entera, la raíz es:" + raizCuadrada);

            }
            else
            {
                Console.WriteLine("No es entera");
            }

            static bool esEntero(double aka)
            {
                return aka % 1 == 0;
            }





        }






    }


}