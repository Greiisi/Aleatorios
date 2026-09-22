using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorios
{
    internal class Program
    {
        static public int[] Generar_aleatorios(int n, int Valmin, int Valmax)
        {
            int[] N = new int[n];
            Random Var_Randon = new Random();
            for (int i = 0; i < n; i++)
            {
                N[i] = Var_Randon.Next(Valmin, Valmax + 1);
            }
            return N;
        }
        static public void escribir(int[] N)
        {
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write("[" + N[i] + "]\t");
            }
            Console.WriteLine();
        }
        static public void Ordenar_Asc(int[] N)
        {
            int aux;
            for (int i = 0; i < N.Length - 1; i++)
            {
                for (int j = 0; j < N.Length - 1 - i; j++)
                {
                    if (N[j] > N[j + 1])
                    {
                        aux = N[j];
                        N[j] = N[j + 1];
                        N[j + 1] = aux;
                    }
                }
            }
        }
        static public void Ordenar_Desc(int[] N)
        {
            int aux;
            for (int i = 0; i < N.Length - 1; i++)
            {
                for (int j = 0; j < N.Length - 1 - i; j++)
                {
                    if (N[j] < N[j + 1])
                    {
                        aux = N[j];
                        N[j] = N[j + 1];
                        N[j + 1] = aux;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numeros: ");

            int n = int.Parse(Console.ReadLine());

            int[] arreglo = Generar_aleatorios(n, 0, 20);

            Console.WriteLine("\n**************************");
            Console.WriteLine("LISTA DE ALEATORIOS (SIN ORDENAR)");
            Console.WriteLine("***************************");
            escribir(arreglo);
            Console.WriteLine("\n****************************");
            Console.WriteLine("ORDENAMIENTO DESCENDENTE (BURBUJA)");
            Console.WriteLine("****************************");
            Ordenar_Asc(arreglo);
            escribir(arreglo);
            Console.WriteLine("\n****************************");
            Console.WriteLine("ORDENAMIENTO DESCENDENTE (BURBUJA)");
            Console.WriteLine("****************************");
            Ordenar_Desc(arreglo);
            escribir(arreglo);
            Console.ReadKey();
        }
    }
}



