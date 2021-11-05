using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosFunciones
{
    class Figura
    {
        protected int lados;
        private string nombre;

        public Figura(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre() => nombre;
        public int GetLados() => lados;
        public void SetNombre(string value) => nombre = value;

        public virtual void MostrarMensaje()
        {
            Console.WriteLine("Mensaje desde {0}", typeof(Figura).Name);
        }
    }
}
