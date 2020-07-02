using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenMSSM
{
    public class Jugador : Persona
    {
        //Defino parametros unicos al jugador. 
        public int puntosAtaque { get; set; }
        public int puntosDefensa { get; set; }
        public int numCamiseta { get; set; }
        public bool esArquero { get; set; }

        //Constructor. 
        public Jugador(string _Nombre, int _Edad, string _Nacion, int _Sueldo, bool _esArquero)
        {
            this.Nombre = _Nombre;
            this.Edad = _Edad;
            this.Nacion = _Nacion;
            this.Sueldo = _Sueldo; 
        }

        //Delegate y evento cuando un jugador se lesiona. 
        public delegate void lesionEventHandler(Jugador player);
        public event lesionEventHandler lesionEvent;

        public void onLesionarse()
        {
            //Invoco el evento. 
            if (lesionEvent != null)
            {
                lesionEvent.Invoke(this);
            }
        }


    }
}
