using System;

namespace Práctica
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var ariel = new Medico ("Ariel", 30, 105, 175, "blanca", "45025", "0303456", "Clinico");
            ariel.Presentarse();
            ariel.Respirar("enojado");
            ariel.Trabajar();
            ariel.Recetar("Paracetamol", 1, 8);
        }

        /* 
         Aprender que lo que es una clase, herencia de clase, método, constructor, constructor base y propiedades.
         */
        
         
     
 
       

    }

    

}
