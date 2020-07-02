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

        //Evaluo puntos de ataque y de defensa del jugador. 
        public void evaluar (Jugador player)
        {
            string output = "Jugador de nombre " + player.Nombre + " tiene "+player.puntosAtaque + " puntos de ataque y " + player.puntosDefensa + " puntos de defensa.";
            Console.WriteLine(output);
        }

        //Metodo curar aumenta puntos de ataque y de defensa. 
        public void curar (Jugador player)
        {

        }


    }
}
