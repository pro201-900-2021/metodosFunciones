using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosFunciones
{
    class Cuadrado : Figura
    {
        private int lado;
        private static int cantidadDeLados = 4;

        public Cuadrado(int lado, string nombre = "Cuadrado") : base(nombre)
        {
            this.lado = lado;
            this.lados = cantidadDeLados;
        }

        public int GetLado() => lado;
        public void SetLado(int value) => lado = value;
        public int GetPerimetro() => lado * lados;
        public double GetArea() => Math.Pow(lado, 2);

        public static int GetLadosPorLey()
        {
            return cantidadDeLados;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", GetNombre(), lado, lados);
        }

        public override void MostrarMensaje()
        {
            Console.WriteLine("Mensaje desde {0}", typeof(Cuadrado).Name);
        }
    }
}
