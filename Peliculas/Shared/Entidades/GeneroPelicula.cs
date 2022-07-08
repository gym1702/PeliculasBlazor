using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Shared.Entidades
{
    public class GeneroPelicula
    {
        public int PeliculaId { get; set; }
        public int GeneroId { get; set; }


        //propiedades de navegacion
        public Genero Genero { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
