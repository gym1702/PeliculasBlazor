using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Shared.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public bool EnCartelera { get; set; }
        public string Trailer { get; set; }
        public DateTime? Lanzamiento { get; set; }
        public string Poster { get; set; }
        public string TituloCortado 
        { 
            get 
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }

                if(Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            
            }
        }


        //propiedad de relacion entre genero-pelicula
        public List<GeneroPelicula> GenerosPelicula { get; set; } = new List<GeneroPelicula>();

        //propiedad de navegacion entre pelicula-persona
        public List<PeliculaActor> PeliculasActor { get; set; }


    }
}
