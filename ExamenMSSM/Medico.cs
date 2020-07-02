using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenMSSM
{
    public class Medico : Persona
    {

        public int puntosExperiencia { get; set; }
        
        public Medico(string _Nombre, int _Edad, string _Nacion, int _Sueldo, int _puntosExperiencia)
        {
            this.Nombre = _Nombre;
            this.Edad = _Edad;
            this.Nacion = _Nacion;
            this.Sueldo = _Sueldo;
            this.puntosExperiencia = _puntosExperiencia;
        }

        public void evaluar (Jugador player)
        {

        }

        public void curar (Jugador player)
        {

        }


    }
}
