﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Shared.Entidades
{
    public class PeliculaActor
    {
        public int PersonaId { get; set; }
        public int PeliculaId { get; set; }
        public string Personaje { get; set; }
        public int Orden { get; set; }


        //propiedades de navegacion
        public Persona Persona { get; set; }
        public Pelicula Pelicula { get; set; }

    }
}
