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
            Jugador p6 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p7 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p8 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p9 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p10 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p11 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p12 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p13 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p14 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);
            Jugador p15 = new Jugador("Pablo Contreras", 25, "Chile", 10000, false);

            Entrenador c1 = new Entrenador("Marcelo Bielsa", 50, "Chile", 10000, 1000);
            Medico m1 = new Medico("Doc Perez", 45, "Chile", 10000, 1500);

            List<Jugador> equipo = new List<Jugador>();
            equipo.Add(p1); equipo.Add(p2); equipo.Add(p3); equipo.Add(p4); equipo.Add(p5);
            equipo.Add(p6); equipo.Add(p7); equipo.Add(p8); equipo.Add(p9); equipo.Add(p10);
            equipo.Add(p11); equipo.Add(p12); equipo.Add(p13); equipo.Add(p14); equipo.Add(p15);

            //Creo un equipo.

            Equipo seleccionChilena = new Equipo("Equipo Chileno", equipo, c1, m1, true);

            //Creo algunos jugadores. 

            Jugador p11p = new Jugador("Claudio Bravo", 33, "Peru", 10000, true);
            Jugador p21 = new Jugador("Ismael Fuentes", 20, "Peru", 10000, false);
            Jugador p31 = new Jugador("Waldo Ponce", 22, "Peru", 10000, false);
            Jugador p41 = new Jugador("Mauricio Isla", 25, "Peru", 10000, false);
            Jugador p51 = new Jugador("Pablo Contreras", 25, "Peru", 10000, false);
            Jugador p61 = new Jugador("Pedro Contreras", 25, "Peru", 10000, false);
            Jugador p71 = new Jugador("Juan Contreras", 25, "Peru", 10000, false);
            Jugador p81 = new Jugador("Manuel Contreras", 25, "Peru", 10000, false);
            Jugador p91 = new Jugador("Vicente Contreras", 25, "Peru", 10000, false);
            Jugador p101 = new Jugador("Pablo Contreras", 25, "Peru", 10000, false);
            Jugador p111 = new Jugador("Pablo Contreras", 25, "Peru", 10000, false);
            Jugador p121 = new Jugador("Pablo Contreras", 25, "Peru", 10000, false);
            Jugador p131 = new Jugador("Pablo Contreras", 25, "Peru", 10000, false);
            Jugador p141 = new Jugador("Pablo Contreras", 25, "Peru", 10000, false);
            Jugador p151 = new Jugador("Pablo Contreras", 25, "Peru", 10000, false);

            Entrenador c11 = new Entrenador("Pedro Perez", 50, "P", 10000, 1000);
            Medico m11 = new Medico("Doc Saez", 45, "Peru", 10000, 1500);

            List<Jugador> equipo2 = new List<Jugador>();
            equipo2.Add(p11p); equipo2.Add(p21); equipo2.Add(p31); equipo2.Add(p41); equipo2.Add(p51);
            equipo2.Add(p61); equipo2.Add(p71); equipo2.Add(p81); equipo2.Add(p91); equipo2.Add(p101);
            equipo2.Add(p111); equipo2.Add(p121); equipo2.Add(p131); equipo2.Add(p141); equipo2.Add(p151);

            //Creo otro equipo.

            Equipo seleccionPeruana = new Equipo("Equipo Peruano", equipo2, c11, m11, true);

            Partido final = new Partido(seleccionChilena, seleccionPeruana, 90, "2-1", true);
            final.mostrarResultados();

            //Ahora juguemos a que se lesionen un par de jugadores. 

            final.team1.jugadores[1].onLesionarse(); final.team1.jugadores[2].onLesionarse();
            final.team2.jugadores[5].onLesionarse(); final.team2.jugadores[6].onLesionarse();

            //Finalmente muestro la info de los dos equipos.

            final.team1.mostrarInfo(); final.team2.mostrarInfo();


        }
    }
}
