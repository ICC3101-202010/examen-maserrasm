using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenMSSM
{
    public class Entrenador : Persona
    {
        public int puntosTactica { get; set; }
        public Entrenador(string _Nombre, int _Edad, string _Nacion, int _Sueldo, int _puntosTactica)
        {
            this.Nombre = _Nombre;
            this.Edad = _Edad;
            this.Nacion = _Nacion;
            this.Sueldo = _Sueldo;
            this.puntosTactica = _puntosTactica;
        }

        public void cambiarJugador (Jugador player)
        {
            string output = "Jugador de nombre " + player.Nombre + " se ha lesionado y es sacado por el entrenador.";
            Console.WriteLine(output);
        }


    }
}
