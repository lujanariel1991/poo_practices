using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica
{
    public class Medico : Empleado
    {
        public string Matricula { get; set; }
        public string Especialidad { get; set; }

        public Medico() 
        { 
        }

        public Medico(string name, int age, int weight, int height, string skin, string legajo, string matricula, string especialidad)
            :base(name,age, weight, height, skin, legajo) //Llamado al Constructor de clase Base
        {
            Matricula = matricula;
            Especialidad = especialidad;
        }

        public void Recetar(string farmaco, int dosis, int frecuencia)
        {
            Console.WriteLine($"Tome {dosis} comprimido de {farmaco} cada {frecuencia} Hs.");
        }
    }
}
