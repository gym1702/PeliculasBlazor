using Peliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Peliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;

        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;   
        }


        //Metodos auxiliares para el CRUD
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent =  new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, 
                responseHttp);
        }


        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula(){Titulo = "Spidrman", Lanzamiento = new DateTime(2018,05,22),
                                Poster = "https://th.bing.com/th/id/R.d549e887b6c8d8cda9f5d24ca702032f?rik=JTAkk7i65A4%2bJA&riu=http%3a%2f%2fwww.fonditos3d.com%2f1280x1024%2fsuperheroe-spiderman-3d.jpg&ehk=A0od32tLT9zKz9TMa5cdE7SMP02Y3Z%2fhO9bX17rUdsE%3d&risl=&pid=ImgRaw&r=0"},
                new Pelicula(){Titulo = "Moana", Lanzamiento = new DateTime(2016,04,21),
                                Poster = "https://th.bing.com/th/id/R.868ad2e6843c72864f7e36aa663efe90?rik=d0xMJJxERVHRBQ&pid=ImgRaw&r=0"},
                new Pelicula(){Titulo = "Terminator", Lanzamiento = new DateTime(2010,02,18),
                                Poster ="https://originalvintagemovieposters.com/wp-content/uploads/2021/06/Terminator-2-5942-scaled-768x1140.jpg"}
            };
        }
    }
}
