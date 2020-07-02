using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenMSSM
{
    public class Equipo
    {
        //Params. de un equipo.
        public List<Jugador> jugadores;
        public Entrenador teamCoach;
        public Medico teamMedic;
        bool esNacional;

        //Constructor. 
        public Equipo(List<Jugador> _jugadores, Entrenador _teamCoach, Medico _teamMedic, bool _esNacional)
        {
            this.jugadores = _jugadores; this.teamCoach = _teamCoach; this.teamMedic = _teamMedic;
            this.esNacional = _esNacional;

            //Cuando creo un equipo, suscribo el evento de que se lesione un jugador al metodo 
            //cambiar jugador del entrenador para cada uno de los jugadores. Esto simula que el jugador le avisa al entrenador cuando
            //se lesiona para que lo saquen. 

            for (int i = 0; i < jugadores.Count(); i++)
            {
                jugadores[i].lesionEvent += new Jugador.lesionEventHandler(teamCoach.cambiarJugador);
            }

        }
            //Funcion que checkea la nacionalidad de los jugadores. 
            public bool checkNacionalidad()
        {
            if (esNacional == true)
            {
                //Comparo nacionalidad de todos con todos. 
                for (int i = 0; i < this.jugadores.Count(); i++)
                {
                    string nac = jugadores[i].Nacion;
                    for (int j = 0; j < this.jugadores.Count(); j++)
                    {
                        string playerNac = jugadores[j].Nacion;
                        if(string.Compare(nac, playerNac) != 0)
                        {
                            Console.WriteLine("Nacionalidad de jugadores no esta ok.");
                            return false;
                        }
                    }
                    Console.WriteLine("Nacionalidad de jugadores esta ok.");
                    return true;
                }
            }

            else
            {
                Console.WriteLine("Equipo no es nacional.");
            }
            return false;

        }
    }
}
