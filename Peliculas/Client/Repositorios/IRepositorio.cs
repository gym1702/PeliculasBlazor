using Peliculas.Shared.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Peliculas.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();

        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
    }
}
