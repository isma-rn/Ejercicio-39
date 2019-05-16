using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E39_ElevarA_a_B
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool salir = false;
            string opcion;
            int numero, potencia;                        
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Programa que calcula la potencia de un número");
                do
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Ingrese la base");
                    if (Int32.TryParse(Console.ReadLine(), out int auxiliarNumero))
                    {
                        numero = auxiliarNumero;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, ingresa un número");
                    }
                        
                } while (true);

                do
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Ingrese la potencia");                    
                    if (Int32.TryParse(Console.ReadLine(), out int auxiliarPotencia))
                    {
                        potencia = auxiliarPotencia;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, ingresa un número");
                    }
                } while (true);

                Console.WriteLine("Resultado = {0}", ElevarAPotencia( numero, potencia));
                Console.WriteLine("Resultado (Math.Pow)= {0}", Math.Pow(numero, potencia));
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);
            } while (!salir);            
        }
        private static double? ElevarAPotencia(int numero, int exponente)
        {
            if (numero != 0 && exponente != 0 || numero == 1)
            {
                double resultado = numero;
                int auxiliarExponente = exponente < 0 ? -1 * exponente : exponente;
                for (int i = 1; i < auxiliarExponente; i++)
                    resultado *= numero;
                return (exponente < 0) ? (1 / resultado) : resultado;
            }
            return 1;
        }
    }
}
