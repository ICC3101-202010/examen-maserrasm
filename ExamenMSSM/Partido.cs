﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenMSSM
{
    public class Partido
    {
        public Equipo team1; public Equipo team2;
        public int duracion; public string resultado;
        public bool esNacional;

        public Partido(Equipo _team1, Equipo _team2, int _duracion, string _resultado, bool _esNacional)
        {
            this.team1 = _team1; this.team2 = _team2; this.duracion = _duracion; this.resultado = _resultado;
            this.esNacional = _esNacional; 
        }
    }
}
