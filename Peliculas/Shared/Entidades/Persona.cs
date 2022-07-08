using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Shared.Entidades
{
    public  class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        public string Nombre { get; set; }

        //[Required(ErrorMessage = "Este campo es requerido")]
        public string Biografia { get; set; }
                
        //[Required(ErrorMessage = "Este campo es requerido")]
        public string Foto { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        //Utilizado para actores en peliculas
        //Determina cuando una pesona es igual a otra en base al id
        public override bool Equals(object obj)
        {
            if (obj is Persona p2)
            {
                return Id == p2.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //propiedad de navegacion entre persona-pelicula
        public List<PeliculaActor> PeliculasActor { get; set; }
    }
}
