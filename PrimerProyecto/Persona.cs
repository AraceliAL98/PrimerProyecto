using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        

        public Persona(int edad, string nombre)
        {
            this.Edad = edad;

            this.Nombre = nombre;
        
        }

        public Persona()

        {
            Edad = 0;

           Nombre = "";
        }

        public void cumplirAno()
        {
            Edad++;
        }
    }
}
