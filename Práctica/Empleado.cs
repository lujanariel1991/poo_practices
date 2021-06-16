using System;

namespace Práctica
{
    public class Empleado : Persona
    {
        public string Legajo { get; set; }
        public string DatosEmpleado { get { return $"Mi nombre es {Nombre} Y mi número de legajo es {Legajo}"; } }

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
        public void Presentarse()
        {
            Console.WriteLine(DatosEmpleado);
        }
    }
}
