using System;
using System.Collections.Generic;

namespace metodosFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Ingrese Número 1: ");
            int numero1;
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Número 2: ");
            int numero2;
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma de los números es {0}", Suma2numeros(numero1, numero2));
            */
            Cuadrado cuadrado = new Cuadrado(4);
            Console.WriteLine("Perímetro: {0}", cuadrado.GetPerimetro());
            Console.WriteLine("Area: {0}", cuadrado.GetArea());
            Console.WriteLine("Lados determinados por 'dios' {0}", Cuadrado.GetLadosPorLey());

            Console.WriteLine(cuadrado);
            cuadrado.MostrarMensaje();

            List<int> listaNumeros = new List<int>();

            RecorrerLista(listaNumeros);
            RecorrerLista(listaNumeros);
        }

        private static void RecorrerLista(List<int> lista)
        {
            foreach (int x in lista)
            {
                Console.WriteLine(x);
            }
        }


        //MÉTODO o FUNCIÓN
        private static int Suma2numeros(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }


    }
}
