using System;
using System.Collections.Generic;

namespace P4_Listasynumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numerosArreglo = new int [5] {1, 2, 3, 4, 5}; 
            numerosArreglo[1] = 6;
            numerosArreglo[numerosArreglo.Length - 1] = 7;
            
            
            for (int i = 0; i < numerosArreglo.Length - 1; i++)
            {
                numerosArreglo[i] = numerosArreglo[i + 1];
            }

            numerosArreglo[4] = 8;
            
            for (int i = 0; i < numerosArreglo.Length; i++)
            {
                Console.WriteLine(numerosArreglo[i]);
            }

            Console.WriteLine("\n--------\n");

            List<int> numerosLista = new List<int>();
            numerosLista.Add(1);
            numerosLista.Add(2);
            numerosLista.Add(3);
            numerosLista.Add(4);
            numerosLista.Add(5);
            numerosLista[1] = 6;
            numerosLista[numerosLista.Count - 1] = 7;
            numerosLista.Remove(1);
            numerosLista.Add(8);
            numerosLista.Add(9);

            
            for (int i = 0; i < numerosLista.Count; i++)
            {
                numerosLista[i] = numerosLista[i]*3;
            }

            for (int i = numerosLista.Count -1; i >= 0; i--)
            {
                if (numerosLista[i] > 20)
                {
                    numerosLista.RemoveAt(i);
                }
            }
            
            for (int i = 0; i < numerosLista.Count; i++)
            {
                Console.WriteLine(numerosLista[i]);
            }

            Console.WriteLine("\n--------\n");
                       
            List<int> numerosLista2 = new List<int>();
            numerosLista2.Add(2);
            numerosLista2.Add(6);
            numerosLista2.Add(19);
            numerosLista2.Add(34);
            numerosLista2.Add(65);
            numerosLista2.Add(12);
            numerosLista2.Add(42);
            numerosLista2.Add(33);
            numerosLista2.Add(40);
            numerosLista2.Add(15);
            
            int mayor = numerosLista2[0];
            for (int i = 0; i < numerosLista2.Count; i++)
            {
                if (numerosLista2[i] > mayor)
                {
                    mayor = numerosLista2[i];
                }
            }

            Console.WriteLine("El número mayor es: " + mayor);
            
            for (int i = 0; i < numerosLista2.Count; i++)
            {
                Console.WriteLine(numerosLista2[i]);
            }
        }
    }
}
