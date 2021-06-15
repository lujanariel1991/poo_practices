using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica
{
    public class Persona
    {
        //Propiedades
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public String ColorPiel { get; set; }

        //constructor
        public Persona()
        {

        }

        public Persona(string name, int age, int weight, int height, string skin)
        {
            Nombre = name;
            Edad = age;
            Peso = weight;
            Altura = height;
            ColorPiel = skin;
        }


        //Metodos
        public void Respirar(string estado)
        {
            Console.WriteLine("{0} está respirando, pesa {1} kg y está {2}", Nombre, 105, estado);
        }

        public void Saludar()
        {
            Console.WriteLine("{0} está saludando", Nombre);
        }

        public void Caminar()
        {
            Console.WriteLine("{0} está caminando", Nombre);
        }
    }


}
