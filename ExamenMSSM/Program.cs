using System;
using System.Collections.Generic;

namespace ExamenMSSM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo algunos jugadores. 

            Jugador p1 = new Jugador("Claudio Bravo", 33, "Chile", 10000, true);
            Jugador p2 = new Jugador("Ismael Fuentes", 20, "Chile", 10000, false);
            Jugador p3= new Jugador("Waldo Ponce", 22, "Chile", 10000, false);
            Jugador p4 = new Jugador("Mauricio Isla", 25, "Chile", 10000, false);
            Jugador p5 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);

            Entrenador c1 = new Entrenador("Marcelo Bielsa", 50, "Chile", 10000, 1000);
            Medico m1 = new Medico("Doc Perez", 45, "Chile", 10000, 1500);

            List<Jugador> equipo = new List<Jugador>();
            equipo.Add(p1); equipo.Add(p2); equipo.Add(p3); equipo.Add(p4); equipo.Add(p5);

            //Creo el equipo.

            Equipo seleccionChilena = new Equipo(equipo, c1, m1, true);
            seleccionChilena.checkNacionalidad();



            //Ahora juguemos un poco. 

            //Pruebo que se lesionen algunos jugadores. 




            p1.onLesionarse(); p2.onLesionarse(); 



        }
    }
}
