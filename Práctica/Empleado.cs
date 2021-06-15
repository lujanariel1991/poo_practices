using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica
{
    public class Empleado : Persona
    {
        public string Legajo { get; set; }
        public Empleado ()
        {
        }

        public Empleado (string name, int age, int weight, int height, string skin, string legajo) 
            : base (name, age, weight, height, skin)
        {
            Legajo = legajo;
        }

        public void Trabajar()
        {
            Console.WriteLine("{0} está trabajando", Nombre);

        }


    }
}
