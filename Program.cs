using System.Diagnostics;

namespace contarNumeroPalabrasEnCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una frase");
            string parrafo = Console.ReadLine();
            Console.WriteLine("Numero de palaras (Split)" + parrafo.Split(" ").Count());
        }
    }
}
