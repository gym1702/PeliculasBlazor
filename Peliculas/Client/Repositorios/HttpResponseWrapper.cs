using System.Net.Http;
using System.Threading.Tasks;

namespace Peliculas.Client.Repositorios
{
    public class HttpResponseWrapper<T>
    {
        //Permite saber si hubo o no error en la peticon Http y
        //obtener respuesta deserializada de dicha peticion

        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public bool Error { get; set; } 
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
